using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disk_Scheduling
{
    public partial class Form1 : Form
    {
        // Properties
        private int algoNr;
        DiskScheduler ds;
        private Timer timerUp, timerDown;
        private List<int> tempList;

        public Form1()
        {
            InitializeComponent();
            algoNr = 0;

            tbNextNr.ForeColor = Color.Red;
            tbNextNr.Font = new Font(tbNextNr.Font, FontStyle.Bold);
            timerUp = new Timer();
            timerDown = new Timer();
            timerDown.Interval = 75;
            timerUp.Interval = 75;

            ds = new DiskScheduler(tbRange, tbNextNr, lbNumber, timerUp, timerDown);
            tempList = ds.loadNumber();
            tbNextNr.Text = tempList.ElementAt(0).ToString();

            timerUp.Tick += (sender, args) =>
            {
                if (tbRange.Value < tbRange.Maximum)
                {
                    tbRange.Value += 1;
                }
                if (tbRange.Value == tbRange.Maximum)
                {
                    timerUp.Stop();
                    timerDown.Start();
                }
            };

            timerDown.Tick += (sender, args) =>
            {
                if (tbRange.Value > tbRange.Minimum)
                {
                    tbRange.Value -= 1;
                }
                if (tbRange.Value == tbRange.Minimum)
                {
                    timerDown.Stop();
                    timerUp.Start();
                }
            };
        }

        private void rbFCFS_CheckedChanged(object sender, EventArgs e)
        {
            algoNr = 0;
            switch (getStrategy())
            {
                case 0:
                    ds.SetStrategy(new FCFS());
                    break;
                case 1:
                    ds.SetStrategy(new SSTF());
                    break;
                case 2:
                    ds.SetStrategy(new Elevator());
                    break;
                default:
                    ds.SetStrategy(new FCFS());
                    break;
            }

            ds.runStrategy();
        }

        private void rbSSTF_CheckedChanged(object sender, EventArgs e)
        {
            algoNr = 1;
            switch (getStrategy())
            {
                case 0:
                    ds.SetStrategy(new FCFS());
                    break;
                case 1:
                    ds.SetStrategy(new SSTF());
                    break;
                case 2:
                    ds.SetStrategy(new Elevator());
                    break;
                default:
                    ds.SetStrategy(new FCFS());
                    break;
            }

            ds.runStrategy();
        }

        private void rbElevator_CheckedChanged(object sender, EventArgs e)
        {
            algoNr = 2;
            switch (getStrategy())
            {
                case 0:
                    ds.SetStrategy(new FCFS());
                    break;
                case 1:
                    ds.SetStrategy(new SSTF());
                    break;
                case 2:
                    ds.SetStrategy(new Elevator());
                    break;
                default:
                    ds.SetStrategy(new FCFS());
                    break;
            }

            ds.runStrategy();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            switch (getStrategy())
            {
                case 0:
                    ds.SetStrategy(new FCFS());
                    break;
                case 1:
                    ds.SetStrategy(new SSTF());
                    break;
                case 2:
                    ds.SetStrategy(new Elevator());
                    break;
                default:
                    ds.SetStrategy(new FCFS());
                    break;
            }

            start();
            ds.runStrategy();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load List Number
            foreach (int nr in tempList)
            {
                lbNumber.Items.Add(nr);
            }

            // Set trackbar
            lbCurrentNr.Text = tbRange.Value.ToString();
        }

        private void tbRange_ValueChanged(object sender, EventArgs e)
        {
            lbCurrentNr.Text = tbRange.Value.ToString();
            ds.runStrategy();
            if (tbRange.Value == ds._list.ElementAt(0))
            {
                lbCurrentNr.ForeColor = System.Drawing.Color.Red;
            } else
            {
                lbCurrentNr.ForeColor = System.Drawing.Color.Black;
            }
        }

        public void start()
        {
            timerUp.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerUp.Stop();
            timerDown.Stop();
            tbRange.Value = 0;
        }

        private int getStrategy()
        {
            if (rbFCFS.Checked)
            {
                return 0;
            }
            return rbSSTF.Checked ? 1 : 2;
        }
    }
}
