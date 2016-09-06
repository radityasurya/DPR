using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Disk_Scheduling.Classes;

namespace Disk_Scheduling
{
    public partial class Form1 : Form
    {
        private Simulation SimObj;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            /*This is a pre-made list with values. If you want to change them. 
            Go to: 'Project Folder'/load/list1.txt and change values in there.*/
            var dir = new DirectoryInfo("../../load/");
            var getAllFiles = dir.GetFiles().ElementAt(0);       
            string[] sectors = File.ReadAllLines(getAllFiles.FullName);
            List<int> list = new List<int>();
            sectors.ToList().ForEach(nr =>
            {
                listBox1.Items.Add(nr);
                list.Add(int.Parse(nr));
            });

            SimObj = new Simulation(list, trackBar1, textBox1, listBox1);
            label1.Text = trackBar1.Value.ToString();
            textBox1.ForeColor = Color.Red;
            textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            SimObj.RunAlgorithm(DecideWhichAlgIsSelected());
        }

        private void bt_Run_Click(object sender, EventArgs e)
        {
            SimObj.Run();
        }

        private void bt_Stop_Click(object sender, EventArgs e)
        {
            SimObj.Stop();
        }

        private int DecideWhichAlgIsSelected()
        {
            if (r_FCFS.Checked)
            {
                return 0;
            }
            return r_SSTF.Checked ? 1 : 2;
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            //SimObj.Run(DecideWhichAlgIsSelected());
        }
    }
}
