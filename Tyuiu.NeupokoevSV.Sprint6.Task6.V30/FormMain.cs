using Tyuiu.NeupokoevSV.Sprint6.Task6.V30.Lib;


namespace Tyuiu.NeupokoevSV.Sprint6.Task6.V30
{
    public partial class FormMain : Form
    {
        
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;    
        DataService ds = new DataService();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonSearchInFile_NSV_Click(object sender, EventArgs e)
        {
            textBoxVivod_NSV.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonFileOpen_NSV_Click(object sender, EventArgs e)
        {
            openFileDialog_NSV.ShowDialog();
            openFilePath = openFileDialog_NSV.FileName;
            textBoxVvod_NSV.Text = File.ReadAllText(openFilePath);
            groupBoxVvod_NSV.Text = groupBoxVvod_NSV.Text + " " + openFileDialog_NSV.FileName;
            buttonFileOpen_NSV.Enabled = true;
        }
    }
}
