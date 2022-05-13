
namespace Simulation_lab_8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btAnswer1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_Q1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btAnswer2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nUD1 = new System.Windows.Forms.NumericUpDown();
            this.nUD2 = new System.Windows.Forms.NumericUpDown();
            this.nUD3 = new System.Windows.Forms.NumericUpDown();
            this.nUD4 = new System.Windows.Forms.NumericUpDown();
            this.lbProb5 = new System.Windows.Forms.Label();
            this.trials = new System.Windows.Forms.NumericUpDown();
            this.lb_prob1 = new System.Windows.Forms.Label();
            this.lb_prob2 = new System.Windows.Forms.Label();
            this.lb_prob3 = new System.Windows.Forms.Label();
            this.lb_prob4 = new System.Windows.Forms.Label();
            this.lb_prob5 = new System.Windows.Forms.Label();
            this.lb_trials = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbAnswer2 = new System.Windows.Forms.Label();
            this.lbAnswer1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel_Q1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAnswer1
            // 
            this.btAnswer1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btAnswer1.Location = new System.Drawing.Point(57, 111);
            this.btAnswer1.Name = "btAnswer1";
            this.btAnswer1.Size = new System.Drawing.Size(159, 42);
            this.btAnswer1.TabIndex = 0;
            this.btAnswer1.Text = "Answer!";
            this.btAnswer1.UseVisualStyleBackColor = false;
            this.btAnswer1.Click += new System.EventHandler(this.btAnswer1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel_Q1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btAnswer1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 302);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your question:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 26);
            this.textBox1.TabIndex = 2;
            // 
            // panel_Q1
            // 
            this.panel_Q1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_Q1.Controls.Add(this.lbAnswer1);
            this.panel_Q1.Location = new System.Drawing.Point(37, 201);
            this.panel_Q1.Name = "panel_Q1";
            this.panel_Q1.Size = new System.Drawing.Size(210, 50);
            this.panel_Q1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btAnswer2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(351, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 318);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your question:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(42, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 26);
            this.textBox2.TabIndex = 3;
            // 
            // btAnswer2
            // 
            this.btAnswer2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btAnswer2.Location = new System.Drawing.Point(61, 111);
            this.btAnswer2.Name = "btAnswer2";
            this.btAnswer2.Size = new System.Drawing.Size(159, 42);
            this.btAnswer2.TabIndex = 4;
            this.btAnswer2.Text = "Answer!";
            this.btAnswer2.UseVisualStyleBackColor = false;
            this.btAnswer2.Click += new System.EventHandler(this.btAnswer2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.lbAnswer2);
            this.panel3.Location = new System.Drawing.Point(42, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 50);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chart1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 324);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1048, 322);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.btStart);
            this.panel5.Controls.Add(this.lb_trials);
            this.panel5.Controls.Add(this.lb_prob5);
            this.panel5.Controls.Add(this.lb_prob4);
            this.panel5.Controls.Add(this.lb_prob2);
            this.panel5.Controls.Add(this.lb_prob3);
            this.panel5.Controls.Add(this.lb_prob1);
            this.panel5.Controls.Add(this.trials);
            this.panel5.Controls.Add(this.lbProb5);
            this.panel5.Controls.Add(this.nUD4);
            this.panel5.Controls.Add(this.nUD3);
            this.panel5.Controls.Add(this.nUD2);
            this.panel5.Controls.Add(this.nUD1);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(255, 319);
            this.panel5.TabIndex = 0;
            // 
            // nUD1
            // 
            this.nUD1.DecimalPlaces = 3;
            this.nUD1.Location = new System.Drawing.Point(90, 25);
            this.nUD1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUD1.Name = "nUD1";
            this.nUD1.Size = new System.Drawing.Size(73, 26);
            this.nUD1.TabIndex = 0;
            this.nUD1.ValueChanged += new System.EventHandler(this.nUD1_ValueChanged);
            // 
            // nUD2
            // 
            this.nUD2.DecimalPlaces = 3;
            this.nUD2.Location = new System.Drawing.Point(90, 69);
            this.nUD2.Name = "nUD2";
            this.nUD2.Size = new System.Drawing.Size(73, 26);
            this.nUD2.TabIndex = 1;
            this.nUD2.ValueChanged += new System.EventHandler(this.nUD2_ValueChanged);
            // 
            // nUD3
            // 
            this.nUD3.DecimalPlaces = 3;
            this.nUD3.Location = new System.Drawing.Point(90, 115);
            this.nUD3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUD3.Name = "nUD3";
            this.nUD3.Size = new System.Drawing.Size(73, 26);
            this.nUD3.TabIndex = 2;
            this.nUD3.ValueChanged += new System.EventHandler(this.nUD3_ValueChanged);
            // 
            // nUD4
            // 
            this.nUD4.DecimalPlaces = 3;
            this.nUD4.Location = new System.Drawing.Point(90, 156);
            this.nUD4.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUD4.Name = "nUD4";
            this.nUD4.Size = new System.Drawing.Size(73, 26);
            this.nUD4.TabIndex = 3;
            this.nUD4.ValueChanged += new System.EventHandler(this.nUD4_ValueChanged);
            // 
            // lbProb5
            // 
            this.lbProb5.AutoSize = true;
            this.lbProb5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProb5.Location = new System.Drawing.Point(86, 197);
            this.lbProb5.Name = "lbProb5";
            this.lbProb5.Size = new System.Drawing.Size(18, 20);
            this.lbProb5.TabIndex = 11;
            this.lbProb5.Text = "1";
            // 
            // trials
            // 
            this.trials.Location = new System.Drawing.Point(138, 235);
            this.trials.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.trials.Name = "trials";
            this.trials.Size = new System.Drawing.Size(73, 26);
            this.trials.TabIndex = 5;
            // 
            // lb_prob1
            // 
            this.lb_prob1.AutoSize = true;
            this.lb_prob1.Location = new System.Drawing.Point(12, 27);
            this.lb_prob1.Name = "lb_prob1";
            this.lb_prob1.Size = new System.Drawing.Size(54, 20);
            this.lb_prob1.TabIndex = 6;
            this.lb_prob1.Text = "prob 1";
            // 
            // lb_prob2
            // 
            this.lb_prob2.AutoSize = true;
            this.lb_prob2.Location = new System.Drawing.Point(12, 75);
            this.lb_prob2.Name = "lb_prob2";
            this.lb_prob2.Size = new System.Drawing.Size(54, 20);
            this.lb_prob2.TabIndex = 7;
            this.lb_prob2.Text = "prob 2";
            // 
            // lb_prob3
            // 
            this.lb_prob3.AutoSize = true;
            this.lb_prob3.Location = new System.Drawing.Point(12, 117);
            this.lb_prob3.Name = "lb_prob3";
            this.lb_prob3.Size = new System.Drawing.Size(54, 20);
            this.lb_prob3.TabIndex = 7;
            this.lb_prob3.Text = "prob 3";
            // 
            // lb_prob4
            // 
            this.lb_prob4.AutoSize = true;
            this.lb_prob4.Location = new System.Drawing.Point(12, 162);
            this.lb_prob4.Name = "lb_prob4";
            this.lb_prob4.Size = new System.Drawing.Size(54, 20);
            this.lb_prob4.TabIndex = 8;
            this.lb_prob4.Text = "prob 4";
            // 
            // lb_prob5
            // 
            this.lb_prob5.AutoSize = true;
            this.lb_prob5.Location = new System.Drawing.Point(12, 197);
            this.lb_prob5.Name = "lb_prob5";
            this.lb_prob5.Size = new System.Drawing.Size(54, 20);
            this.lb_prob5.TabIndex = 9;
            this.lb_prob5.Text = "prob 5";
            // 
            // lb_trials
            // 
            this.lb_trials.AutoSize = true;
            this.lb_trials.Location = new System.Drawing.Point(12, 237);
            this.lb_trials.Name = "lb_trials";
            this.lb_trials.Size = new System.Drawing.Size(120, 20);
            this.lb_trials.TabIndex = 10;
            this.lb_trials.Text = "Number of trials";
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btStart.Location = new System.Drawing.Point(62, 272);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(89, 38);
            this.btStart.TabIndex = 11;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "8.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "8.2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "8.3";
            // 
            // lbAnswer2
            // 
            this.lbAnswer2.AutoSize = true;
            this.lbAnswer2.Location = new System.Drawing.Point(73, 17);
            this.lbAnswer2.Name = "lbAnswer2";
            this.lbAnswer2.Size = new System.Drawing.Size(0, 20);
            this.lbAnswer2.TabIndex = 0;
            // 
            // lbAnswer1
            // 
            this.lbAnswer1.AutoSize = true;
            this.lbAnswer1.Location = new System.Drawing.Point(75, 17);
            this.lbAnswer1.Name = "lbAnswer1";
            this.lbAnswer1.Size = new System.Drawing.Size(0, 20);
            this.lbAnswer1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea3.AxisY.Maximum = 1D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(358, 0);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(562, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 646);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Q1.ResumeLayout(false);
            this.panel_Q1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAnswer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Q1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btAnswer2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label lb_trials;
        private System.Windows.Forms.Label lb_prob5;
        private System.Windows.Forms.Label lb_prob4;
        private System.Windows.Forms.Label lb_prob2;
        private System.Windows.Forms.Label lb_prob3;
        private System.Windows.Forms.Label lb_prob1;
        private System.Windows.Forms.NumericUpDown trials;
        private System.Windows.Forms.Label lbProb5;
        private System.Windows.Forms.NumericUpDown nUD4;
        private System.Windows.Forms.NumericUpDown nUD3;
        private System.Windows.Forms.NumericUpDown nUD2;
        private System.Windows.Forms.NumericUpDown nUD1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbAnswer2;
        private System.Windows.Forms.Label lbAnswer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

