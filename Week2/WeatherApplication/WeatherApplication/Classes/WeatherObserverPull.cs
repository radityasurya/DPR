using System.Windows.Forms;
using WeatherApplication.Intefaces;

namespace WeatherApplication.Classes
{
    public class WeatherObserverPull : ObserverPull
    {
        public int ID { get; set; }
        private WeatherSubject subject;
        private TabControl tabControl;

        public WeatherObserverPull(int id, WeatherSubject s, TabControl tab)
        {
            ID = id;
            subject = s;
            subject.Attach(this);
            tabControl = tab;
        }

        public void Update()
        {
            var pair = subject.GetWeather();
            var tabpage = tabControl.TabPages["Observer pull: " + ID];
            var usercontrol = tabpage?.Controls[0] as UserControls.ObserverPull;
            if (usercontrol == null) return;
            usercontrol.SetLabelLocation(pair.Key);
            usercontrol.SetLabelTemperature(pair.Value);
        }
    }
}
