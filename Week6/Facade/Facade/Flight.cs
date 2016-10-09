using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Flight
    {
        public string Airline { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }

        public Flight(string airline, DateTime date, int price)
        {
            this.Airline = airline;
            this.Date = date;
            this.Price = price;
        }

        public override string ToString()
        {
            return Airline + " (€" + Price + ") - " + Date.ToShortDateString();
        }
    }
}
