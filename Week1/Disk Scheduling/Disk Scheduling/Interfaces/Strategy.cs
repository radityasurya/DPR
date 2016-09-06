using System.Collections.Generic;
using System.Windows.Forms;

namespace Disk_Scheduling.Interfaces
{
    public interface Strategy
    {
        void FCFS(List<int> list, TrackBar tb, TextBox textbox, ListBox listBox, Timer timerUp, Timer timerDown);
        void SSTF(List<int> list, TrackBar tb, TextBox textbox, ListBox listBox, Timer timerUp, Timer timerDown);
        void ScanDisk(List<int> list, TrackBar tb, TextBox textbox, ListBox listBox, Timer timerUp, Timer timerDown);
    }
}
