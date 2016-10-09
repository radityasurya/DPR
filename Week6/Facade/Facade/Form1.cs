using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facade
{
    public partial class Form1 : Form
    {
        private TravelFacade travel;
        private List<object> results;

        public Form1()
        {
            travel = new TravelFacade();
            InitializeComponent();
            results = new List<object>();
            dtTo.Value = DateTime.Now.AddDays(1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbHotels.Items.Clear();
            lbFlights.Items.Clear();

            DateTime from = dtFrom.Value;
            DateTime to = dtTo.Value;

            results = travel.getFlightsAndHotels(from, to);

            List<Hotel> hotels = (List<Hotel>) results[0];

            List<Flight> flights = (List<Flight>) results[1];

            foreach (var item in hotels)
            {
                lbHotels.Items.Add(item);
            }

            foreach (var s in flights)
            {
                lbFlights.Items.Add(s);
            }
        }
    }
}
