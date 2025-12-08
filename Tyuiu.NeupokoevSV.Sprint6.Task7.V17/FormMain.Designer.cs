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
            buttonSohr_NSV = new Button();
            buttonVipoln_NSV = new Button();
            buttonFileOpen_NSV = new Button();
            panelUsl_NSV = new Panel();
            groupBoxUsl_NSV = new GroupBox();
            textBoxUsl_NSV = new TextBox();
            splitContainer_NSV = new SplitContainer();
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
            ((System.ComponentModel.ISupportInitialize)splitContainer_NSV).BeginInit();
            splitContainer_NSV.Panel1.SuspendLayout();
            splitContainer_NSV.Panel2.SuspendLayout();
            splitContainer_NSV.SuspendLayout();
            groupBoxVvod_NSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            groupBoxVivod_NSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // panelKnopkii_NSV
            // 
            panelKnopkii_NSV.Controls.Add(buttonHelp_NSV);
            panelKnopkii_NSV.Controls.Add(buttonSohr_NSV);
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
            buttonHelp_NSV.Click += buttonHelp_NSV_Click;
            buttonHelp_NSV.MouseEnter += buttonHelp_NSV_MouseEnter;
            // 
            // buttonSohr_NSV
            // 
            buttonSohr_NSV.Enabled = false;
            buttonSohr_NSV.Image = Properties.Resources.folder_page_white;
            buttonSohr_NSV.Location = new Point(179, 3);
            buttonSohr_NSV.Name = "buttonSohr_NSV";
            buttonSohr_NSV.Size = new Size(79, 52);
            buttonSohr_NSV.TabIndex = 0;
            toolTip_NSV.SetToolTip(buttonSohr_NSV, "Сохранить обработанные данные в файл в формате csv\r\n\r\n");
            buttonSohr_NSV.UseVisualStyleBackColor = true;
            buttonSohr_NSV.Click += buttonSohr_NSV_Click;
            buttonSohr_NSV.MouseEnter += buttonSohr_NSV_MouseEnter;
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
            buttonVipoln_NSV.Click += buttonVipoln_NSV_Click;
            buttonVipoln_NSV.MouseEnter += buttonVipoln_NSV_MouseEnter;
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
            buttonFileOpen_NSV.MouseEnter += buttonFileOpen_NSV_MouseEnter;
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
            groupBoxUsl_NSV.Controls.Add(textBoxUsl_NSV);
            groupBoxUsl_NSV.Dock = DockStyle.Fill;
            groupBoxUsl_NSV.Font = new Font("Segoe UI", 12F);
            groupBoxUsl_NSV.Location = new Point(0, 0);
            groupBoxUsl_NSV.Name = "groupBoxUsl_NSV";
            groupBoxUsl_NSV.Size = new Size(983, 82);
            groupBoxUsl_NSV.TabIndex = 0;
            groupBoxUsl_NSV.TabStop = false;
            groupBoxUsl_NSV.Text = "Условие";
            // 
            // textBoxUsl_NSV
            // 
            textBoxUsl_NSV.BackColor = SystemColors.Menu;
            textBoxUsl_NSV.BorderStyle = BorderStyle.None;
            textBoxUsl_NSV.Dock = DockStyle.Fill;
            textBoxUsl_NSV.Font = new Font("Microsoft Sans Serif", 10F);
            textBoxUsl_NSV.Location = new Point(3, 25);
            textBoxUsl_NSV.Multiline = true;
            textBoxUsl_NSV.Name = "textBoxUsl_NSV";
            textBoxUsl_NSV.ReadOnly = true;
            textBoxUsl_NSV.Size = new Size(977, 54);
            textBoxUsl_NSV.TabIndex = 0;
            textBoxUsl_NSV.Text = resources.GetString("textBoxUsl_NSV.Text");
            // 
            // splitContainer_NSV
            // 
            splitContainer_NSV.Dock = DockStyle.Fill;
            splitContainer_NSV.Location = new Point(0, 137);
            splitContainer_NSV.Name = "splitContainer_NSV";
            // 
            // splitContainer_NSV.Panel1
            // 
            splitContainer_NSV.Panel1.Controls.Add(groupBoxVvod_NSV);
            // 
            // splitContainer_NSV.Panel2
            // 
            splitContainer_NSV.Panel2.Controls.Add(groupBoxVivod_NSV);
            splitContainer_NSV.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer_NSV.Size = new Size(983, 413);
            splitContainer_NSV.SplitterDistance = 491;
            splitContainer_NSV.TabIndex = 1;
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
            // toolTip_NSV
            // 
            toolTip_NSV.ForeColor = SystemColors.Highlight;
            toolTip_NSV.IsBalloon = true;
            toolTip_NSV.ToolTipTitle = "Подсказка";
            toolTip_NSV.Popup += toolTip_NSV_Popup;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 550);
            Controls.Add(splitContainer_NSV);
            Controls.Add(panelUsl_NSV);
            Controls.Add(panelKnopkii_NSV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 17 | Неупокоев С.В.";
            WindowState = FormWindowState.Maximized;
            panelKnopkii_NSV.ResumeLayout(false);
            panelUsl_NSV.ResumeLayout(false);
            groupBoxUsl_NSV.ResumeLayout(false);
            groupBoxUsl_NSV.PerformLayout();
            splitContainer_NSV.Panel1.ResumeLayout(false);
            splitContainer_NSV.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_NSV).EndInit();
            splitContainer_NSV.ResumeLayout(false);
            groupBoxVvod_NSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            groupBoxVivod_NSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelKnopkii_NSV;
        private Panel panelUsl_NSV;
        private SplitContainer splitContainer_NSV;
        private GroupBox groupBoxUsl_NSV;
        private GroupBox groupBoxVvod_NSV;
        private GroupBox groupBoxVivod_NSV;
        private TextBox textBoxUsl_NSV;
        private DataGridView dataGridViewIn;
        private DataGridView dataGridViewOut;
        private Button buttonSohr_NSV;
        private Button buttonVipoln_NSV;
        private Button buttonFileOpen_NSV;
        private SaveFileDialog saveFileDialog_NSV;
        private OpenFileDialog openFileDialog_NSV;
        private ToolTip toolTip_NSV;
        private Button buttonHelp_NSV;
    }
}
