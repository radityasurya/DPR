namespace State
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
            this.tb_Amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Balance = new System.Windows.Forms.TextBox();
            this.bt_Transaction = new System.Windows.Forms.Button();
            this.bt_State = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Amount
            // 
            this.tb_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Amount.Location = new System.Drawing.Point(80, 98);
            this.tb_Amount.Name = "tb_Amount";
            this.tb_Amount.Size = new System.Drawing.Size(207, 24);
            this.tb_Amount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "amount:";
            // 
            // tb_Balance
            // 
            this.tb_Balance.Enabled = false;
            this.tb_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Balance.Location = new System.Drawing.Point(138, 22);
            this.tb_Balance.Name = "tb_Balance";
            this.tb_Balance.Size = new System.Drawing.Size(149, 30);
            this.tb_Balance.TabIndex = 3;
            // 
            // bt_Transaction
            // 
            this.bt_Transaction.Location = new System.Drawing.Point(293, 97);
            this.bt_Transaction.Name = "bt_Transaction";
            this.bt_Transaction.Size = new System.Drawing.Size(148, 28);
            this.bt_Transaction.TabIndex = 4;
            this.bt_Transaction.Text = "button1";
            this.bt_Transaction.UseVisualStyleBackColor = true;
            this.bt_Transaction.Click += new System.EventHandler(this.bt_Transaction_Click);
            // 
            // bt_State
            // 
            this.bt_State.Location = new System.Drawing.Point(293, 22);
            this.bt_State.Name = "bt_State";
            this.bt_State.Size = new System.Drawing.Size(148, 72);
            this.bt_State.TabIndex = 5;
            this.bt_State.Text = "Switch state";
            this.bt_State.UseVisualStyleBackColor = true;
            this.bt_State.Click += new System.EventHandler(this.bt_State_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 137);
            this.Controls.Add(this.bt_State);
            this.Controls.Add(this.bt_Transaction);
            this.Controls.Add(this.tb_Balance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Amount);
            this.Name = "Form1";
            this.Text = "Bank Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Balance;
        private System.Windows.Forms.Button bt_Transaction;
        private System.Windows.Forms.Button bt_State;
    }
}

