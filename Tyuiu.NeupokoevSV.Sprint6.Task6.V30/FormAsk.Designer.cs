namespace Tyuiu.NeupokoevSV.Sprint6.Task6.V30
{
    partial class FormAsk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsk));
            pictureBoxI_NSV = new PictureBox();
            labelOpisanie_NSV = new Label();
            buttonOk_NSV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxI_NSV).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxI_NSV
            // 
            pictureBoxI_NSV.Location = new Point(12, 12);
            pictureBoxI_NSV.Name = "pictureBoxI_NSV";
            pictureBoxI_NSV.Size = new Size(157, 187);
            pictureBoxI_NSV.TabIndex = 0;
            pictureBoxI_NSV.TabStop = false;
            // 
            // labelOpisanie_NSV
            // 
            labelOpisanie_NSV.Font = new Font("Segoe UI", 10F);
            labelOpisanie_NSV.Location = new Point(175, 12);
            labelOpisanie_NSV.MinimumSize = new Size(100, 100);
            labelOpisanie_NSV.Name = "labelOpisanie_NSV";
            labelOpisanie_NSV.Size = new Size(357, 187);
            labelOpisanie_NSV.TabIndex = 1;
            labelOpisanie_NSV.Text = resources.GetString("labelOpisanie_NSV.Text");
            // 
            // buttonOk_NSV
            // 
            buttonOk_NSV.BackColor = SystemColors.ActiveBorder;
            buttonOk_NSV.Font = new Font("Segoe UI", 10F);
            buttonOk_NSV.Location = new Point(450, 229);
            buttonOk_NSV.Name = "buttonOk_NSV";
            buttonOk_NSV.Size = new Size(82, 32);
            buttonOk_NSV.TabIndex = 2;
            buttonOk_NSV.Text = "Ok";
            buttonOk_NSV.UseVisualStyleBackColor = false;
            buttonOk_NSV.Click += buttonOk_NSV_Click;
            // 
            // FormAsk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 273);
            Controls.Add(buttonOk_NSV);
            Controls.Add(labelOpisanie_NSV);
            Controls.Add(pictureBoxI_NSV);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAsk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxI_NSV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxI_NSV;
        private Label labelOpisanie_NSV;
        private Button buttonOk_NSV;
    }
}