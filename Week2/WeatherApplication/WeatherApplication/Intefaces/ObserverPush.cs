using System.Collections.Generic;

namespace WeatherApplication.Intefaces
{
    public interface ObserverPush
    {
        int ID { get; set; }
        void Update(KeyValuePair<string, int> loctempPair); 
    }
}
