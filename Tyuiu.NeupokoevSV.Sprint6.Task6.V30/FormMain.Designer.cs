namespace Tyuiu.NeupokoevSV.Sprint6.Task6.V30
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
            panelKnopki_NSV = new Panel();
            buttonSearchInFile_NSV = new Button();
            buttonVopros_NSV = new Button();
            buttonFileOpen_NSV = new Button();
            panelUsl_NSV = new Panel();
            groupBoxUsl_NSV = new GroupBox();
            textBoxUsl_NSV = new TextBox();
            splitContainer_NSV = new SplitContainer();
            groupBoxVvod_NSV = new GroupBox();
            textBoxVvod_NSV = new TextBox();
            groupBoxVivod_NSV = new GroupBox();
            textBoxVivod_NSV = new TextBox();
            openFileDialog_NSV = new OpenFileDialog();
            toolTip_NSV = new ToolTip(components);
            panelKnopki_NSV.SuspendLayout();
            panelUsl_NSV.SuspendLayout();
            groupBoxUsl_NSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_NSV).BeginInit();
            splitContainer_NSV.Panel1.SuspendLayout();
            splitContainer_NSV.Panel2.SuspendLayout();
            splitContainer_NSV.SuspendLayout();
            groupBoxVvod_NSV.SuspendLayout();
            groupBoxVivod_NSV.SuspendLayout();
            SuspendLayout();
            // 
            // panelKnopki_NSV
            // 
            panelKnopki_NSV.Controls.Add(buttonSearchInFile_NSV);
            panelKnopki_NSV.Controls.Add(buttonVopros_NSV);
            panelKnopki_NSV.Controls.Add(buttonFileOpen_NSV);
            panelKnopki_NSV.Dock = DockStyle.Top;
            panelKnopki_NSV.Location = new Point(0, 0);
            panelKnopki_NSV.Name = "panelKnopki_NSV";
            panelKnopki_NSV.Size = new Size(965, 76);
            panelKnopki_NSV.TabIndex = 0;
            // 
            // buttonSearchInFile_NSV
            // 
            buttonSearchInFile_NSV.Image = Properties.Resources.folder_go;
            buttonSearchInFile_NSV.Location = new Point(140, 10);
            buttonSearchInFile_NSV.Name = "buttonSearchInFile_NSV";
            buttonSearchInFile_NSV.Size = new Size(85, 56);
            buttonSearchInFile_NSV.TabIndex = 1;
            toolTip_NSV.SetToolTip(buttonSearchInFile_NSV, "Происходит поиск в файле в каждой строке 4 слова\r\n");
            buttonSearchInFile_NSV.UseVisualStyleBackColor = true;
            buttonSearchInFile_NSV.Click += buttonSearchInFile_NSV_Click;
            // 
            // buttonVopros_NSV
            // 
            buttonVopros_NSV.Image = Properties.Resources.help;
            buttonVopros_NSV.Location = new Point(873, 10);
            buttonVopros_NSV.Name = "buttonVopros_NSV";
            buttonVopros_NSV.Size = new Size(74, 58);
            buttonVopros_NSV.TabIndex = 0;
            buttonVopros_NSV.UseVisualStyleBackColor = true;
            // 
            // buttonFileOpen_NSV
            // 
            buttonFileOpen_NSV.Image = Properties.Resources.folder_add;
            buttonFileOpen_NSV.Location = new Point(9, 10);
            buttonFileOpen_NSV.Name = "buttonFileOpen_NSV";
            buttonFileOpen_NSV.Size = new Size(88, 56);
            buttonFileOpen_NSV.TabIndex = 0;
            toolTip_NSV.SetToolTip(buttonFileOpen_NSV, "Открыть файл\r\nВыберите файл для обработки\r\n");
            buttonFileOpen_NSV.UseVisualStyleBackColor = true;
            buttonFileOpen_NSV.Click += buttonFileOpen_NSV_Click;
            // 
            // panelUsl_NSV
            // 
            panelUsl_NSV.Controls.Add(groupBoxUsl_NSV);
            panelUsl_NSV.Dock = DockStyle.Top;
            panelUsl_NSV.Location = new Point(0, 76);
            panelUsl_NSV.Name = "panelUsl_NSV";
            panelUsl_NSV.Size = new Size(965, 108);
            panelUsl_NSV.TabIndex = 1;
            // 
            // groupBoxUsl_NSV
            // 
            groupBoxUsl_NSV.Controls.Add(textBoxUsl_NSV);
            groupBoxUsl_NSV.Font = new Font("Segoe UI", 12F);
            groupBoxUsl_NSV.Location = new Point(12, 1);
            groupBoxUsl_NSV.Name = "groupBoxUsl_NSV";
            groupBoxUsl_NSV.Size = new Size(941, 100);
            groupBoxUsl_NSV.TabIndex = 0;
            groupBoxUsl_NSV.TabStop = false;
            groupBoxUsl_NSV.Text = "Условие";
            // 
            // textBoxUsl_NSV
            // 
            textBoxUsl_NSV.BackColor = SystemColors.Menu;
            textBoxUsl_NSV.BorderStyle = BorderStyle.None;
            textBoxUsl_NSV.Location = new Point(6, 19);
            textBoxUsl_NSV.Multiline = true;
            textBoxUsl_NSV.Name = "textBoxUsl_NSV";
            textBoxUsl_NSV.ReadOnly = true;
            textBoxUsl_NSV.Size = new Size(929, 75);
            textBoxUsl_NSV.TabIndex = 0;
            textBoxUsl_NSV.Text = resources.GetString("textBoxUsl_NSV.Text");
            // 
            // splitContainer_NSV
            // 
            splitContainer_NSV.Dock = DockStyle.Fill;
            splitContainer_NSV.Location = new Point(0, 184);
            splitContainer_NSV.Name = "splitContainer_NSV";
            // 
            // splitContainer_NSV.Panel1
            // 
            splitContainer_NSV.Panel1.Controls.Add(groupBoxVvod_NSV);
            splitContainer_NSV.Panel1.Tag = "";
            // 
            // splitContainer_NSV.Panel2
            // 
            splitContainer_NSV.Panel2.Controls.Add(groupBoxVivod_NSV);
            splitContainer_NSV.Size = new Size(965, 371);
            splitContainer_NSV.SplitterDistance = 482;
            splitContainer_NSV.TabIndex = 2;
            // 
            // groupBoxVvod_NSV
            // 
            groupBoxVvod_NSV.Controls.Add(textBoxVvod_NSV);
            groupBoxVvod_NSV.Font = new Font("Segoe UI", 12F);
            groupBoxVvod_NSV.Location = new Point(3, 6);
            groupBoxVvod_NSV.Name = "groupBoxVvod_NSV";
            groupBoxVvod_NSV.Size = new Size(476, 362);
            groupBoxVvod_NSV.TabIndex = 0;
            groupBoxVvod_NSV.TabStop = false;
            groupBoxVvod_NSV.Text = "Ввод";
            groupBoxVvod_NSV.Enter += groupBox1_Enter;
            // 
            // textBoxVvod_NSV
            // 
            textBoxVvod_NSV.BackColor = SystemColors.ButtonHighlight;
            textBoxVvod_NSV.BorderStyle = BorderStyle.None;
            textBoxVvod_NSV.Location = new Point(6, 19);
            textBoxVvod_NSV.Multiline = true;
            textBoxVvod_NSV.Name = "textBoxVvod_NSV";
            textBoxVvod_NSV.ReadOnly = true;
            textBoxVvod_NSV.ScrollBars = ScrollBars.Vertical;
            textBoxVvod_NSV.Size = new Size(464, 337);
            textBoxVvod_NSV.TabIndex = 0;
            // 
            // groupBoxVivod_NSV
            // 
            groupBoxVivod_NSV.Controls.Add(textBoxVivod_NSV);
            groupBoxVivod_NSV.Font = new Font("Segoe UI", 12F);
            groupBoxVivod_NSV.Location = new Point(3, 6);
            groupBoxVivod_NSV.Name = "groupBoxVivod_NSV";
            groupBoxVivod_NSV.Size = new Size(473, 362);
            groupBoxVivod_NSV.TabIndex = 0;
            groupBoxVivod_NSV.TabStop = false;
            groupBoxVivod_NSV.Text = "Вывод";
            // 
            // textBoxVivod_NSV
            // 
            textBoxVivod_NSV.BackColor = SystemColors.ButtonHighlight;
            textBoxVivod_NSV.BorderStyle = BorderStyle.None;
            textBoxVivod_NSV.Location = new Point(6, 19);
            textBoxVivod_NSV.Multiline = true;
            textBoxVivod_NSV.Name = "textBoxVivod_NSV";
            textBoxVivod_NSV.ReadOnly = true;
            textBoxVivod_NSV.ScrollBars = ScrollBars.Vertical;
            textBoxVivod_NSV.Size = new Size(461, 337);
            textBoxVivod_NSV.TabIndex = 0;
            // 
            // openFileDialog_NSV
            // 
            openFileDialog_NSV.FileName = "openFileDialog1";
            // 
            // toolTip_NSV
            // 
            toolTip_NSV.ToolTipIcon = ToolTipIcon.Info;
            toolTip_NSV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 555);
            Controls.Add(splitContainer_NSV);
            Controls.Add(panelUsl_NSV);
            Controls.Add(panelKnopki_NSV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 30 | Неупокоев С.В.";
            panelKnopki_NSV.ResumeLayout(false);
            panelUsl_NSV.ResumeLayout(false);
            groupBoxUsl_NSV.ResumeLayout(false);
            groupBoxUsl_NSV.PerformLayout();
            splitContainer_NSV.Panel1.ResumeLayout(false);
            splitContainer_NSV.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_NSV).EndInit();
            splitContainer_NSV.ResumeLayout(false);
            groupBoxVvod_NSV.ResumeLayout(false);
            groupBoxVvod_NSV.PerformLayout();
            groupBoxVivod_NSV.ResumeLayout(false);
            groupBoxVivod_NSV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelKnopki_NSV;
        private Panel panelUsl_NSV;
        private SplitContainer splitContainer_NSV;
        private GroupBox groupBoxUsl_NSV;
        private GroupBox groupBoxVvod_NSV;
        private GroupBox groupBoxVivod_NSV;
        private TextBox textBoxUsl_NSV;
        private TextBox textBoxVvod_NSV;
        private TextBox textBoxVivod_NSV;
        private Button buttonVopros_NSV;
        private Button buttonFileOpen_NSV;
        private OpenFileDialog openFileDialog_NSV;
        private ToolTip toolTip_NSV;
        private Button buttonSearchInFile_NSV;
    }
}
