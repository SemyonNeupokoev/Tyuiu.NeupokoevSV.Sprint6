namespace Tyuiu.NeupokoevSV.Sprint6.Task3.V7
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
            groupBoxUsl_NSV = new GroupBox();
            dataGridViewMatrix_NSV = new DataGridView();
            textBoxUsl_NSV = new TextBox();
            groupBoxVivod_NSV = new GroupBox();
            textBoxVivodRes_NSV = new TextBox();
            textBoxRes_NSV = new TextBox();
            buttonDone_NSV = new Button();
            buttonAsk_NSV = new Button();
            groupBoxUsl_NSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_NSV).BeginInit();
            groupBoxVivod_NSV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUsl_NSV
            // 
            groupBoxUsl_NSV.Controls.Add(dataGridViewMatrix_NSV);
            groupBoxUsl_NSV.Controls.Add(textBoxUsl_NSV);
            groupBoxUsl_NSV.Location = new Point(12, 12);
            groupBoxUsl_NSV.Name = "groupBoxUsl_NSV";
            groupBoxUsl_NSV.Size = new Size(579, 285);
            groupBoxUsl_NSV.TabIndex = 0;
            groupBoxUsl_NSV.TabStop = false;
            groupBoxUsl_NSV.Text = "Условие";
            // 
            // dataGridViewMatrix_NSV
            // 
            dataGridViewMatrix_NSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_NSV.Location = new Point(312, 20);
            dataGridViewMatrix_NSV.Name = "dataGridViewMatrix_NSV";
            dataGridViewMatrix_NSV.ReadOnly = true;
            dataGridViewMatrix_NSV.RowHeadersVisible = false;
            dataGridViewMatrix_NSV.Size = new Size(261, 259);
            dataGridViewMatrix_NSV.TabIndex = 1;
            // 
            // textBoxUsl_NSV
            // 
            textBoxUsl_NSV.BackColor = SystemColors.Menu;
            textBoxUsl_NSV.BorderStyle = BorderStyle.None;
            textBoxUsl_NSV.Location = new Point(6, 20);
            textBoxUsl_NSV.Multiline = true;
            textBoxUsl_NSV.Name = "textBoxUsl_NSV";
            textBoxUsl_NSV.ReadOnly = true;
            textBoxUsl_NSV.Size = new Size(300, 205);
            textBoxUsl_NSV.TabIndex = 0;
            textBoxUsl_NSV.Text = "Дана матрица 5 на 5 \r\n31  25 -18  12   9\r\n   6  34  -2   2 -18\r\n  -5   4  27   4  -1\r\n   4  15  34  -6 -10\r\n   0   8   5  14 -17\r\nВыполнить сортировку по возрастанию в четвертом столбце.\r\n";
            // 
            // groupBoxVivod_NSV
            // 
            groupBoxVivod_NSV.Controls.Add(textBoxVivodRes_NSV);
            groupBoxVivod_NSV.Controls.Add(textBoxRes_NSV);
            groupBoxVivod_NSV.Location = new Point(597, 12);
            groupBoxVivod_NSV.Name = "groupBoxVivod_NSV";
            groupBoxVivod_NSV.Size = new Size(194, 87);
            groupBoxVivod_NSV.TabIndex = 1;
            groupBoxVivod_NSV.TabStop = false;
            groupBoxVivod_NSV.Text = "Вывод данных";
            // 
            // textBoxVivodRes_NSV
            // 
            textBoxVivodRes_NSV.BackColor = SystemColors.Window;
            textBoxVivodRes_NSV.BorderStyle = BorderStyle.FixedSingle;
            textBoxVivodRes_NSV.Location = new Point(10, 48);
            textBoxVivodRes_NSV.Name = "textBoxVivodRes_NSV";
            textBoxVivodRes_NSV.ReadOnly = true;
            textBoxVivodRes_NSV.Size = new Size(177, 29);
            textBoxVivodRes_NSV.TabIndex = 2;
            // 
            // textBoxRes_NSV
            // 
            textBoxRes_NSV.BackColor = SystemColors.Menu;
            textBoxRes_NSV.BorderStyle = BorderStyle.None;
            textBoxRes_NSV.Location = new Point(10, 20);
            textBoxRes_NSV.Name = "textBoxRes_NSV";
            textBoxRes_NSV.ReadOnly = true;
            textBoxRes_NSV.Size = new Size(100, 22);
            textBoxRes_NSV.TabIndex = 0;
            textBoxRes_NSV.Text = "Результат";
            // 
            // buttonDone_NSV
            // 
            buttonDone_NSV.BackColor = Color.Green;
            buttonDone_NSV.Location = new Point(691, 237);
            buttonDone_NSV.Name = "buttonDone_NSV";
            buttonDone_NSV.Size = new Size(101, 54);
            buttonDone_NSV.TabIndex = 2;
            buttonDone_NSV.Text = "Выполнить";
            buttonDone_NSV.UseVisualStyleBackColor = false;
            buttonDone_NSV.Click += buttonDone_NSV_Click;
            // 
            // buttonAsk_NSV
            // 
            buttonAsk_NSV.BackColor = SystemColors.ActiveBorder;
            buttonAsk_NSV.FlatStyle = FlatStyle.Flat;
            buttonAsk_NSV.Location = new Point(624, 239);
            buttonAsk_NSV.Name = "buttonAsk_NSV";
            buttonAsk_NSV.Size = new Size(51, 49);
            buttonAsk_NSV.TabIndex = 3;
            buttonAsk_NSV.Text = "?";
            buttonAsk_NSV.UseVisualStyleBackColor = false;
            buttonAsk_NSV.Click += buttonAsk_NSV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 309);
            Controls.Add(buttonAsk_NSV);
            Controls.Add(buttonDone_NSV);
            Controls.Add(groupBoxVivod_NSV);
            Controls.Add(groupBoxUsl_NSV);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 |  Вариант 7 | Неупокоев С. В.";
            Load += FormMain_Load;
            groupBoxUsl_NSV.ResumeLayout(false);
            groupBoxUsl_NSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_NSV).EndInit();
            groupBoxVivod_NSV.ResumeLayout(false);
            groupBoxVivod_NSV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUsl_NSV;
        private GroupBox groupBoxVivod_NSV;
        private TextBox textBoxRes_NSV;
        private TextBox textBoxUsl_NSV;
        private TextBox textBoxVivodRes_NSV;
        private DataGridView dataGridViewMatrix_NSV;
        private Button buttonDone_NSV;
        private Button buttonAsk_NSV;
    }
}
