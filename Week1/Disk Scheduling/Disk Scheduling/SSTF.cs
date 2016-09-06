using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disk_Scheduling
{
    public class SSTF : IStrategy
    {
        private int keySSTF = -1;

        public SSTF()
        {

        }
        public void Sort(List<int> list, TrackBar tb, TextBox textbox, ListBox listBox, Timer timerUp, Timer timerDown)
        {
            if (!list.Contains(keySSTF))
            {
                keySSTF = FindClosestElement(tb.Value, list);
            }
            textbox.Text = keySSTF.ToString();
            if (tb.Value == keySSTF)
            {
                var index = list.IndexOf(keySSTF);
                list.Remove(keySSTF);
                listBox.Items.RemoveAt(index);
                AddRandomElementToList(list, listBox);
                keySSTF = FindClosestElement(tb.Value, list);
                if (tb.Value > keySSTF)
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

        private static int FindClosestElement(int key, List<int> list)
        {
            if (list.Count != 0)
            {
                return list.Aggregate((x, y) => Math.Abs(x - key) < Math.Abs(y - key) ? x : y);
            }
            return -1;
        }
    }
}
