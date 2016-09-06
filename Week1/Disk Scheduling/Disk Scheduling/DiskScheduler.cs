using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Disk_Scheduling
{
    public class DiskScheduler
    {
        // Interface
        public IStrategy iStrategy;

        // Properties
        public List<int> _list = new List<int>();
        private TextBox TBox;
        private TrackBar TBar;
        private ListBox LBox;
        private Timer timerUp, timerDown;

        // Constructor
        public DiskScheduler()
        {
        }
        public DiskScheduler(TrackBar tb, TextBox textbox, ListBox listBox, Timer timerUp, Timer timerDown)
        {
            _list = loadNumber();
            TBar = tb;
            TBox = textbox;
            LBox = listBox;
            this.timerUp = timerUp;
            this.timerDown = timerDown;
        }

        // Methods
        public void runStrategy()
        {
            iStrategy.Sort(_list, TBar, TBox, LBox, timerUp, timerDown);
        }
        
        public void SetStrategy(IStrategy strategy)
        {
            this.iStrategy = strategy;
        }

        public List<int> loadNumber()
        {
            /*This is a pre-made list with values. If you want to change them. 
            Go to: 'Project Folder'/load/list1.txt and change values in there.*/
            var dir = new DirectoryInfo("../../load/");
            var getAllFiles = dir.GetFiles().ElementAt(0);
            string[] sectors = File.ReadAllLines(getAllFiles.FullName);
            List<int> list = new List<int>();
            sectors.ToList().ForEach(nr =>
            {
                list.Add(int.Parse(nr));
            });

            return list;
        }
    }
}
