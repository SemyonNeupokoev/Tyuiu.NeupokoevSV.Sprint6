namespace Tyuiu.NeupokoevSV.Sprint6.Task7.V17
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            buttonOk_NSV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(269, 28);
            label1.Name = "label1";
            label1.Size = new Size(351, 209);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(42, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 186);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // buttonOk_NSV
            // 
            buttonOk_NSV.Font = new Font("Segoe UI", 12F);
            buttonOk_NSV.Location = new Point(545, 224);
            buttonOk_NSV.Name = "buttonOk_NSV";
            buttonOk_NSV.Size = new Size(75, 34);
            buttonOk_NSV.TabIndex = 2;
            buttonOk_NSV.Text = "Ok";
            buttonOk_NSV.UseVisualStyleBackColor = true;
            buttonOk_NSV.Click += buttonOk_NSV_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 270);
            Controls.Add(buttonOk_NSV);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button buttonOk_NSV;
    }
}