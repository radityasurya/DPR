using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Facade;
using Facade.subsystem;
using System.Collections.Generic;

namespace FacadeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TravelFacade travel = new TravelFacade();
            List<object> results = new List<object>();

            DateTime from = DateTime.Now;
            DateTime to = from.AddDays(3);

            results = travel.getFlightsAndHotels(from, to);

            // test the stub if it is making flights and hotels data
            Assert.AreEqual(true, results.Count > 0);

            // Check if the results is list of hotels
            Assert.IsInstanceOfType(results[0], typeof(List<Hotel>));

            // Check if the resutls is list of flights
            Assert.IsInstanceOfType(results[1], typeof(List<Flight>));

        }
    }
}
