using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Hotel
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }

        public Hotel(string name, DateTime date, int price)
        {
            this.Name = name;
            this.Date = date;
            this.Price = price;
        }

        public override string ToString()
        {
            return Name + " (€" + Price + ") - " + Date.ToShortDateString();
        }
    }
}
