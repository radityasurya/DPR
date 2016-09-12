using System.Collections.Generic;
using System.Linq;
using WeatherApplication.Intefaces;

namespace WeatherApplication.Classes
{
    public class WeatherSubject: Subject
    {
        private List<ObserverPush> listObsPush;
        private List<ObserverPull> listObsPull; 
        private int Temperature;
        private string Location;

        public WeatherSubject()
        {
            listObsPush = new List<ObserverPush>();
            listObsPull = new List<ObserverPull>();
        }
        public void Attach(ObserverPush ob)
        {
            listObsPush.Add(ob);
        }

        public void Attach(ObserverPull ob)
        {
            listObsPull.Add(ob);
        }

        public void Detach(ObserverPush ob)
        {
            listObsPush.Remove(ob);
        }
        public void Detach(ObserverPull ob)
        {
            listObsPull.Remove(ob);
        }

        public void SetTemperature(int temp)
        {
            Temperature = temp;
        }

        public void SetLocation(string loc)
        {
            Location = loc;
        }

        public ObserverPush FindObserverPush(int i)
        {
            return listObsPush.FirstOrDefault(el => el.ID == i);
        }

        public ObserverPull FindObserverPull(int i)
        {
            return listObsPull.FirstOrDefault(el => el.ID == i);
        }
        public void Notify()
        {
            foreach (var observer in listObsPull)
            {
                observer.Update();
            }

            foreach (var observer in listObsPush)
            {
                observer.Update(new KeyValuePair<string, int>(Location, Temperature));
            }
        }

        public KeyValuePair<string, int> GetWeather()
        {
            KeyValuePair<string, int> templocPair = new KeyValuePair<string, int>(Location, Temperature);
            return templocPair;
        }
    }
}
