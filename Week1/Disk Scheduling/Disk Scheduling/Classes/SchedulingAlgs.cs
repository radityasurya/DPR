using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Disk_Scheduling.Interfaces;

namespace Disk_Scheduling.Classes
{
    public class SchedulingAlgs: Strategy
    {

        private int keyScanDisk = -1, keySSTF = -1;
        //Done
        public void FCFS(List<int> list, TrackBar tb, TextBox textbox, ListBox listBox, Timer timerUp, Timer timerDown)
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

        //Done
        public void SSTF(List<int> list, TrackBar tb, TextBox textbox, ListBox listBox, Timer timerUp, Timer timerDown)
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

        //Done
        public void ScanDisk(List<int> list, TrackBar tb, TextBox textbox, ListBox listBox, Timer timerUp,
            Timer timerDown)
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

        private static int FindClosestElement(int key, List<int> list)
        {
            if (list.Count != 0)
            {
                return list.Aggregate((x, y) => Math.Abs(x - key) < Math.Abs(y - key) ? x : y);
            }
            return -1;
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
