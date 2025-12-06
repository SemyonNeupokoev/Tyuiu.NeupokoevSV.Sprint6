namespace Tyuiu.NeupokoevSV.Sprint6.Task0.V3;

using Tyuiu.NeupokoevSV.Sprint6.Task0.V3.Lib;
public partial class FormMain_NSV : Form
{
    public FormMain_NSV()
    {
        InitializeComponent();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {

    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged_1(object sender, EventArgs e)
    {

    }

    private void buttonDone_NSV_Click(object sender, EventArgs e)
    {
        DataService ds = new DataService();
        try
        {
            textBoxResult_NSV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxX_NSV.Text)));
        }
        catch
        {
            MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void textBoxVivod_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBoxResult_NSV_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBoxX_NSV_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBoxXX_NSV(object sender, KeyPressEventArgs e)
    {
        if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != '8'))
        {
            e.Handled = true;
        }
    }
}
