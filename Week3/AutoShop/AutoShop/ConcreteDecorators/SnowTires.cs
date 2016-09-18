using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoShop.Decorator;
using AutoShop.Interfaces;

namespace AutoShop.ConcreteDecorators
{
    public class SnowTires : Accessory
    {
        private string Name = "Snow Tires";
        public Car carObject { get; set; }

        public SnowTires(Car car)
        {
            carObject = car;
        }
        public decimal GetPrice()
        {
            return 210.5m + carObject.GetPrice();
        }

        public string GetName()
        {
            return Name;
        }

    }
}
