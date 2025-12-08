namespace Tyuiu.NeupokoevSV.Sprint6.Task7.V17
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelKnopkii_NSV = new Panel();
            buttonHelp_NSV = new Button();
            button3 = new Button();
            buttonVipoln_NSV = new Button();
            buttonFileOpen_NSV = new Button();
            panelUsl_NSV = new Panel();
            groupBoxUsl_NSV = new GroupBox();
            textBox1 = new TextBox();
            splitContainer1 = new SplitContainer();
            groupBoxVvod_NSV = new GroupBox();
            dataGridViewIn = new DataGridView();
            groupBoxVivod_NSV = new GroupBox();
            dataGridViewOut = new DataGridView();
            saveFileDialog_NSV = new SaveFileDialog();
            openFileDialog_NSV = new OpenFileDialog();
            toolTip_NSV = new ToolTip(components);
            panelKnopkii_NSV.SuspendLayout();
            panelUsl_NSV.SuspendLayout();
            groupBoxUsl_NSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBoxVvod_NSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            groupBoxVivod_NSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // panelKnopkii_NSV
            // 
            panelKnopkii_NSV.Controls.Add(buttonHelp_NSV);
            panelKnopkii_NSV.Controls.Add(button3);
            panelKnopkii_NSV.Controls.Add(buttonVipoln_NSV);
            panelKnopkii_NSV.Controls.Add(buttonFileOpen_NSV);
            panelKnopkii_NSV.Dock = DockStyle.Top;
            panelKnopkii_NSV.Location = new Point(0, 0);
            panelKnopkii_NSV.Name = "panelKnopkii_NSV";
            panelKnopkii_NSV.Size = new Size(983, 55);
            panelKnopkii_NSV.TabIndex = 0;
            // 
            // buttonHelp_NSV
            // 
            buttonHelp_NSV.Dock = DockStyle.Right;
            buttonHelp_NSV.Image = Properties.Resources.help;
            buttonHelp_NSV.Location = new Point(908, 0);
            buttonHelp_NSV.Name = "buttonHelp_NSV";
            buttonHelp_NSV.Size = new Size(75, 55);
            buttonHelp_NSV.TabIndex = 1;
            toolTip_NSV.SetToolTip(buttonHelp_NSV, "Информация о программисте\r\n");
            buttonHelp_NSV.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Image = Properties.Resources.folder_page_white;
            button3.Location = new Point(179, 3);
            button3.Name = "button3";
            button3.Size = new Size(79, 52);
            button3.TabIndex = 0;
            toolTip_NSV.SetToolTip(button3, "Сохранить обработанные данные в файл в формате csv\r\n\r\n");
            button3.UseVisualStyleBackColor = true;
            // 
            // buttonVipoln_NSV
            // 
            buttonVipoln_NSV.Enabled = false;
            buttonVipoln_NSV.Image = Properties.Resources.folder_go;
            buttonVipoln_NSV.Location = new Point(89, 3);
            buttonVipoln_NSV.Name = "buttonVipoln_NSV";
            buttonVipoln_NSV.Size = new Size(84, 52);
            buttonVipoln_NSV.TabIndex = 0;
            toolTip_NSV.SetToolTip(buttonVipoln_NSV, "Выполнить обработку данных\r\n");
            buttonVipoln_NSV.UseVisualStyleBackColor = true;
            // 
            // buttonFileOpen_NSV
            // 
            buttonFileOpen_NSV.Dock = DockStyle.Left;
            buttonFileOpen_NSV.Image = Properties.Resources.folder_add;
            buttonFileOpen_NSV.Location = new Point(0, 0);
            buttonFileOpen_NSV.Name = "buttonFileOpen_NSV";
            buttonFileOpen_NSV.Size = new Size(83, 55);
            buttonFileOpen_NSV.TabIndex = 0;
            toolTip_NSV.SetToolTip(buttonFileOpen_NSV, "Открыть файл\r\nВыберите файл для обработки\r\n\r\n\r\n");
            buttonFileOpen_NSV.UseVisualStyleBackColor = true;
            buttonFileOpen_NSV.Click += buttonFileOpen_NSV_Click;
            // 
            // panelUsl_NSV
            // 
            panelUsl_NSV.Controls.Add(groupBoxUsl_NSV);
            panelUsl_NSV.Dock = DockStyle.Top;
            panelUsl_NSV.Location = new Point(0, 55);
            panelUsl_NSV.Name = "panelUsl_NSV";
            panelUsl_NSV.Size = new Size(983, 82);
            panelUsl_NSV.TabIndex = 0;
            // 
            // groupBoxUsl_NSV
            // 
            groupBoxUsl_NSV.Controls.Add(textBox1);
            groupBoxUsl_NSV.Dock = DockStyle.Fill;
            groupBoxUsl_NSV.Font = new Font("Segoe UI", 12F);
            groupBoxUsl_NSV.Location = new Point(0, 0);
            groupBoxUsl_NSV.Name = "groupBoxUsl_NSV";
            groupBoxUsl_NSV.Size = new Size(983, 82);
            groupBoxUsl_NSV.TabIndex = 0;
            groupBoxUsl_NSV.TabStop = false;
            groupBoxUsl_NSV.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Microsoft Sans Serif", 10F);
            textBox1.Location = new Point(3, 25);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(977, 54);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 137);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBoxVvod_NSV);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBoxVivod_NSV);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(983, 413);
            splitContainer1.SplitterDistance = 491;
            splitContainer1.TabIndex = 1;
            // 
            // groupBoxVvod_NSV
            // 
            groupBoxVvod_NSV.Controls.Add(dataGridViewIn);
            groupBoxVvod_NSV.Dock = DockStyle.Fill;
            groupBoxVvod_NSV.Font = new Font("Segoe UI", 12F);
            groupBoxVvod_NSV.Location = new Point(0, 0);
            groupBoxVvod_NSV.Name = "groupBoxVvod_NSV";
            groupBoxVvod_NSV.Size = new Size(491, 413);
            groupBoxVvod_NSV.TabIndex = 0;
            groupBoxVvod_NSV.TabStop = false;
            groupBoxVvod_NSV.Text = "Ввод";
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Dock = DockStyle.Fill;
            dataGridViewIn.Location = new Point(3, 25);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.Size = new Size(485, 385);
            dataGridViewIn.TabIndex = 0;
            // 
            // groupBoxVivod_NSV
            // 
            groupBoxVivod_NSV.Controls.Add(dataGridViewOut);
            groupBoxVivod_NSV.Dock = DockStyle.Fill;
            groupBoxVivod_NSV.Font = new Font("Segoe UI", 12F);
            groupBoxVivod_NSV.Location = new Point(0, 0);
            groupBoxVivod_NSV.Name = "groupBoxVivod_NSV";
            groupBoxVivod_NSV.Size = new Size(488, 413);
            groupBoxVivod_NSV.TabIndex = 0;
            groupBoxVivod_NSV.TabStop = false;
            groupBoxVivod_NSV.Text = "Вывод";
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Dock = DockStyle.Fill;
            dataGridViewOut.Location = new Point(3, 25);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.Size = new Size(482, 385);
            dataGridViewOut.TabIndex = 0;
            // 
            // openFileDialog_NSV
            // 
            openFileDialog_NSV.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 550);
            Controls.Add(splitContainer1);
            Controls.Add(panelUsl_NSV);
            Controls.Add(panelKnopkii_NSV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 17 | Неупокоев С.В.";
            WindowState = FormWindowState.Maximized;
            panelKnopkii_NSV.ResumeLayout(false);
            panelUsl_NSV.ResumeLayout(false);
            groupBoxUsl_NSV.ResumeLayout(false);
            groupBoxUsl_NSV.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBoxVvod_NSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            groupBoxVivod_NSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelKnopkii_NSV;
        private Panel panelUsl_NSV;
        private SplitContainer splitContainer1;
        private GroupBox groupBoxUsl_NSV;
        private GroupBox groupBoxVvod_NSV;
        private GroupBox groupBoxVivod_NSV;
        private TextBox textBox1;
        private DataGridView dataGridViewIn;
        private DataGridView dataGridViewOut;
        private Button button3;
        private Button buttonVipoln_NSV;
        private Button buttonFileOpen_NSV;
        private SaveFileDialog saveFileDialog_NSV;
        private OpenFileDialog openFileDialog_NSV;
        private ToolTip toolTip_NSV;
        private Button buttonHelp_NSV;
    }
}
