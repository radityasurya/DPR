using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Disk_Scheduling
{
    public class FCFS:IStrategy
    {
        // Properties

        // Constructor
        public FCFS()
        {
        }

        // Methods
        public void Sort(List<int> list, TrackBar tb, TextBox textbox, ListBox listBox, Timer timerUp, Timer timerDown)
        {
            int key = list.ElementAt(0);
            textbox.Text = key.ToString();
            if (tb.Value == key)
            {
                list.RemoveAt(0);
                listBox.Items.RemoveAt(0);
                AddRandomElementToList(list, listBox);
                key = list.ElementAt(0);
                if (tb.Value > key)
                {
                    timerUp.Stop();
                    timerDown.Start();
                }
                else
                {
                    timerDown.Stop();
                    timerUp.Start();
                }
            }
        }
        private static void AddRandomElementToList(List<int> list, ListBox listBox)
        {
            Random rand = new Random();
            int i = rand.Next(0, 100);
            if (!list.Contains(i))
            {
                list.Add(i);
                listBox.Items.Add(i);
            }
        }
    }
}
