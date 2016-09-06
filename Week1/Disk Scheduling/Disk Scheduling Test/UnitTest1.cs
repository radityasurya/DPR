using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Disk_Scheduling;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Disk_Scheduling_Test
{
    [TestClass]
    public class UnitTest1
    {
        private Timer timerUp, timerDown;
        private TextBox tbNextNr;
        private TrackBar tbRange;
        private ListBox lbNumber;

        private DiskScheduler ds;

        [TestMethod]
        public void FCFSTest()
        {
            init();
            ds._list = stubNumber();
            IStrategy strategy = new FCFS();
            tbRange.Value = 1;
            ds.SetStrategy(strategy);
            ds.runStrategy();

            Assert.AreEqual(10, ds._list.ElementAt(0));
            Assert.AreEqual(2, ds._list.ElementAt(1));

        }

        [TestMethod]
        public void SSTFTest()
        {
            init();
            ds._list = stubNumber();
            IStrategy strategy = new SSTF();
            tbRange.Value++;
            ds.SetStrategy(strategy);
            ds.runStrategy();
            tbRange.Value++;
            ds.runStrategy();

            Assert.AreEqual(10, ds._list.ElementAt(0));
            Assert.AreEqual(9, ds._list.ElementAt(1));
            Assert.AreEqual(3, ds._list.ElementAt(2));

        }

        [TestMethod]
        public void ElevatorTest()
        {
            init();
            ds._list = stubNumber();
            IStrategy strategy = new Elevator();
            ds.SetStrategy(strategy);

            for (int i = 0; i < 4; i++)
            {
                tbRange.Value++;
                ds.runStrategy();
            }

            Assert.AreEqual(10, ds._list.ElementAt(1));
            Assert.AreEqual(9, ds._list.ElementAt(3));

        }
        public List<int> stubNumber()
        {
            return new List<int>()
            {
                1,10,2,9,3,8,4,7,5,6
            };
        }

        public void init()
        {
            timerUp = new Timer();
            timerDown = new Timer();
            timerDown.Interval = 75;
            timerUp.Interval = 75;
            tbRange = new TrackBar();
            tbNextNr = new TextBox();
            lbNumber = new ListBox();

            tbRange.SetRange(0, 100);
            ds = new DiskScheduler(tbRange, tbNextNr, lbNumber, timerUp, timerDown);

            foreach (int nr in stubNumber())
            {
                lbNumber.Items.Add(nr);
            }
        }
    }
}
