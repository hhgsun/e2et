using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace excel2excel_template
{
    public partial class FormSchemaEdit : Form
    {
        public string? InitialSchemaFileName = null;
        public FormSchemas? formSchemasInstance = null;

        public FormSchemaEdit()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            InitializeComponent();
        }

        private void btnNewSchemaArea_Click(object sender, EventArgs e)
        {
            renderSpecialDataTable(0, 0);
        }

        private void renderSpecialDataTable(int rowIndex, int columnIndex, string text = "", string? value = null)
        {
            bool isUpdate = false;
            for (int i = 0; i < dataGridViewInputs.Rows.Count; i++)
            {
                if(dataGridViewInputs.Rows[i].Cells[0].Value?.ToString() == rowIndex + "-" + columnIndex)
                {
                    isUpdate = true;
                    dataGridViewInputs.Rows[i].Cells[1].Value = text;
                    dataGridViewInputs.Rows[i].Cells[2].Value = value ?? text;
                    break;
                }
            }

            if (isUpdate)
                return;

            if (dataGridViewInputs.Columns.Count <= 0)
            {
                dataGridViewInputs.Columns.Add(Constans.HeaderTextPosition, Constans.HeaderTextPosition);
                dataGridViewInputs.Columns.Add(Constans.HeaderTextDescription, Constans.HeaderTextDescription);
                dataGridViewInputs.Columns.Add(Constans.HeaderTextDefaultValue, Constans.HeaderTextDefaultValue);
            }
            dataGridViewInputs.Rows.Add(rowIndex + "-" + columnIndex, text, value ?? text);

            for (int i = 0; i < dataGridViewInputs.Rows.Count; i++)
            {
                if (!dataGridViewInputs.Rows[i].IsNewRow)
                {
                    //dataGridViewInputs.Rows[i].Cells[0].ReadOnly = true;
                    dataGridViewInputs.Rows[i].Cells[0].Style.BackColor = Color.Azure;
                }
            }
        }

        private void toGridMultiDataSource(DataTable dt)
        {
            dataGridMultiArea.DataSource = dt;
            for (int i = 0; i < dataGridMultiArea.Rows.Count; i++)
            {
                dataGridMultiArea.Rows[i].Cells[0].Style.BackColor = Color.BurlyWood;
            }
        }

        private void useColumnSettingMultiArea(DataTable dt)
        {
            dt.Columns.Add(Constans.HeaderTextPosition);
            dt.Columns.Add(Constans.HeaderTextDescription);
            dt.Columns.Add(Constans.HeaderTextDefaultValue);
            dt.Columns[0].ReadOnly = true;
        }

        private void renderMultiDataTable(int rowIndex)
        {
            if (dataGridSchema.Rows.Count <= 0 || dataGridSchema.Columns.Count <= 0)
            {
                MessageBox.Show(Constans.MessageUploadFile);
                return;
            }
            DataGridViewRow selectedRow = dataGridSchema.Rows[rowIndex];
            if (selectedRow == null)
                return;

            if (selectedRow.Cells.Count <= 0)
                return;

            DataTable dt = new DataTable();
            useColumnSettingMultiArea(dt);

            for (int i = 0; i < selectedRow.Cells.Count; i++)
            {
                DataRow row = dt.NewRow();
                row[0] = selectedRow.Cells[i].RowIndex + "-" + selectedRow.Cells[i].ColumnIndex;
                row[1] = selectedRow.Cells[i].Value;
                row[2] = selectedRow.Cells[i].Value;
                dt.Rows.Add(row);
            }
            toGridMultiDataSource(dt);
        }

        DataSet ds;
        string openFileName;

        private void sablonSecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    dataSchemaFromFile(dialog.FileName, dataGridSchema);

                    dataGridMultiArea.DataSource = null;
                    dataGridMultiArea.Rows.Clear();
                    dataGridMultiArea.Refresh();
                    dataGridViewInputs.DataSource = null;
                    dataGridViewInputs.Rows.Clear();
                    dataGridViewInputs.Refresh();
                }
            }
        }

        private void dataSchemaFromFile(string fileName, DataGridView dataGrid)
        {
            openFileName = fileName;
            if (!File.Exists(openFileName))
                return;
            FileStream fileStream = File.Open(openFileName, FileMode.Open, FileAccess.Read);
            IExcelDataReader reader = ExcelReaderFactory.CreateReader(fileStream);
            ds = reader.AsDataSet(new ExcelDataSetConfiguration());
            dataGrid.DataSource = ds.Tables[0];
            reader.Close();

            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                dataGrid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                dataGrid.Rows[i].HeaderCell.Value = i.ToString();
            }
        }

        private void dataGridSchema_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex <= -1)
            {
                MessageBox.Show(Constans.MessageInvalid);
                return;
            }
            if(e.ColumnIndex <= -1)
            {
                this.dataGridSchema.Rows[e.RowIndex].Cells[0].Selected = true;
                renderMultiDataTable(e.RowIndex);
                return;
            }

            string text = this.dataGridSchema.SelectedCells.Count > 0 ? this.dataGridSchema.SelectedCells[0].Value.ToString() : "";

            renderSpecialDataTable(e.RowIndex, e.ColumnIndex, text);
        }

        private string getFilePathAndFolderCheck(string uid)
        {
            string folder = @$"{ConfigurationManager.AppSettings.Get("RecordsPath") ?? @"C:\Apps\Excel2ExcelTemplate\Records"}\{uid}";
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);
            return folder;
        }

        private void saveFileExcel(string folder, string destFileName, string sourceFileName)
        {
            try
            {
                var sourceFile = new FileInfo(sourceFileName);
                var destFileStr = @$"{folder}\{destFileName}.xlsx";
                if(sourceFileName != destFileStr)
                {
                    File.Delete(destFileStr);
                    sourceFile.CopyTo(destFileStr, true);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void saveFileGridView(string folder, string fileName, DataGridView dataGridView)
        {
            string path = @$"{folder}\{fileName}.txt";
            TextWriter writer = new StreamWriter(path);
            string row = "";
            string divider = ConfigurationManager.AppSettings.Get("FileGridDivider") ?? "|____|";
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                row += dataGridView.Rows[i].Cells[0].Value?.ToString() ?? "";
                row += divider;
                row += dataGridView.Rows[i].Cells[1].Value?.ToString() ?? "";
                row += divider;
                row += dataGridView.Rows[i].Cells[2].Value?.ToString() ?? "";

                row = row.Replace(Environment.NewLine, " ").Replace("\n", " ");

                writer.WriteLine(row);
                row = "";
            }
            writer.Close();
        }

        private void saveFileSettingOptions(string folder, string fileName, string value)
        {
            string path = @$"{folder}\{fileName}.txt";
            TextWriter writer = new StreamWriter(path);
            writer.Write(value);
            writer.Close();
        }

        private void loadDataFromSave(string folderName)
        {
            folderName = @$"{ConfigurationManager.AppSettings.Get("RecordsPath") ?? @"C:\Apps\Excel2ExcelTemplate\Records"}\{folderName}";

            string fileSpecial = @$"{folderName}\{ConfigurationManager.AppSettings.Get("FileNameSchemaSpecial") ?? "single"}.txt";
            string fileMultiple = @$"{folderName}\{ConfigurationManager.AppSettings.Get("FileNameSchemaMultiple") ?? "multiple"}.txt";
            string fileHorizontal = @$"{folderName}\{ConfigurationManager.AppSettings.Get("FileNameSchemaMultipleHorizontal") ?? "_horizontal"}.txt";
            string fileStartCount = @$"{folderName}\{ConfigurationManager.AppSettings.Get("FileNameSchemaMultipleStartCount") ?? "_startcount"}.txt";
            string fileOwner = @$"{folderName}\{ConfigurationManager.AppSettings.Get("FileNameOwner") ?? "owner"}.txt";
            string fileExcel = @$"{folderName}\{ConfigurationManager.AppSettings.Get("FileNameExcel") ?? "excel"}.xlsx";

            dataSchemaFromFile(fileExcel, dataGridSchema);

            string[] specials = File.ReadAllLines(fileSpecial);
            for (int i = 0; i < specials.Length; i++)
            {
                int row = i;
                int col = 0;
                string[] splitLine = specials[i].Split(ConfigurationManager.AppSettings.Get("FileGridDivider") ?? "|____|");
                if (string.IsNullOrEmpty(splitLine[0]))
                    continue;
                string[] splitPos = splitLine[0].Split("-");
                row = Convert.ToInt32(splitPos[0]);
                col = Convert.ToInt32(splitPos[1]);
                renderSpecialDataTable(row, col, splitLine[1], splitLine[2]);
            }

            string[] multiple = File.ReadAllLines(fileMultiple);
            DataTable dt = new DataTable();
            useColumnSettingMultiArea(dt);
            for (int i = 0; i < multiple.Length; i++)
            {
                string[] splitLine = multiple[i].Split(ConfigurationManager.AppSettings.Get("FileGridDivider") ?? "|____|");
                if (string.IsNullOrEmpty(splitLine[0]))
                    continue;
                DataRow r = dt.NewRow();
                r[0] = splitLine[0];
                r[1] = splitLine[1];
                r[2] = splitLine[2];
                dt.Rows.Add(r);
            }
            toGridMultiDataSource(dt);

            string horizontal = File.ReadAllText(fileHorizontal);
            checkBoxIsHorizontal.Checked = horizontal.Contains("True") ? true : false;

            string startCount = File.ReadAllText(fileStartCount);
            txtBoxLineStartCount.Text = startCount;

            string owner = File.ReadAllText(fileOwner);
            textBoxSchemaName.Text = owner;
        }

        private void FormSchemaEdit_Load(object sender, EventArgs e)
        {
            this.Text = Constans.AppName + " > Şablon Ekle";

            if (string.IsNullOrEmpty(InitialSchemaFileName))
                return;

            this.Text = Constans.AppName + " > Şablon Düzenle";
            loadDataFromSave(InitialSchemaFileName);
        }

        private void buttonSaveSchema_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSchemaName.Text))
            {
                MessageBox.Show(Constans.MessageSchemaNameField);
                return;
            }

            string uid = Guid.NewGuid().ToString();
            if (!string.IsNullOrEmpty(InitialSchemaFileName))
                uid = InitialSchemaFileName;

            string folder = getFilePathAndFolderCheck(uid);
            saveFileGridView(folder, ConfigurationManager.AppSettings.Get("FileNameSchemaSpecial") ?? "single", this.dataGridViewInputs);
            saveFileGridView(folder, ConfigurationManager.AppSettings.Get("FileNameSchemaMultiple") ?? "multiple", this.dataGridMultiArea);
            saveFileSettingOptions(folder, ConfigurationManager.AppSettings.Get("FileNameSchemaMultipleHorizontal") ?? "_horizontal", checkBoxIsHorizontal.Checked.ToString());
            saveFileSettingOptions(folder, ConfigurationManager.AppSettings.Get("FileNameSchemaMultipleStartCount") ?? "_startcount", txtBoxLineStartCount.Value.ToString());
            saveFileSettingOptions(folder, ConfigurationManager.AppSettings.Get("FileNameOwner") ?? "owner", textBoxSchemaName.Text);
            saveFileExcel(folder, ConfigurationManager.AppSettings.Get("FileNameExcel") ?? "excel", openFileName);
            formSchemasInstance?.Show();
            formSchemasInstance?.loadDataToForm();
            this.Hide();
        }

        private void buttonHelpSingle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Burası şablondaki özel alanları belirtmek için \nSoldaki tablonun hücrelerine çift tıklayarak buraya atama yapabilirsiniz.");
        }

        private void buttonHelpMultiple_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Burası şablonda tekrarlı olan alanları belirtmek için \nSoldaki tablonun satır numaralarına çift tıklayarak buraya atama yapabilirsiniz.");
        }
    }
}
