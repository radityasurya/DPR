using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Disk_Scheduling
{
    public class Elevator : IStrategy
    {
        private int keyScanDisk = -1;

        public Elevator()
        {

        }
        public void Sort(List<int> list, TrackBar tb, TextBox textbox, ListBox listBox, Timer timerUp, Timer timerDown)
        {
            if (!list.Contains(keyScanDisk))
            {
                keyScanDisk = timerUp.Enabled ? FindNextElement(tb.Value, list) : FindPreviousElement(tb.Value, list);
            }
            if (keyScanDisk == -1) return;
            textbox.Text = keyScanDisk.ToString();
            if (tb.Value == keyScanDisk)
            {
                var index = list.IndexOf(keyScanDisk);
                list.Remove(keyScanDisk);
                listBox.Items.RemoveAt(index);
                AddRandomElementToList(list, listBox);
                keyScanDisk = timerUp.Enabled ? FindNextElement(tb.Value, list) : FindPreviousElement(tb.Value, list);
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
        private static int FindNextElement(int key, List<int> list)
        {
            list = list.OrderBy(i => i).ToList();
            var list2 = list.Where(el => el > key).ToList();
            if (list2.Count != 0)
            {
                return list2.Min();
            }
            return -1;
        }

        private static int FindPreviousElement(int key, List<int> list)
        {
            list = list.OrderBy(i => i).ToList();
            var list2 = list.Where(el => el < key).ToList();
            if (list2.Count != 0)
            {
                return list2.Max();
            }
            return -1;
        }
    }
}
