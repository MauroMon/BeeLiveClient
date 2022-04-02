namespace BeeLiveClient
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timerNoise = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNoise = new System.Windows.Forms.Label();
            this.textBoxHiveNoise = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelColor = new System.Windows.Forms.Panel();
            this.timerHive = new System.Windows.Forms.Timer(this.components);
            this.buttonCheckStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            this.SuspendLayout();
            // 
            // timerNoise
            // 
            this.timerNoise.Interval = 10000;
            this.timerNoise.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max";
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Location = new System.Drawing.Point(51, 42);
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(67, 23);
            this.numericUpDownMin.TabIndex = 2;
            this.numericUpDownMin.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.Location = new System.Drawing.Point(53, 71);
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(65, 23);
            this.numericUpDownMax.TabIndex = 3;
            this.numericUpDownMax.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Location = new System.Drawing.Point(124, 44);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStartStop.TabIndex = 4;
            this.buttonStartStop.Text = "Start";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(51, 100);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.ReadOnly = true;
            this.textBoxValue.Size = new System.Drawing.Size(100, 23);
            this.textBoxValue.TabIndex = 5;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(15, 103);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(35, 15);
            this.labelValue.TabIndex = 6;
            this.labelValue.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sensor simulation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(315, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hive status";
            // 
            // labelNoise
            // 
            this.labelNoise.AutoSize = true;
            this.labelNoise.Location = new System.Drawing.Point(315, 44);
            this.labelNoise.Name = "labelNoise";
            this.labelNoise.Size = new System.Drawing.Size(37, 15);
            this.labelNoise.TabIndex = 10;
            this.labelNoise.Text = "Noise";
            // 
            // textBoxHiveNoise
            // 
            this.textBoxHiveNoise.Location = new System.Drawing.Point(358, 41);
            this.textBoxHiveNoise.Name = "textBoxHiveNoise";
            this.textBoxHiveNoise.ReadOnly = true;
            this.textBoxHiveNoise.Size = new System.Drawing.Size(100, 23);
            this.textBoxHiveNoise.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Status";
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(360, 73);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(98, 26);
            this.panelColor.TabIndex = 12;
            // 
            // timerHive
            // 
            this.timerHive.Interval = 5000;
            this.timerHive.Tick += new System.EventHandler(this.timerHive_Tick);
            // 
            // buttonCheckStart
            // 
            this.buttonCheckStart.Location = new System.Drawing.Point(464, 41);
            this.buttonCheckStart.Name = "buttonCheckStart";
            this.buttonCheckStart.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckStart.TabIndex = 13;
            this.buttonCheckStart.Text = "Start";
            this.buttonCheckStart.UseVisualStyleBackColor = true;
            this.buttonCheckStart.Click += new System.EventHandler(this.buttonCheckStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 145);
            this.Controls.Add(this.buttonCheckStart);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelNoise);
            this.Controls.Add(this.textBoxHiveNoise);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.buttonStartStop);
            this.Controls.Add(this.numericUpDownMax);
            this.Controls.Add(this.numericUpDownMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerNoise;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDownMin;
        private NumericUpDown numericUpDownMax;
        private Button buttonStartStop;
        private TextBox textBoxValue;
        private Label labelValue;
        private Label label3;
        private Label label4;
        private Label labelNoise;
        private TextBox textBoxHiveNoise;
        private Label label5;
        private Panel panelColor;
        private System.Windows.Forms.Timer timerHive;
        private Button buttonCheckStart;
    }
}