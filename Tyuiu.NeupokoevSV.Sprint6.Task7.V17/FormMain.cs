using System.IO;
using Tyuiu.NeupokoevSV.Sprint6.Task7.V17.Lib;
namespace Tyuiu.NeupokoevSV.Sprint6.Task7.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_NSV.Filter = " Значения, разделенные запятыми(*csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_NSV.Filter= " Значения, разделенные запятыми(*csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int cols;
        static string openFilePath;
        DataService ds = new DataService();
        public static int[,] Load(string file)
        {
            string fileData = File.ReadAllText(file);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;
            int[,] array = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] line_i = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = Convert.ToInt32(line_i[j]);
                }
            }
            return array;
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonFileOpen_NSV_Click(object sender, EventArgs e)
        {
            openFileDialog_NSV.ShowDialog();
            openFilePath = openFileDialog_NSV.FileName;
            int[,] array = new int[rows, cols];
            array = Load(openFilePath);
            dataGridViewIn.ColumnCount = cols;
            dataGridViewIn.RowCount = rows;
            dataGridViewOut.ColumnCount = cols;
            dataGridViewOut.RowCount = rows;
            for (int i = 0;i < cols;i++)
            {
                dataGridViewIn.Columns[i].Width = 25;
                dataGridViewOut.Columns[i].Width = 25;
            }
            for (int r  = 0;r < rows; r++)
            {
                for (int c = 0;c < cols;c++)
                {
                    dataGridViewIn.Rows[r].Cells[c].Value = array[r, c];
                }
            }
            array = ds.GetMatrix(openFilePath);
            buttonVipoln_NSV.Enabled = true;
        }
    }
}
