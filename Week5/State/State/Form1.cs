using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace State
{
    public partial class Form1 : Form
    {
        private Context ctxt;
        public Form1()
        {
            InitializeComponent();
            tb_Balance.Text = "1000";
            ctxt = new Context(this);
            ctxt.setState(new StateDeposit());
            CheckState(ctxt);
            tb_Amount.GotFocus += (sender, args) =>
            {
                tb_Amount.Text = string.Empty;
            };
        }

        private void bt_Transaction_Click(object sender, EventArgs e)
        {
            try
            {
                double amount = Convert.ToDouble(tb_Amount.Text);
                double currentAmount = Convert.ToDouble(tb_Balance.Text);
                if (ctxt.getState() is StateDeposit)
                {
                    currentAmount += amount;
                }
                else
                {
                    if (currentAmount - amount >= 0)
                    {
                        currentAmount -= amount;
                    }
                    else
                    {
                        tb_Amount.Text = @"Balance can't be negative";
                    }
                }
                tb_Balance.Text = currentAmount.ToString();
            }
            catch (FormatException exc)
            {
                tb_Amount.Text = @"Only numbers are allowed";
            }
        }

        private void bt_State_Click(object sender, EventArgs e)
        {
            ctxt.goNext();
            CheckState(ctxt);
        }

        public void CheckState(Context cxt)
        {
            if (cxt.getState() is StateDeposit)
            {
                Text = "Bank Transaction - Deposit";
                bt_Transaction.Text = "Deposit";
            }
            else
            {
                Text = "Bank Transaction - Withdraw";
                bt_Transaction.Text = "Withdraw";
            }
        }
    }
}
