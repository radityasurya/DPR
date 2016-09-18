using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoShop.Decorator;
using AutoShop.Interfaces;

namespace AutoShop.ConcreteDecorators
{
    public class GPS : Accessory
    {
        private string Name = "GPS Navigation";
        public Car carObject { get; set; }
        public string Map = "World";

        public GPS(Car car)
        {
            carObject = car;
        }

        public decimal GetPrice()
        {
            return 100.25m + carObject.GetPrice();
        }

        public string GetName()
        {
            return Name;
        }
    }
}
