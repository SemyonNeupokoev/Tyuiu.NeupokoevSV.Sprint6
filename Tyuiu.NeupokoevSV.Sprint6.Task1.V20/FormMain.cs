using Tyuiu.NeupokoevSV.Sprint6.Task1.V20.Lib;
namespace Tyuiu.NeupokoevSV.Sprint6.Task1.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void ButtonDoneC_NSV(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxVvodSt_NSV.Text);
                int stop = Convert.ToInt32(textBoxVvodStop_NSV.Text);
                string strline;
                int len = ds.GetMassFunction(start, stop).Length;
                double[] value;
                value = new double[len];
                value = ds.GetMassFunction(start, stop);
                textBoxRess_NSV.Text = "";
                textBoxRess_NSV.AppendText("+-----------+------------+" + Environment.NewLine);
                textBoxRess_NSV.AppendText("|    x      |     f(x)   |" + Environment.NewLine);
                textBoxRess_NSV.AppendText("+-----------+------------+" + Environment.NewLine);
                for (int i = 0; i < len; i++)
                {
                    strline = String.Format("|{0,5:d}      |    {1,6:f2}  | ", start, value[i]);
                    textBoxRess_NSV.AppendText(strline + Environment.NewLine);
                    start++;
                }
                textBoxRess_NSV.AppendText("+-----------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_NSV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

