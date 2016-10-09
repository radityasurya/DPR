using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.subsystem
{
    public class FlightBooker
    {
        private Random random;
        private List<Flight> flights;
        public FlightBooker()
        {
            random = new Random();
            flights = new List<Flight>();
        }

        public void generate(DateTime from, DateTime to)
        {
            flights.Clear();

            DateTime dtFrom = Convert.ToDateTime(from);
            DateTime dtTo = Convert.ToDateTime(to);

            TimeSpan t = dtTo - dtFrom;

            DateTime current = dtFrom;

            int nrOfDays = Convert.ToInt32(t.TotalDays);

            int flightsTotal = random.Next(1, nrOfDays);

            for (int i = 0; i < flightsTotal; i++)
            {
                int flightsPerday = random.Next(1, 5);

                for (int j = 0; j < flightsPerday; j++)
                {

                    int airlineNr = random.Next(1, 9);

                    int price = random.Next(100, 1000);
                    flights.Add(new Flight("Airline " + toChar(airlineNr), current, price));
                }
                current = current.AddDays(1);
            }
        }

        public string toChar(int i)
        {
            string s = "";

            switch (i)
            {
                case 1: s = "A";
                    break;
                case 2: s = "B";
                    break;
                case 3: s = "C";
                    break;
                case 4:
                    s = "D";
                    break;
                case 5:
                    s = "E";
                    break;
                case 6:
                    s = "F";
                    break;
                case 7:
                    s = "G";
                    break;
                case 8:
                    s = "H";
                    break;
                case 9:
                    s = "I";
                    break;
                default:
                    break;
            }

            return s;
        }

        public List<Flight> getFlights(DateTime from, DateTime to)
        {

            generate(from, to);

            List<Flight> temp = new List<Flight>();

            foreach (var f in flights)
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
