using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoShop.Interfaces;
using AutoShop.ConcreteComponents;
using AutoShop.ConcreteDecorators;
using AutoShop.Decorator;

namespace AutoShopTest
{
    [TestClass]
    public class AuthoShopTest
    {
        [TestMethod]
        public void getVWPriceTest()
        {
            decimal price = 0;

            // Test default car price
            Car golf = new VolkswagenGolf();
            price = golf.GetPrice();

            Assert.AreEqual((decimal) 10000.5, price);

            // Test car price with AirCo
            Car airco = new AirCo(golf);
            price = airco.GetPrice();

            Assert.AreEqual((decimal)10150.5, price);

            // Test car price with 2 or more accessories
            Car gps = new GPS(airco);
            price = gps.GetPrice();

            Assert.AreEqual((decimal)10250.75, price);
        }

        [TestMethod]
        public void getFordPriceTest()
        {
            decimal price = 0;

            // Test default car price
            Car ford = new FordFocus();
            price = ford.GetPrice();

            Assert.AreEqual((decimal)9000.5, price);

            // Test car price with AirCo
            Car airco = new AirCo(ford);
            price = airco.GetPrice();

            Assert.AreEqual((decimal)9150.5, price);

            // Test car price with 2 or more accessories
            Car gps = new GPS(airco);
            price = gps.GetPrice();

            Assert.AreEqual((decimal)9250.75, price);
        }
    }
}
