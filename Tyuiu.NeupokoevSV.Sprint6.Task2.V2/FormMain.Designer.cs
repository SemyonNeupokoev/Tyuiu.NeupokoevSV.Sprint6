namespace Tyuiu.NeupokoevSV.Sprint6.Task2.V2
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
            buttonDone_NSV = new Button();
            buttonSpravka_NSV = new Button();
            groupBoxUsl_NSV = new GroupBox();
            groupBox1 = new GroupBox();
            textBoxUsl_NSV = new TextBox();
            groupBoxVvod_NSV = new GroupBox();
            textBoxStop_NSV = new TextBox();
            textBoxStarr_NSV = new TextBox();
            textBoxStaSto_NSV = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxVivod_NSV = new GroupBox();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction = new DataGridView();
            ColumnX_NSV = new DataGridViewTextBoxColumn();
            ColumnFX_NSV = new DataGridViewTextBoxColumn();
            textBoxResult_NSV = new TextBox();
            groupBoxUsl_NSV.SuspendLayout();
            groupBoxVvod_NSV.SuspendLayout();
            groupBoxVivod_NSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_NSV
            // 
            buttonDone_NSV.BackColor = Color.Green;
            buttonDone_NSV.Font = new Font("Segoe UI", 12F);
            buttonDone_NSV.Location = new Point(420, 240);
            buttonDone_NSV.Name = "buttonDone_NSV";
            buttonDone_NSV.Size = new Size(110, 80);
            buttonDone_NSV.TabIndex = 0;
            buttonDone_NSV.Text = "Выполинть";
            buttonDone_NSV.UseVisualStyleBackColor = false;
            buttonDone_NSV.Click += buttonDone_NSV_Click;
            buttonDone_NSV.MouseEnter += ButtonDone_MouseEnter_NSV;
            // 
            // buttonSpravka_NSV
            // 
            buttonSpravka_NSV.BackColor = Color.DodgerBlue;
            buttonSpravka_NSV.Font = new Font("Segoe UI", 12F);
            buttonSpravka_NSV.Location = new Point(323, 240);
            buttonSpravka_NSV.Name = "buttonSpravka_NSV";
            buttonSpravka_NSV.Size = new Size(91, 80);
            buttonSpravka_NSV.TabIndex = 1;
            buttonSpravka_NSV.Text = "Справка";
            buttonSpravka_NSV.UseVisualStyleBackColor = false;
            buttonSpravka_NSV.Click += buttonSpravka_NSV_Click;
            // 
            // groupBoxUsl_NSV
            // 
            groupBoxUsl_NSV.Controls.Add(groupBox1);
            groupBoxUsl_NSV.Controls.Add(textBoxUsl_NSV);
            groupBoxUsl_NSV.Font = new Font("Segoe UI", 12F);
            groupBoxUsl_NSV.Location = new Point(12, 12);
            groupBoxUsl_NSV.Name = "groupBoxUsl_NSV";
            groupBoxUsl_NSV.Size = new Size(518, 212);
            groupBoxUsl_NSV.TabIndex = 2;
            groupBoxUsl_NSV.TabStop = false;
            groupBoxUsl_NSV.Text = "Условие";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(90, 245);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(123, 72);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textBoxUsl_NSV
            // 
            textBoxUsl_NSV.BackColor = SystemColors.Menu;
            textBoxUsl_NSV.BorderStyle = BorderStyle.None;
            textBoxUsl_NSV.Location = new Point(6, 18);
            textBoxUsl_NSV.Multiline = true;
            textBoxUsl_NSV.Name = "textBoxUsl_NSV";
            textBoxUsl_NSV.ReadOnly = true;
            textBoxUsl_NSV.Size = new Size(484, 118);
            textBoxUsl_NSV.TabIndex = 0;
            textBoxUsl_NSV.Text = "Протабулировать функцию на заданном диапазоне\r\nРезультат вывести в DataGridView и построить график функции";
            // 
            // groupBoxVvod_NSV
            // 
            groupBoxVvod_NSV.Controls.Add(textBoxStop_NSV);
            groupBoxVvod_NSV.Controls.Add(textBoxStarr_NSV);
            groupBoxVvod_NSV.Controls.Add(textBoxStaSto_NSV);
            groupBoxVvod_NSV.Font = new Font("Segoe UI", 12F);
            groupBoxVvod_NSV.Location = new Point(12, 230);
            groupBoxVvod_NSV.Name = "groupBoxVvod_NSV";
            groupBoxVvod_NSV.Size = new Size(305, 90);
            groupBoxVvod_NSV.TabIndex = 2;
            groupBoxVvod_NSV.TabStop = false;
            groupBoxVvod_NSV.Text = "Ввод данных";
            // 
            // textBoxStop_NSV
            // 
            textBoxStop_NSV.BorderStyle = BorderStyle.FixedSingle;
            textBoxStop_NSV.Location = new Point(153, 53);
            textBoxStop_NSV.Name = "textBoxStop_NSV";
            textBoxStop_NSV.Size = new Size(145, 29);
            textBoxStop_NSV.TabIndex = 2;
            // 
            // textBoxStarr_NSV
            // 
            textBoxStarr_NSV.BorderStyle = BorderStyle.FixedSingle;
            textBoxStarr_NSV.Location = new Point(6, 53);
            textBoxStarr_NSV.Name = "textBoxStarr_NSV";
            textBoxStarr_NSV.Size = new Size(141, 29);
            textBoxStarr_NSV.TabIndex = 2;
            // 
            // textBoxStaSto_NSV
            // 
            textBoxStaSto_NSV.BackColor = SystemColors.Menu;
            textBoxStaSto_NSV.BorderStyle = BorderStyle.None;
            textBoxStaSto_NSV.Location = new Point(6, 21);
            textBoxStaSto_NSV.Multiline = true;
            textBoxStaSto_NSV.Name = "textBoxStaSto_NSV";
            textBoxStaSto_NSV.ReadOnly = true;
            textBoxStaSto_NSV.Size = new Size(299, 26);
            textBoxStaSto_NSV.TabIndex = 2;
            textBoxStaSto_NSV.Text = "Старт шага:                Конец шага:";
            // 
            // groupBoxVivod_NSV
            // 
            groupBoxVivod_NSV.Controls.Add(chart);
            groupBoxVivod_NSV.Controls.Add(dataGridViewFunction);
            groupBoxVivod_NSV.Controls.Add(textBoxResult_NSV);
            groupBoxVivod_NSV.Font = new Font("Segoe UI", 12F);
            groupBoxVivod_NSV.Location = new Point(536, 15);
            groupBoxVivod_NSV.Name = "groupBoxVivod_NSV";
            groupBoxVivod_NSV.Size = new Size(432, 305);
            groupBoxVivod_NSV.TabIndex = 3;
            groupBoxVivod_NSV.TabStop = false;
            groupBoxVivod_NSV.Text = "Вывод данных";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart.Legends.Add(legend1);
            chart.Location = new Point(149, 45);
            chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart.Series.Add(series1);
            chart.Size = new Size(415, 252);
            chart.TabIndex = 2;
            chart.Text = "chart1";
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { ColumnX_NSV, ColumnFX_NSV });
            dataGridViewFunction.Location = new Point(6, 45);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.Size = new Size(137, 252);
            dataGridViewFunction.TabIndex = 1;
            dataGridViewFunction.CellContentClick += dataGridViewFunction_CellContentClick;
            // 
            // ColumnX_NSV
            // 
            ColumnX_NSV.HeaderText = "X";
            ColumnX_NSV.Name = "ColumnX_NSV";
            ColumnX_NSV.Width = 70;
            // 
            // ColumnFX_NSV
            // 
            ColumnFX_NSV.HeaderText = "F(X)";
            ColumnFX_NSV.Name = "ColumnFX_NSV";
            ColumnFX_NSV.Width = 70;
            // 
            // textBoxResult_NSV
            // 
            textBoxResult_NSV.BackColor = SystemColors.Menu;
            textBoxResult_NSV.BorderStyle = BorderStyle.None;
            textBoxResult_NSV.Location = new Point(6, 20);
            textBoxResult_NSV.Multiline = true;
            textBoxResult_NSV.Name = "textBoxResult_NSV";
            textBoxResult_NSV.ReadOnly = true;
            textBoxResult_NSV.Size = new Size(100, 23);
            textBoxResult_NSV.TabIndex = 0;
            textBoxResult_NSV.Text = "Результат";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 332);
            Controls.Add(groupBoxVivod_NSV);
            Controls.Add(groupBoxVvod_NSV);
            Controls.Add(groupBoxUsl_NSV);
            Controls.Add(buttonSpravka_NSV);
            Controls.Add(buttonDone_NSV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 2 | Неупокоев С. В.";
            groupBoxUsl_NSV.ResumeLayout(false);
            groupBoxUsl_NSV.PerformLayout();
            groupBoxVvod_NSV.ResumeLayout(false);
            groupBoxVvod_NSV.PerformLayout();
            groupBoxVivod_NSV.ResumeLayout(false);
            groupBoxVivod_NSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_NSV;
        private Button buttonSpravka_NSV;
        private GroupBox groupBoxUsl_NSV;
        private GroupBox groupBoxVvod_NSV;
        private GroupBox groupBox1;
        private TextBox textBoxUsl_NSV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBoxVivod_NSV;
        private TextBox textBoxResult_NSV;
        private TextBox textBoxStaSto_NSV;
        private TextBox textBoxStarr_NSV;
        private TextBox textBoxStop_NSV;
        private DataGridView dataGridViewFunction;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private DataGridViewTextBoxColumn ColumnX_NSV;
        private DataGridViewTextBoxColumn ColumnFX_NSV;
    }
}
