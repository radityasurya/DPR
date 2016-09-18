using System.Drawing;
using AutoShop.Interfaces;

namespace AutoShop.ConcreteComponents
{
    public class VolkswagenGolf : Car
    {
        private string Name = "Volkswagen Golf";
        private decimal Price = 10000.5m;
        public Bitmap Photo = new Bitmap(Properties.Resources.golf);
        public decimal GetPrice()
        {
            return Price;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
