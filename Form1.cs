using ExcelDataReader;
using System.Configuration;
using System.Data;
using System.Text;

namespace excel_deskapp
{
    public partial class Form1 : Form
    {
        public DataGridView SchemaTable = new DataGridView();
        public DataGridView SchemaInputs = new DataGridView();
        public DataGridView SchemaLoopInputs = new DataGridView();
        public bool SchemaIsAddRowBetween = false;
        public bool SchemaIsHorizontal = false;
        public int SchemaLineStartCount = 0;

        public Form1()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = SchemaTable.Rows.Count.ToString();
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
                    var v = ConfigurationManager.AppSettings["ConfigPath"];
                    MessageBox.Show(v);
                    dataGridResult.DataSource = ds.Tables[0];
                }
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}