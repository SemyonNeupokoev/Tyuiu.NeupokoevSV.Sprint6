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
            saveFileDialog_NSV.Filter = " Значения, разделенные запятыми(*csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static string openFilePath;
        static int rows;
        static int cols;

        DataService ds = new DataService();
        public static int[,] Load(string file)
        {
            string fileData = File.ReadAllText(file);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            cols = lines[0].Split(';').Length;
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
            for (int i = 0; i < cols; i++)
            {
                dataGridViewIn.Columns[i].Width = 35;
                dataGridViewOut.Columns[i].Width = 35;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewIn.Rows[r].Cells[c].Value = array[r, c];
                }
            }
            array = ds.GetMatrix(openFilePath);
            buttonVipoln_NSV.Enabled = true;
        }

        private void buttonHelp_NSV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonVipoln_NSV_Click(object sender, EventArgs e)
        {
            int[,] array = new int[rows, cols];
            array = ds.GetMatrix(openFilePath);
            for (int i = 0; i < rows; i++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewOut.Rows[i].Cells[c].Value = array[i, c];
                }
            }
            buttonSohr_NSV.Enabled = true;
        }

        private void buttonSohr_NSV_Click(object sender, EventArgs e)
        {
            saveFileDialog_NSV.FileName = "OutPutFileTask7.csv";
            saveFileDialog_NSV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_NSV.ShowDialog();
            string path = saveFileDialog_NSV.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut.Rows.Count;
            int cols = dataGridViewOut.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str = str + dataGridViewOut.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";

            }
        }

        private void buttonFileOpen_NSV_MouseEnter(object sender, EventArgs e)
        {
            toolTip_NSV.ToolTipTitle = "Открыть файл";
        }

        private void buttonVipoln_NSV_MouseEnter(object sender, EventArgs e)
        {
            toolTip_NSV.ToolTipTitle = "Выполнить";
        }

        private void buttonSohr_NSV_MouseEnter(object sender, EventArgs e)
        {
            toolTip_NSV.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_NSV_MouseEnter(object sender, EventArgs e)
        {
            toolTip_NSV.ToolTipTitle = "Справка";
        }

        private void toolTip_NSV_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
