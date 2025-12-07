namespace Tyuiu.NeupokoevSV.Sprint6.Task5.V8
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelVerh_NSV = new Panel();
            buttonSpravka_NSV = new Button();
            buttonOtkrFile_NSV = new Button();
            buttonDone_NSV = new Button();
            groupBoxUsl_NSV = new GroupBox();
            textBoxUsl_NSV = new TextBox();
            panelLeft_NSV = new Panel();
            groupBoxVivod_NSV = new GroupBox();
            dataGridViewVivod_NSV = new DataGridView();
            groupBox3 = new GroupBox();
            panelFill_NSV = new Panel();
            chartFunction_NSV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelVerh_NSV.SuspendLayout();
            groupBoxUsl_NSV.SuspendLayout();
            panelLeft_NSV.SuspendLayout();
            groupBoxVivod_NSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVivod_NSV).BeginInit();
            panelFill_NSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_NSV).BeginInit();
            SuspendLayout();
            // 
            // panelVerh_NSV
            // 
            panelVerh_NSV.Controls.Add(buttonSpravka_NSV);
            panelVerh_NSV.Controls.Add(buttonOtkrFile_NSV);
            panelVerh_NSV.Controls.Add(buttonDone_NSV);
            panelVerh_NSV.Controls.Add(groupBoxUsl_NSV);
            panelVerh_NSV.Dock = DockStyle.Top;
            panelVerh_NSV.Location = new Point(0, 0);
            panelVerh_NSV.Name = "panelVerh_NSV";
            panelVerh_NSV.Size = new Size(1010, 80);
            panelVerh_NSV.TabIndex = 0;
            // 
            // buttonSpravka_NSV
            // 
            buttonSpravka_NSV.BackColor = Color.RoyalBlue;
            buttonSpravka_NSV.Font = new Font("Segoe UI", 12F);
            buttonSpravka_NSV.Location = new Point(873, 14);
            buttonSpravka_NSV.Name = "buttonSpravka_NSV";
            buttonSpravka_NSV.Size = new Size(123, 54);
            buttonSpravka_NSV.TabIndex = 1;
            buttonSpravka_NSV.Text = "Справка";
            buttonSpravka_NSV.UseVisualStyleBackColor = false;
            buttonSpravka_NSV.Click += buttonSpravka_NSV_Click;
            // 
            // buttonOtkrFile_NSV
            // 
            buttonOtkrFile_NSV.BackColor = Color.FromArgb(128, 128, 255);
            buttonOtkrFile_NSV.Font = new Font("Segoe UI", 12F);
            buttonOtkrFile_NSV.Location = new Point(670, 14);
            buttonOtkrFile_NSV.Name = "buttonOtkrFile_NSV";
            buttonOtkrFile_NSV.Size = new Size(184, 54);
            buttonOtkrFile_NSV.TabIndex = 1;
            buttonOtkrFile_NSV.Text = "Открыть файл";
            buttonOtkrFile_NSV.UseVisualStyleBackColor = false;
            buttonOtkrFile_NSV.Click += buttonOtkrFile_NSV_Click;
            // 
            // buttonDone_NSV
            // 
            buttonDone_NSV.BackColor = Color.Green;
            buttonDone_NSV.Font = new Font("Segoe UI", 12F);
            buttonDone_NSV.Location = new Point(498, 14);
            buttonDone_NSV.Name = "buttonDone_NSV";
            buttonDone_NSV.Size = new Size(154, 56);
            buttonDone_NSV.TabIndex = 1;
            buttonDone_NSV.Text = "Выполнить";
            buttonDone_NSV.UseVisualStyleBackColor = false;
            buttonDone_NSV.Click += buttonDone_NSV_Click;
            // 
            // groupBoxUsl_NSV
            // 
            groupBoxUsl_NSV.Controls.Add(textBoxUsl_NSV);
            groupBoxUsl_NSV.Font = new Font("Segoe UI", 12F);
            groupBoxUsl_NSV.Location = new Point(3, 3);
            groupBoxUsl_NSV.Name = "groupBoxUsl_NSV";
            groupBoxUsl_NSV.Size = new Size(489, 71);
            groupBoxUsl_NSV.TabIndex = 0;
            groupBoxUsl_NSV.TabStop = false;
            groupBoxUsl_NSV.Text = "Условие";
            // 
            // textBoxUsl_NSV
            // 
            textBoxUsl_NSV.BackColor = SystemColors.Menu;
            textBoxUsl_NSV.BorderStyle = BorderStyle.None;
            textBoxUsl_NSV.Location = new Point(6, 21);
            textBoxUsl_NSV.Multiline = true;
            textBoxUsl_NSV.Name = "textBoxUsl_NSV";
            textBoxUsl_NSV.ReadOnly = true;
            textBoxUsl_NSV.Size = new Size(466, 44);
            textBoxUsl_NSV.TabIndex = 0;
            textBoxUsl_NSV.Text = "Прочитать данные из файла. Вывести в dataGridView значения больше 0 и построить диаграмму.\r\n";
            // 
            // panelLeft_NSV
            // 
            panelLeft_NSV.Controls.Add(groupBoxVivod_NSV);
            panelLeft_NSV.Controls.Add(groupBox3);
            panelLeft_NSV.Dock = DockStyle.Left;
            panelLeft_NSV.Location = new Point(0, 80);
            panelLeft_NSV.Name = "panelLeft_NSV";
            panelLeft_NSV.Size = new Size(246, 423);
            panelLeft_NSV.TabIndex = 0;
            // 
            // groupBoxVivod_NSV
            // 
            groupBoxVivod_NSV.Controls.Add(dataGridViewVivod_NSV);
            groupBoxVivod_NSV.Dock = DockStyle.Fill;
            groupBoxVivod_NSV.Font = new Font("Segoe UI", 12F);
            groupBoxVivod_NSV.Location = new Point(0, 0);
            groupBoxVivod_NSV.Name = "groupBoxVivod_NSV";
            groupBoxVivod_NSV.Size = new Size(246, 423);
            groupBoxVivod_NSV.TabIndex = 0;
            groupBoxVivod_NSV.TabStop = false;
            groupBoxVivod_NSV.Text = "Вывод данных";
            // 
            // dataGridViewVivod_NSV
            // 
            dataGridViewVivod_NSV.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewVivod_NSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVivod_NSV.Dock = DockStyle.Fill;
            dataGridViewVivod_NSV.Location = new Point(3, 25);
            dataGridViewVivod_NSV.Name = "dataGridViewVivod_NSV";
            dataGridViewVivod_NSV.ScrollBars = ScrollBars.Vertical;
            dataGridViewVivod_NSV.Size = new Size(240, 395);
            dataGridViewVivod_NSV.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(324, 24);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 100);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox1";
            // 
            // panelFill_NSV
            // 
            panelFill_NSV.Controls.Add(chartFunction_NSV);
            panelFill_NSV.Dock = DockStyle.Fill;
            panelFill_NSV.Location = new Point(246, 80);
            panelFill_NSV.Name = "panelFill_NSV";
            panelFill_NSV.Size = new Size(764, 423);
            panelFill_NSV.TabIndex = 1;
            // 
            // chartFunction_NSV
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_NSV.ChartAreas.Add(chartArea1);
            chartFunction_NSV.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_NSV.Legends.Add(legend1);
            chartFunction_NSV.Location = new Point(0, 0);
            chartFunction_NSV.MaximumSize = new Size(1000, 700);
            chartFunction_NSV.MinimumSize = new Size(578, 390);
            chartFunction_NSV.Name = "chartFunction_NSV";
            chartFunction_NSV.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_NSV.Series.Add(series1);
            chartFunction_NSV.Size = new Size(764, 423);
            chartFunction_NSV.TabIndex = 0;
            chartFunction_NSV.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 503);
            Controls.Add(panelFill_NSV);
            Controls.Add(panelLeft_NSV);
            Controls.Add(panelVerh_NSV);
            MinimumSize = new Size(810, 490);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 8 | Неупокоев С. В.";
            panelVerh_NSV.ResumeLayout(false);
            groupBoxUsl_NSV.ResumeLayout(false);
            groupBoxUsl_NSV.PerformLayout();
            panelLeft_NSV.ResumeLayout(false);
            groupBoxVivod_NSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVivod_NSV).EndInit();
            panelFill_NSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_NSV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelVerh_NSV;
        private Panel panelLeft_NSV;
        private Panel panelFill_NSV;
        private GroupBox groupBoxUsl_NSV;
        private GroupBox groupBoxVivod_NSV;
        private GroupBox groupBox3;
        private TextBox textBoxUsl_NSV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_NSV;
        private Button buttonSpravka_NSV;
        private Button buttonOtkrFile_NSV;
        private Button buttonDone_NSV;
        private DataGridView dataGridViewVivod_NSV;
    }
}
