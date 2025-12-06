using Tyuiu.NeupokoevSV.Sprint6.Task3.V7.Lib;
namespace Tyuiu.NeupokoevSV.Sprint6.Task3.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { 31, 25, -18, 12, 9 }, { 6, 34, -2, 2, -18 }, { -5, 4, 27, 4, -1 }, { 4, 15, 34, -6, -10 }, { 0, 8, 5, 14, -17 } };
        private void buttonDone_NSV_Click(object sender, EventArgs e)
        {
            textBoxVivodRes_NSV.Text = Convert.ToString(ds.Calculate(mtrx));
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int cols = mtrx.Length / rows;
            dataGridViewMatrix_NSV.ColumnCount = cols;
            dataGridViewMatrix_NSV.RowCount = rows;
            for (int i = 0; i < cols; i++)
            {
                dataGridViewMatrix_NSV.Columns[i].Width = 45;
            }
            int[,] sortedMatrix = ds.Calculate(mtrx);

            // Заполняем DataGridView
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrix_NSV.Rows[i].Cells[j].Value = Convert.ToString(sortedMatrix[i, j]);
                }
            }

        }

        private void buttonAsk_NSV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПИНб-25-1 Неупокоев Семён Вячеславович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
