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
            this.tbRange = new System.Windows.Forms.TrackBar();
            this.lbCurrentNr = new System.Windows.Forms.Label();
            this.tbNextNr = new System.Windows.Forms.TextBox();
            this.lbNumber = new System.Windows.Forms.ListBox();
            this.gbAlgo = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.rbElevator = new System.Windows.Forms.RadioButton();
            this.rbSSTF = new System.Windows.Forms.RadioButton();
            this.rbFCFS = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbRange)).BeginInit();
            this.gbAlgo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbRange
            // 
            this.tbRange.LargeChange = 3;
            this.tbRange.Location = new System.Drawing.Point(52, 12);
            this.tbRange.Maximum = 100;
            this.tbRange.Name = "tbRange";
            this.tbRange.Size = new System.Drawing.Size(700, 45);
            this.tbRange.TabIndex = 0;
            this.tbRange.ValueChanged += new System.EventHandler(this.tbRange_ValueChanged);
            // 
            // lbCurrentNr
            // 
            this.lbCurrentNr.AutoSize = true;
            this.lbCurrentNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentNr.Location = new System.Drawing.Point(12, 12);
            this.lbCurrentNr.Name = "lbCurrentNr";
            this.lbCurrentNr.Size = new System.Drawing.Size(23, 25);
            this.lbCurrentNr.TabIndex = 1;
            this.lbCurrentNr.Text = "0";
            // 
            // tbNextNr
            // 
            this.tbNextNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNextNr.Location = new System.Drawing.Point(16, 49);
            this.tbNextNr.Name = "tbNextNr";
            this.tbNextNr.Size = new System.Drawing.Size(146, 26);
            this.tbNextNr.TabIndex = 2;
            // 
            // lbNumber
            // 
            this.lbNumber.FormattingEnabled = true;
            this.lbNumber.Location = new System.Drawing.Point(16, 81);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(146, 277);
            this.lbNumber.TabIndex = 3;
            // 
            // gbAlgo
            // 
            this.gbAlgo.Controls.Add(this.btnStop);
            this.gbAlgo.Controls.Add(this.btnStart);
            this.gbAlgo.Controls.Add(this.rbElevator);
            this.gbAlgo.Controls.Add(this.rbSSTF);
            this.gbAlgo.Controls.Add(this.rbFCFS);
            this.gbAlgo.Location = new System.Drawing.Point(179, 49);
            this.gbAlgo.Name = "gbAlgo";
            this.gbAlgo.Size = new System.Drawing.Size(257, 309);
            this.gbAlgo.TabIndex = 4;
            this.gbAlgo.TabStop = false;
            this.gbAlgo.Text = "Strategy";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(6, 262);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(245, 41);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 215);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(245, 41);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rbElevator
            // 
            this.rbElevator.AutoSize = true;
            this.rbElevator.Location = new System.Drawing.Point(19, 65);
            this.rbElevator.Name = "rbElevator";
            this.rbElevator.Size = new System.Drawing.Size(126, 17);
            this.rbElevator.TabIndex = 2;
            this.rbElevator.Text = "SCAN Disk (Elevator)";
            this.rbElevator.UseVisualStyleBackColor = true;
            this.rbElevator.CheckedChanged += new System.EventHandler(this.rbElevator_CheckedChanged);
            // 
            // rbSSTF
            // 
            this.rbSSTF.AutoSize = true;
            this.rbSSTF.Location = new System.Drawing.Point(19, 42);
            this.rbSSTF.Name = "rbSSTF";
            this.rbSSTF.Size = new System.Drawing.Size(140, 17);
            this.rbSSTF.TabIndex = 1;
            this.rbSSTF.Text = "Shortest Seek Time First";
            this.rbSSTF.UseVisualStyleBackColor = true;
            this.rbSSTF.CheckedChanged += new System.EventHandler(this.rbSSTF_CheckedChanged);
            // 
            // rbFCFS
            // 
            this.rbFCFS.AutoSize = true;
            this.rbFCFS.Checked = true;
            this.rbFCFS.Location = new System.Drawing.Point(19, 19);
            this.rbFCFS.Name = "rbFCFS";
            this.rbFCFS.Size = new System.Drawing.Size(127, 17);
            this.rbFCFS.TabIndex = 0;
            this.rbFCFS.TabStop = true;
            this.rbFCFS.Text = "First Come First Serve";
            this.rbFCFS.UseVisualStyleBackColor = true;
            this.rbFCFS.CheckedChanged += new System.EventHandler(this.rbFCFS_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 381);
            this.Controls.Add(this.gbAlgo);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.tbNextNr);
            this.Controls.Add(this.lbCurrentNr);
            this.Controls.Add(this.tbRange);
            this.Name = "Form1";
            this.Text = "Disk Scheduler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbRange)).EndInit();
            this.gbAlgo.ResumeLayout(false);
            this.gbAlgo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbRange;
        private System.Windows.Forms.Label lbCurrentNr;
        private System.Windows.Forms.TextBox tbNextNr;
        private System.Windows.Forms.ListBox lbNumber;
        private System.Windows.Forms.GroupBox gbAlgo;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rbElevator;
        private System.Windows.Forms.RadioButton rbSSTF;
        private System.Windows.Forms.RadioButton rbFCFS;
    }
}

