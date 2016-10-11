using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.subsystem
{
    public class HotelBooker
    {
        private Random random;
        private List<Hotel> hotels;
        public HotelBooker()
        {
            random = new Random();
            hotels = new List<Hotel>();
        }

        private void generate(DateTime from, DateTime to)
        {
            hotels.Clear();

            DateTime dtFrom = Convert.ToDateTime(from);
            DateTime dtTo = Convert.ToDateTime(to);

            TimeSpan t = dtTo - dtFrom;

            DateTime current = dtFrom;

            int nrOfDays = Convert.ToInt32(t.TotalDays);

            int hotelsTotal = random.Next(1, nrOfDays);

            for (int i = 0; i < hotelsTotal; i++)
            {
                int hotelPerday = random.Next(1, 5);

                for (int j = 0; j < hotelPerday; j++)
                {
                    
                    int hotelNr = random.Next(1000, 10000);
                    int price = random.Next(20, 200);
                    hotels.Add(new Hotel("Hotel " + hotelNr, current, price));
                }
                current = current.AddDays(1);
            }
        }

        public List<Hotel> getHotels(DateTime from, DateTime to)
        {
            generate(from, to);

            List<Hotel> temp = new List<Hotel>();

            foreach (var f in hotels)
            {
                if (f.Date >= from || f.Date <= to)
                {
                    temp.Add(f);
                }
            }

            return temp;
        }
    }
}
