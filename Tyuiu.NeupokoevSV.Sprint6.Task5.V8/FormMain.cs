using System.Diagnostics;
using Tyuiu.NeupokoevSV.Sprint6.Task5.V8.Lib;
namespace Tyuiu.NeupokoevSV.Sprint6.Task5.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\semyon\source\repos\Tyuiu.NeupokoevSV.Sprint6\InPutDataFileTask5V8.txt";

        private void buttonDone_NSV_Click(object sender, EventArgs e)
        {
            dataGridViewVivod_NSV.ColumnCount = 2;
            dataGridViewVivod_NSV.Columns[0].Width = 30;
            dataGridViewVivod_NSV.Columns[1].Width = 60;
            this.chartFunction_NSV.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartFunction_NSV.ChartAreas[0].AxisY.Title = "Ось Y";
            chartFunction_NSV.Series[0].Points.Clear();
            double[] num = new double[ds.len];
            num = ds.LoadFromDataFile(path);
            for (int i = 0; i < num.Length; i++)
            {
                dataGridViewVivod_NSV.Rows.Add(Convert.ToString(i), Convert.ToString(num[i]));
                chartFunction_NSV.Series[0].Points.AddXY(i, -num[i]);
            }

        }

        private void buttonOtkrFile_NSV_Click(object sender, EventArgs e)
        {
            Process txt = new Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonSpravka_NSV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПИНб-25-1 Неупокоев Семён Вячеславович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
