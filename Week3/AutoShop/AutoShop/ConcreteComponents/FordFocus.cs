using System.Drawing;
using AutoShop.Interfaces;

namespace AutoShop.ConcreteComponents
{
    public class FordFocus : Car
    {
        private string Name = "Ford Focus";
        private decimal Price = 9000.5m;
        public Bitmap Photo = new Bitmap(Properties.Resources.ford);
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
