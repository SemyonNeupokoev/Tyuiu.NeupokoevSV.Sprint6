using Tyuiu.NeupokoevSV.Sprint6.Task2.V2.Lib;
namespace Tyuiu.NeupokoevSV.Sprint6.Task2.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_NSV_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStarr_NSV.Text);
                int stop = Convert.ToInt32(textBoxStop_NSV.Text);
                int len = ds.GetMassFunction(start, stop).Length;
                double[] value = new double[len];
                value = ds.GetMassFunction(start, stop);

                this.chart.Titles.Add("График функции sin(x)");
                this.chart.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chart.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(start), Convert.ToString(value[i]));
                    this.chart.Series[0].Points.AddXY(start, value[i]);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ButtonDone_MouseEnter_NSV(object sender, EventArgs e)
        {

        }

        private void dataGridViewFunction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSpravka_NSV_Click(object sender, EventArgs e)
        {

        }
    }
}
