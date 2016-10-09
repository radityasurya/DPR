using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.subsystem;

namespace Facade
{
    public class TravelFacade
    {
        private HotelBooker hotel;
        private FlightBooker flight;

        public TravelFacade()
        {
            hotel = new HotelBooker();
            flight = new FlightBooker();
        }

        public List<object> getFlightsAndHotels(DateTime from, DateTime to)
        {
            List<object> results = new List<object>();

            var hotels = hotel.getHotels(from, to);
            var flights = flight.getFlights(from, to);

            results.Add(hotels);
            results.Add(flights);

            return results;
        }

    }
}
