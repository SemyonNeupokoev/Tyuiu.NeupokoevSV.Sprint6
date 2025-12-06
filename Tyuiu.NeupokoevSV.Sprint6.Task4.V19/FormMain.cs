using System.Diagnostics;
using System.Windows.Forms;
using Tyuiu.NeupokoevSV.Sprint6.Task4.V19.Lib;
namespace Tyuiu.NeupokoevSV.Sprint6.Task4.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        } 
        DataService ds = new DataService();
        private void buttoneDone_NSV_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_NSV.Text);
                int stop = Convert.ToInt32(textBoxKonec_NSV.Text);

                int len = ds.GetMassFunction(start, stop).Length;
                double[] value = new double[len];
                value = ds.GetMassFunction(start, stop);
                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxVivodRes_NSV.Text = "";
                chartFunction.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chartFunction.Series[0].Points.AddXY(start, value[i]);
                    textBoxVivodRes_NSV.AppendText(value[i] + Environment.NewLine);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSpravka_NSV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПИНб-25-1 Неупокоев Семён Вячеславович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void buttonSohr_NSV_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask4.txt");
                File.WriteAllText(path, textBoxVivodRes_NSV.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно! \n Открыть егo в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    Process txt = new Process(); 
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
