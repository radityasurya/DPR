namespace Disk_Scheduling
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.r_SCAN = new System.Windows.Forms.RadioButton();
            this.r_SSTF = new System.Windows.Forms.RadioButton();
            this.r_FCFS = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.bt_Run = new System.Windows.Forms.Button();
            this.bt_Stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.r_SCAN);
            this.groupBox1.Controls.Add(this.r_SSTF);
            this.groupBox1.Controls.Add(this.r_FCFS);
            this.groupBox1.Location = new System.Drawing.Point(132, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "strategy";
            // 
            // r_SCAN
            // 
            this.r_SCAN.AutoSize = true;
            this.r_SCAN.Location = new System.Drawing.Point(6, 85);
            this.r_SCAN.Name = "r_SCAN";
            this.r_SCAN.Size = new System.Drawing.Size(163, 21);
            this.r_SCAN.TabIndex = 2;
            this.r_SCAN.Text = "SCAN Disk (Elevator)";
            this.r_SCAN.UseVisualStyleBackColor = true;
            this.r_SCAN.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // r_SSTF
            // 
            this.r_SSTF.AutoSize = true;
            this.r_SSTF.Location = new System.Drawing.Point(6, 58);
            this.r_SSTF.Name = "r_SSTF";
            this.r_SSTF.Size = new System.Drawing.Size(184, 21);
            this.r_SSTF.TabIndex = 1;
            this.r_SSTF.Text = "Shortest Seek Time First";
            this.r_SSTF.UseVisualStyleBackColor = true;
            this.r_SSTF.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // r_FCFS
            // 
            this.r_FCFS.AutoSize = true;
            this.r_FCFS.Checked = true;
            this.r_FCFS.Location = new System.Drawing.Point(6, 31);
            this.r_FCFS.Name = "r_FCFS";
            this.r_FCFS.Size = new System.Drawing.Size(168, 21);
            this.r_FCFS.TabIndex = 0;
            this.r_FCFS.TabStop = true;
            this.r_FCFS.Text = "First Come First Serve";
            this.r_FCFS.UseVisualStyleBackColor = true;
            this.r_FCFS.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 292);
            this.listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 341);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(573, 56);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // bt_Run
            // 
            this.bt_Run.Location = new System.Drawing.Point(178, 156);
            this.bt_Run.Name = "bt_Run";
            this.bt_Run.Size = new System.Drawing.Size(103, 37);
            this.bt_Run.TabIndex = 4;
            this.bt_Run.Text = "run";
            this.bt_Run.UseVisualStyleBackColor = true;
            this.bt_Run.Click += new System.EventHandler(this.bt_Run_Click);
            // 
            // bt_Stop
            // 
            this.bt_Stop.Location = new System.Drawing.Point(178, 226);
            this.bt_Stop.Name = "bt_Stop";
            this.bt_Stop.Size = new System.Drawing.Size(103, 37);
            this.bt_Stop.TabIndex = 5;
            this.bt_Stop.Text = "stop";
            this.bt_Stop.UseVisualStyleBackColor = true;
            this.bt_Stop.Click += new System.EventHandler(this.bt_Stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Stop);
            this.Controls.Add(this.bt_Run);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton r_SCAN;
        private System.Windows.Forms.RadioButton r_SSTF;
        private System.Windows.Forms.RadioButton r_FCFS;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button bt_Run;
        private System.Windows.Forms.Button bt_Stop;
        private System.Windows.Forms.Label label1;
    }
}

