using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disk_Scheduling
{
    public interface IStrategy
    {
        // Methods
        void Sort(List<int> list, TrackBar tb, TextBox textbox, ListBox listBox, Timer timerUp, Timer timerDown);
    }
}
