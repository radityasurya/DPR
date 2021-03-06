﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoShop.Decorator;
using AutoShop.Interfaces;

namespace AutoShop.ConcreteDecorators
{
    public class AirCo : Accessory
    {
        private string Name = "Air Conditioner";
        public Car carObject { get; set; }

        public AirCo(Car car)
        {
            carObject = car;
        }
        public decimal GetPrice()
        {
            return 150.0m + carObject.GetPrice();
        }

        public string GetName()
        {
            return Name;
        }
    }
}
