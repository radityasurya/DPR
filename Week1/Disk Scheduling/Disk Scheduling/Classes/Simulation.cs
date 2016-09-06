using System.Collections.Generic;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Disk_Scheduling.Classes
{
    public class Simulation
    {
        private SchedulingAlgs diskAlgs;
        private readonly List<int> Sectors;
        private Timer timerUp, timerDown;
        private TrackBar TBar;
        private TextBox TBox;
        private ListBox LBox;
        public Simulation(List<int> sectors, TrackBar tb, TextBox tbox, ListBox lbox)
        {
            Sectors = sectors;
            TBar = tb;
            TBox = tbox;
            LBox = lbox;
            diskAlgs = new SchedulingAlgs();
            timerUp = new Timer();
            timerDown = new Timer();
            timerDown.Interval = 75;
            timerUp.Interval = 75;
            timerUp.Tick += (sender, args) =>
            {
                if (TBar.Value < TBar.Maximum)
                {
                    TBar.Value += 1;
                }
                if (TBar.Value == TBar.Maximum)
                {
                    timerUp.Stop();
                    timerDown.Start();
                }
            };

            timerDown.Tick += (sender, args) =>
            {
                if (TBar.Value > TBar.Minimum)
                {
                    TBar.Value -= 1;
                }
                if (TBar.Value == TBar.Minimum)
                {
                    timerDown.Stop();
                    timerUp.Start();
                }
            };
        }
        public void Run()
        {
            timerUp.Start();
        }

        public void RunAlgorithm(int algNr)
        {
            switch (algNr)
            {
                case 0:
                    diskAlgs.FCFS(Sectors, TBar, TBox, LBox, timerUp, timerDown);
                    break;
                case 1:
                    diskAlgs.SSTF(Sectors, TBar, TBox, LBox, timerUp, timerDown);
                    break;
                case 2:
                    diskAlgs.ScanDisk(Sectors, TBar, TBox, LBox, timerUp, timerDown);
                    break;
                default:
                    diskAlgs.FCFS(Sectors, TBar, TBox, LBox, timerUp, timerDown);
                    break;
            }
        }

        public void Stop()
        {
            timerUp.Stop();
            timerDown.Stop();
            TBar.Value = 0;
        }
    }
}
