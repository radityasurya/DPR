using System.Collections.Generic;
using System.Windows.Forms;
using WeatherApplication.Intefaces;

namespace WeatherApplication.Classes
{
    public class WeatherObserverPush : ObserverPush
    {
        public int ID { get; set; }
        private Subject subject;
        private TabControl tabControl;
        public WeatherObserverPush(int id, Subject s, TabControl tab)
        {
            ID = id;
            subject = s;
            subject.Attach(this);
            tabControl = tab;
        }
        public void Update(KeyValuePair<string, int> loctempPair)
        {
            var tabpage = tabControl.TabPages["Observer push: " + ID];
            var usercontrol = tabpage?.Controls[0] as UserControls.ObserverPush;
            if (usercontrol == null) return;
            usercontrol.SetLabelLocation(loctempPair.Key);
            usercontrol.SetLabelTemperature(loctempPair.Value);
        }
    }
}
