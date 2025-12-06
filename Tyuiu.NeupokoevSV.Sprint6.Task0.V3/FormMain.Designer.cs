namespace Tyuiu.NeupokoevSV.Sprint6.Task0.V3
{
    partial class FormMain_NSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_NSV));
            textBoxUslovie_NSV = new TextBox();
            pictureBoxFormula_NSV = new PictureBox();
            textBoxZagalovok_NSV = new TextBox();
            textBoxDannie_NSV = new TextBox();
            textBoxPeremennaia_NSV = new TextBox();
            buttonDone_NSV = new Button();
            textBoxVivod = new TextBox();
            textBoxResult_NSV = new TextBox();
            textBoxX_NSV = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_NSV).BeginInit();
            SuspendLayout();
            // 
            // textBoxUslovie_NSV
            // 
            textBoxUslovie_NSV.BackColor = SystemColors.Menu;
            textBoxUslovie_NSV.BorderStyle = BorderStyle.None;
            textBoxUslovie_NSV.Font = new Font("Segoe UI", 15F);
            textBoxUslovie_NSV.Location = new Point(32, 47);
            textBoxUslovie_NSV.Multiline = true;
            textBoxUslovie_NSV.Name = "textBoxUslovie_NSV";
            textBoxUslovie_NSV.Size = new Size(756, 131);
            textBoxUslovie_NSV.TabIndex = 2;
            textBoxUslovie_NSV.Text = "Вычислите при своем х";
            textBoxUslovie_NSV.TextChanged += textBox1_TextChanged_1;
            // 
            // pictureBoxFormula_NSV
            // 
            pictureBoxFormula_NSV.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxFormula_NSV.Image = (Image)resources.GetObject("pictureBoxFormula_NSV.Image");
            pictureBoxFormula_NSV.Location = new Point(500, 59);
            pictureBoxFormula_NSV.Name = "pictureBoxFormula_NSV";
            pictureBoxFormula_NSV.Size = new Size(154, 70);
            pictureBoxFormula_NSV.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFormula_NSV.TabIndex = 3;
            pictureBoxFormula_NSV.TabStop = false;
            // 
            // textBoxZagalovok_NSV
            // 
            textBoxZagalovok_NSV.BackColor = SystemColors.Menu;
            textBoxZagalovok_NSV.BorderStyle = BorderStyle.None;
            textBoxZagalovok_NSV.Font = new Font("Segoe UI", 15F);
            textBoxZagalovok_NSV.Location = new Point(39, 12);
            textBoxZagalovok_NSV.Name = "textBoxZagalovok_NSV";
            textBoxZagalovok_NSV.Size = new Size(94, 27);
            textBoxZagalovok_NSV.TabIndex = 4;
            textBoxZagalovok_NSV.Text = "Условие";
            // 
            // textBoxDannie_NSV
            // 
            textBoxDannie_NSV.BackColor = SystemColors.Menu;
            textBoxDannie_NSV.BorderStyle = BorderStyle.None;
            textBoxDannie_NSV.Font = new Font("Segoe UI", 12F);
            textBoxDannie_NSV.Location = new Point(39, 206);
            textBoxDannie_NSV.Multiline = true;
            textBoxDannie_NSV.Name = "textBoxDannie_NSV";
            textBoxDannie_NSV.Size = new Size(100, 23);
            textBoxDannie_NSV.TabIndex = 5;
            textBoxDannie_NSV.Text = "Ввод данных:";
            // 
            // textBoxPeremennaia_NSV
            // 
            textBoxPeremennaia_NSV.BackColor = SystemColors.Menu;
            textBoxPeremennaia_NSV.BorderStyle = BorderStyle.None;
            textBoxPeremennaia_NSV.Font = new Font("Segoe UI", 12F);
            textBoxPeremennaia_NSV.Location = new Point(44, 235);
            textBoxPeremennaia_NSV.Name = "textBoxPeremennaia_NSV";
            textBoxPeremennaia_NSV.Size = new Size(100, 22);
            textBoxPeremennaia_NSV.TabIndex = 6;
            textBoxPeremennaia_NSV.Text = "Переменная х";
            textBoxPeremennaia_NSV.TextChanged += textBox4_TextChanged;
            // 
            // buttonDone_NSV
            // 
            buttonDone_NSV.Font = new Font("Segoe UI", 15F);
            buttonDone_NSV.Location = new Point(500, 301);
            buttonDone_NSV.Name = "buttonDone_NSV";
            buttonDone_NSV.Size = new Size(133, 39);
            buttonDone_NSV.TabIndex = 7;
            buttonDone_NSV.Text = "Выполнить";
            buttonDone_NSV.UseVisualStyleBackColor = true;
            buttonDone_NSV.Click += buttonDone_NSV_Click;
            // 
            // textBoxVivod
            // 
            textBoxVivod.BackColor = SystemColors.Menu;
            textBoxVivod.BorderStyle = BorderStyle.None;
            textBoxVivod.Font = new Font("Segoe UI", 12F);
            textBoxVivod.Location = new Point(500, 207);
            textBoxVivod.Name = "textBoxVivod";
            textBoxVivod.Size = new Size(119, 22);
            textBoxVivod.TabIndex = 8;
            textBoxVivod.Text = "Вывод данных";
            textBoxVivod.TextChanged += textBoxVivod_TextChanged;
            // 
            // textBoxResult_NSV
            // 
            textBoxResult_NSV.BorderStyle = BorderStyle.FixedSingle;
            textBoxResult_NSV.Location = new Point(500, 257);
            textBoxResult_NSV.Name = "textBoxResult_NSV";
            textBoxResult_NSV.ReadOnly = true;
            textBoxResult_NSV.Size = new Size(133, 23);
            textBoxResult_NSV.TabIndex = 9;
            textBoxResult_NSV.TextChanged += textBoxResult_NSV_TextChanged;
            // 
            // textBoxX_NSV
            // 
            textBoxX_NSV.BorderStyle = BorderStyle.FixedSingle;
            textBoxX_NSV.Location = new Point(44, 281);
            textBoxX_NSV.Name = "textBoxX_NSV";
            textBoxX_NSV.Size = new Size(105, 23);
            textBoxX_NSV.TabIndex = 10;
            textBoxX_NSV.TextChanged += textBoxResult_NSV_TextChanged;
            textBoxX_NSV.KeyPress += textBoxXX_NSV;
            // 
            // FormMain_NSV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 346);
            Controls.Add(textBoxX_NSV);
            Controls.Add(textBoxResult_NSV);
            Controls.Add(textBoxVivod);
            Controls.Add(buttonDone_NSV);
            Controls.Add(textBoxPeremennaia_NSV);
            Controls.Add(textBoxDannie_NSV);
            Controls.Add(textBoxZagalovok_NSV);
            Controls.Add(pictureBoxFormula_NSV);
            Controls.Add(textBoxUslovie_NSV);
            Name = "FormMain_NSV";
            Text = "Спринт 6 | Таск 0 | Вариант 3 | Неупокоев С.В.";
            TransparencyKey = Color.Black;
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_NSV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxUslovie_NSV;
        private PictureBox pictureBoxFormula_NSV;
        private TextBox textBoxZagalovok_NSV;
        private TextBox textBoxDannie_NSV;
        private TextBox textBoxPeremennaia_NSV;
        private Button buttonDone_NSV;
        private TextBox textBoxVivod;
        private TextBox textBoxResult_NSV;
        private TextBox textBoxX_NSV;
    }
}
