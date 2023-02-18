using ExcelDataReader;
using System.Configuration;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace excel_deskapp
{
    public partial class FormGenerate : Form
    {
        public string? InitialSchemaFileName = null;

        public DataGridView SchemaTable = new DataGridView();
        public DataGridView SchemaInputs = new DataGridView();
        public DataGridView SchemaLoopInputs = new DataGridView();
        public bool SchemaIsHorizontal = false;
        public int SchemaLineStartCount = 0;
        public string SchemaOwner = "";

        public FormGenerate()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            InitializeComponent();
        }

        private void FormGenerate_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(InitialSchemaFileName))
                return;

            loadDataFromSave(InitialSchemaFileName);
        }

        private void loadDataFromSave(string folderName)
        {
            folderName = @$"{ConfigurationManager.AppSettings.Get("RecordsPath") ?? @"C:\Apps\Excel2Excel\Records"}\{folderName}";

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
            SchemaIsHorizontal = horizontal.Contains("True") ? true : false;

            string startCount = File.ReadAllText(fileStartCount);
            SchemaLineStartCount = Convert.ToInt32(startCount);

            string owner = File.ReadAllText(fileOwner);
            SchemaOwner = owner;

            clearGridSelectedCell(dataGridViewSingle);
            clearGridSelectedCell(dataGridViewMultiple);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        DataSet ds;

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream fileStream = File.Open(dialog.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateReader(fileStream);
                    ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        //ConfigureDataTable = (_)=> new ExcelDataTableConfiguration() { UseHeaderRow = true }
                    });
                    dataGridSourceGenerate.DataSource = ds.Tables[0];
                }
            }
        }

        private void dataSchemaFromFile(string fileName, DataGridView dataGrid)
        {
            FileStream fileStream = File.Open(fileName, FileMode.Open, FileAccess.Read);
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

        private void renderSpecialDataTable(int rowIndex, int columnIndex, string text = "", string? value = null)
        {
            bool isUpdate = false;
            for (int i = 0; i < dataGridViewSingle.Rows.Count; i++)
            {
                if (dataGridViewSingle.Rows[i].Cells[0].Value?.ToString() == rowIndex + "-" + columnIndex)
                {
                    isUpdate = true;
                    dataGridViewSingle.Rows[i].Cells[1].Value = text;
                    dataGridViewSingle.Rows[i].Cells[2].Value = value ?? text;
                    break;
                }
            }

            if (isUpdate)
                return;

            if (dataGridViewSingle.Columns.Count <= 0)
            {
                dataGridViewSingle.Columns.Add(Constans.HeaderTextPosition, Constans.HeaderTextPosition);
                dataGridViewSingle.Columns.Add(Constans.HeaderTextDescription, Constans.HeaderTextDescription);
                dataGridViewSingle.Columns.Add(Constans.HeaderTextDefaultValue, Constans.HeaderTextDefaultValue);
                dataGridViewSingle.Columns.Add(Constans.HeaderTextSourcePosition, Constans.HeaderTextSourcePosition);
            }
            dataGridViewSingle.Rows.Add(rowIndex + "-" + columnIndex, text, value ?? text);

            for (int i = 0; i < dataGridViewSingle.Rows.Count; i++)
            {
                if (!dataGridViewSingle.Rows[i].IsNewRow)
                {
                    //dataGridViewInputs.Rows[i].Cells[0].ReadOnly = true;
                    dataGridViewSingle.Rows[i].Cells[0].Style.BackColor = Color.Azure;
                }
            }
        }

        private void toGridMultiDataSource(DataTable dt)
        {
            dataGridViewMultiple.DataSource = dt;
            for (int i = 0; i < dataGridViewMultiple.Rows.Count; i++)
            {
                dataGridViewMultiple.Rows[i].Cells[0].Style.BackColor = Color.BurlyWood;
            }
        }

        private void useColumnSettingMultiArea(DataTable dt)
        {
            dt.Columns.Add(Constans.HeaderTextPosition);
            dt.Columns.Add(Constans.HeaderTextDescription);
            dt.Columns.Add(Constans.HeaderTextDefaultValue);
            dt.Columns.Add(Constans.HeaderTextSourcePosition);
            dt.Columns[0].ReadOnly = true;
        }

        DataGridView? usedView;

        private void dataGridGenerate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (usedView == null)
                return;
            if(e.RowIndex <= -1 || e.ColumnIndex <= -1)
                return;
            if(usedView.SelectedCells.Count <= 0) 
                return;
            int selectedRow = usedView.SelectedCells[0].RowIndex;
            int cellIndex = usedView.Rows[selectedRow].Cells.Count - 1;
            string positionValue = e.RowIndex.ToString() + "-" + e.ColumnIndex.ToString();
            usedView.Rows[selectedRow].Cells[cellIndex].Value = positionValue;
            usedView.Rows[selectedRow].Cells[cellIndex].Style.BackColor = Color.LawnGreen;

            clearGridSelectedCell(usedView);
            usedView = null;
        }

        private void dataGridViewSingle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usedView = dataGridViewSingle;
            ctrlGridSelectionColor(dataGridViewSingle);
        }

        private void dataGridViewMultiple_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usedView = dataGridViewMultiple;
            ctrlGridSelectionColor(dataGridViewMultiple);
        }

        private void ctrlGridSelectionColor(DataGridView dataGridView)
        {
            int rowIndex = dataGridView.SelectedCells[0].RowIndex;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Index == rowIndex)
                {
                    if (string.IsNullOrEmpty(row.Cells[row.Cells.Count - 1].Value?.ToString()))
                        row.Cells[row.Cells.Count - 1].Style.BackColor = Color.Teal;
                }
                else
                {
                    if (string.IsNullOrEmpty(row.Cells[row.Cells.Count - 1].Value?.ToString()))
                        row.Cells[row.Cells.Count - 1].Style.BackColor = Color.White;
                }
            }
        }

        private void clearGridSelectedCell(DataGridView dataGridView)
        {
            foreach (DataGridViewCell cell in dataGridView.SelectedCells)
            {
                cell.Selected = false;
            }
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            setPreviewDataFromSingleGrid(dataGridSourceGenerate, dataGridSchema, dataGridViewSingle);
            setPreviewDataFromMultipleGrid(dataGridSourceGenerate, dataGridSchema, dataGridViewMultiple, 
                SchemaLineStartCount, Convert.ToInt32(numericUpDownFinishLineCount.Value), checkBoxAddBetweenLines.Checked);
        }

        private void setPreviewDataFromSingleGrid(DataGridView sourceGrid, DataGridView previewGrid, DataGridView optionsGrid)
        {
            for (int i = 0; i < optionsGrid.Rows.Count; i++)
            {
                string? positon = optionsGrid.Rows[i].Cells[0].Value?.ToString();
                positon = positon ?? "";
                string[] splitPosition = positon.Split("-");
                if (splitPosition.Length != 2)
                    continue;
                int rowIndex = Convert.ToInt32(splitPosition[0]);
                int columnIndex = Convert.ToInt32(splitPosition[1]);

                string? sourcePos = optionsGrid.Rows[i].Cells[3].Value?.ToString();
                sourcePos = sourcePos ?? "";
                string[] splitSourcePos = sourcePos.Split("-");

                if (splitSourcePos.Length == 2)
                {
                    int sourceRowIndex = Convert.ToInt32(splitSourcePos[0]);
                    int sourceColumnIndex = Convert.ToInt32(splitSourcePos[1]);
                    previewGrid[columnIndex, rowIndex].Value = sourceGrid[sourceColumnIndex, sourceRowIndex].Value;
                }
                else
                {
                    previewGrid[columnIndex, rowIndex].Value = optionsGrid.Rows[i].Cells[2].Value?.ToString();
                }
            }
        }

        private void setPreviewDataFromMultipleGrid(DataGridView sourceGrid, DataGridView previewGrid, DataGridView optionsGrid, int addedCount = 0, int finishCount = 0, bool isAddBetween = false)
        {
            if (finishCount < 0)
                return;

            for (int c = addedCount; c <= finishCount; c++)
            {
                for (int i = 0; i < optionsGrid.Rows.Count; i++)
                {
                    string? positon = optionsGrid.Rows[i].Cells[0].Value?.ToString();
                    positon = positon ?? "";
                    string[] splitPosition = positon.Split("-");
                    if (splitPosition.Length != 2)
                        continue;
                    int rowIndex = Convert.ToInt32(splitPosition[0]);
                    int columnIndex = Convert.ToInt32(splitPosition[1]);

                    if (SchemaIsHorizontal)
                        columnIndex += c;
                    else
                        rowIndex += c;

                    if (isAddBetween && i == 0)
                    {
                        DataTable dataTable = (DataTable)previewGrid.DataSource;
                        DataRow drToAdd = dataTable.NewRow();
                        for (int b = 0; b < dataTable.Rows[rowIndex].ItemArray.Length; b++)
                        {
                            drToAdd[b] = dataTable.Rows[rowIndex].ItemArray[b];
                        }
                        dataTable.Rows.InsertAt(drToAdd, rowIndex);
                        ///dataTable.AcceptChanges();
                        previewGrid.DataSource = dataTable;
                        previewGrid.Refresh();
                    }

                    string? sourcePos = optionsGrid.Rows[i].Cells[3].Value?.ToString();
                    sourcePos = sourcePos ?? "";
                    string[] splitSourcePos = sourcePos.Split("-");

                    if (previewGrid.Rows.Count < rowIndex + 1)
                        return;

                    if (splitSourcePos.Length == 2)
                    {
                        int sourceRowIndex = Convert.ToInt32(splitSourcePos[0]);
                        int sourceColumnIndex = Convert.ToInt32(splitSourcePos[1]);

                        if (SchemaIsHorizontal)
                            sourceColumnIndex += c;
                        else
                            sourceRowIndex += c;

                        previewGrid[columnIndex, rowIndex].Value = sourceGrid[sourceColumnIndex, sourceRowIndex].Value;
                    }
                    else
                    {
                        previewGrid[columnIndex, rowIndex].Value = optionsGrid.Rows[i].Cells[2].Value;
                    }

                }
            }

        }

    }
}