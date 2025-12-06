namespace Tyuiu.NeupokoevSV.Sprint6.Task4.V19
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxUsl_NSV = new GroupBox();
            textBoxUsl_NSV = new TextBox();
            groupBox_VivodRes_NSV = new GroupBox();
            textBoxVivodRes_NSV = new TextBox();
            groupBoxVvodDan_NSV = new GroupBox();
            buttonSpravka_NSV = new Button();
            buttonSohr_NSV = new Button();
            buttoneDone_NSV = new Button();
            textBoxKonec_NSV = new TextBox();
            textBoxStart_NSV = new TextBox();
            textBoxStartKon_NSV = new TextBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxUsl_NSV.SuspendLayout();
            groupBox_VivodRes_NSV.SuspendLayout();
            groupBoxVvodDan_NSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBoxUsl_NSV
            // 
            groupBoxUsl_NSV.Controls.Add(textBoxUsl_NSV);
            groupBoxUsl_NSV.Font = new Font("Segoe UI", 12F);
            groupBoxUsl_NSV.Location = new Point(12, 12);
            groupBoxUsl_NSV.Name = "groupBoxUsl_NSV";
            groupBoxUsl_NSV.Size = new Size(486, 104);
            groupBoxUsl_NSV.TabIndex = 0;
            groupBoxUsl_NSV.TabStop = false;
            groupBoxUsl_NSV.Text = "Условие";
            // 
            // textBoxUsl_NSV
            // 
            textBoxUsl_NSV.BackColor = SystemColors.Menu;
            textBoxUsl_NSV.BorderStyle = BorderStyle.None;
            textBoxUsl_NSV.Location = new Point(3, 28);
            textBoxUsl_NSV.Multiline = true;
            textBoxUsl_NSV.Name = "textBoxUsl_NSV";
            textBoxUsl_NSV.ReadOnly = true;
            textBoxUsl_NSV.Size = new Size(481, 67);
            textBoxUsl_NSV.TabIndex = 1;
            textBoxUsl_NSV.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5. \r\nРезультат вывести в textBox, построить график функции и сохранить в файл по нажатию кнопки\r\n";
            // 
            // groupBox_VivodRes_NSV
            // 
            groupBox_VivodRes_NSV.Controls.Add(textBoxVivodRes_NSV);
            groupBox_VivodRes_NSV.Font = new Font("Segoe UI", 12F);
            groupBox_VivodRes_NSV.Location = new Point(14, 119);
            groupBox_VivodRes_NSV.Name = "groupBox_VivodRes_NSV";
            groupBox_VivodRes_NSV.Size = new Size(262, 319);
            groupBox_VivodRes_NSV.TabIndex = 1;
            groupBox_VivodRes_NSV.TabStop = false;
            groupBox_VivodRes_NSV.Text = "Вывод:";
            // 
            // textBoxVivodRes_NSV
            // 
            textBoxVivodRes_NSV.BackColor = SystemColors.ButtonHighlight;
            textBoxVivodRes_NSV.BorderStyle = BorderStyle.None;
            textBoxVivodRes_NSV.Location = new Point(5, 20);
            textBoxVivodRes_NSV.Multiline = true;
            textBoxVivodRes_NSV.Name = "textBoxVivodRes_NSV";
            textBoxVivodRes_NSV.ReadOnly = true;
            textBoxVivodRes_NSV.ScrollBars = ScrollBars.Vertical;
            textBoxVivodRes_NSV.Size = new Size(240, 293);
            textBoxVivodRes_NSV.TabIndex = 3;
            // 
            // groupBoxVvodDan_NSV
            // 
            groupBoxVvodDan_NSV.Controls.Add(buttonSpravka_NSV);
            groupBoxVvodDan_NSV.Controls.Add(buttonSohr_NSV);
            groupBoxVvodDan_NSV.Controls.Add(buttoneDone_NSV);
            groupBoxVvodDan_NSV.Controls.Add(textBoxKonec_NSV);
            groupBoxVvodDan_NSV.Controls.Add(textBoxStart_NSV);
            groupBoxVvodDan_NSV.Controls.Add(textBoxStartKon_NSV);
            groupBoxVvodDan_NSV.Font = new Font("Segoe UI", 12F);
            groupBoxVvodDan_NSV.Location = new Point(517, 15);
            groupBoxVvodDan_NSV.Name = "groupBoxVvodDan_NSV";
            groupBoxVvodDan_NSV.Size = new Size(502, 101);
            groupBoxVvodDan_NSV.TabIndex = 2;
            groupBoxVvodDan_NSV.TabStop = false;
            groupBoxVvodDan_NSV.Text = "Вывод данных:";
            // 
            // buttonSpravka_NSV
            // 
            buttonSpravka_NSV.BackColor = Color.RoyalBlue;
            buttonSpravka_NSV.Font = new Font("Segoe UI", 11F);
            buttonSpravka_NSV.Location = new Point(423, 28);
            buttonSpravka_NSV.Name = "buttonSpravka_NSV";
            buttonSpravka_NSV.Size = new Size(77, 56);
            buttonSpravka_NSV.TabIndex = 5;
            buttonSpravka_NSV.Text = "Справка";
            buttonSpravka_NSV.UseVisualStyleBackColor = false;
            buttonSpravka_NSV.Click += buttonSpravka_NSV_Click;
            // 
            // buttonSohr_NSV
            // 
            buttonSohr_NSV.BackColor = Color.FromArgb(128, 128, 255);
            buttonSohr_NSV.Font = new Font("Segoe UI", 11F);
            buttonSohr_NSV.Location = new Point(332, 28);
            buttonSohr_NSV.Name = "buttonSohr_NSV";
            buttonSohr_NSV.Size = new Size(91, 56);
            buttonSohr_NSV.TabIndex = 4;
            buttonSohr_NSV.Text = "Сохранить";
            buttonSohr_NSV.UseVisualStyleBackColor = false;
            buttonSohr_NSV.Click += buttonSohr_NSV_Click;
            // 
            // buttoneDone_NSV
            // 
            buttoneDone_NSV.BackColor = Color.Green;
            buttoneDone_NSV.Font = new Font("Segoe UI", 11F);
            buttoneDone_NSV.Location = new Point(237, 28);
            buttoneDone_NSV.Name = "buttoneDone_NSV";
            buttoneDone_NSV.Size = new Size(97, 56);
            buttoneDone_NSV.TabIndex = 3;
            buttoneDone_NSV.Text = "Выполнить";
            buttoneDone_NSV.UseVisualStyleBackColor = false;
            buttoneDone_NSV.Click += buttoneDone_NSV_Click;
            // 
            // textBoxKonec_NSV
            // 
            textBoxKonec_NSV.BorderStyle = BorderStyle.FixedSingle;
            textBoxKonec_NSV.Location = new Point(134, 46);
            textBoxKonec_NSV.Name = "textBoxKonec_NSV";
            textBoxKonec_NSV.Size = new Size(100, 29);
            textBoxKonec_NSV.TabIndex = 2;
            // 
            // textBoxStart_NSV
            // 
            textBoxStart_NSV.BorderStyle = BorderStyle.FixedSingle;
            textBoxStart_NSV.Location = new Point(11, 47);
            textBoxStart_NSV.Name = "textBoxStart_NSV";
            textBoxStart_NSV.Size = new Size(100, 29);
            textBoxStart_NSV.TabIndex = 1;
            // 
            // textBoxStartKon_NSV
            // 
            textBoxStartKon_NSV.BackColor = SystemColors.Menu;
            textBoxStartKon_NSV.BorderStyle = BorderStyle.None;
            textBoxStartKon_NSV.Location = new Point(12, 20);
            textBoxStartKon_NSV.Name = "textBoxStartKon_NSV";
            textBoxStartKon_NSV.ReadOnly = true;
            textBoxStartKon_NSV.Size = new Size(222, 22);
            textBoxStartKon_NSV.TabIndex = 0;
            textBoxStartKon_NSV.Text = "Старт шага:          Конец шага:";
            // 
            // chartFunction
            // 
            chartArea3.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartFunction.Legends.Add(legend3);
            chartFunction.Location = new Point(282, 119);
            chartFunction.Name = "chartFunction";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartFunction.Series.Add(series3);
            chartFunction.Size = new Size(738, 320);
            chartFunction.TabIndex = 3;
            title3.Name = "TitleSin";
            title3.Text = "График функции sin(x)";
            chartFunction.Titles.Add(title3);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 450);
            Controls.Add(chartFunction);
            Controls.Add(groupBoxVvodDan_NSV);
            Controls.Add(groupBox_VivodRes_NSV);
            Controls.Add(groupBoxUsl_NSV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 19 | Неупокоев С.В.";
            groupBoxUsl_NSV.ResumeLayout(false);
            groupBoxUsl_NSV.PerformLayout();
            groupBox_VivodRes_NSV.ResumeLayout(false);
            groupBox_VivodRes_NSV.PerformLayout();
            groupBoxVvodDan_NSV.ResumeLayout(false);
            groupBoxVvodDan_NSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUsl_NSV;
        private TextBox textBoxUsl_NSV;
        private GroupBox groupBox_VivodRes_NSV;
        private GroupBox groupBoxVvodDan_NSV;
        private TextBox textBoxVivodRes_NSV;
        private TextBox textBoxStartKon_NSV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private Button buttoneDone_NSV;
        private TextBox textBoxKonec_NSV;
        private TextBox textBoxStart_NSV;
        private Button buttonSpravka_NSV;
        private Button buttonSohr_NSV;
    }
}
