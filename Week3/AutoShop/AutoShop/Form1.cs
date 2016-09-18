using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using AutoShop.ConcreteComponents;
using AutoShop.ConcreteDecorators;
using AutoShop.Decorator;
using AutoShop.Interfaces;

namespace AutoShop
{
    public partial class Form1 : Form
    {
        private List<Car> VWList = new List<Car>();
        private List<Car> FordList = new List<Car>();
        private static Car golf = new VolkswagenGolf();
        private static Car ford = new FordFocus();
        public Form1()
        {
            InitializeComponent();
            VWList.Add(golf);
            FordList.Add(ford);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            tb_Ford.Enabled = false;
            tb_VW.Enabled = false;
            lblVW.Text = golf.GetName();
            tb_VW.Text = golf.GetPrice().ToString(CultureInfo.InvariantCulture);
            lblFord.Text = ford.GetName();
            tb_Ford.Text = ford.GetPrice().ToString(CultureInfo.InvariantCulture);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = ((VolkswagenGolf) golf).Photo;
            pictureBox2.Image = ((FordFocus) ford).Photo;
        }

        private void chkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox.Checked)
            {
                switch (checkBox.Name)
                {
                    case "chkAir_VW":
                        Car airco = new AirCo(VWList.Last());
                        VWList.Add(airco);
                        tb_VW.Text = airco.GetPrice().ToString();
                        break;
                    case "chkGPS_VW":
                        Car gps = new GPS(VWList.Last());
                        VWList.Add(gps);
                        tb_VW.Text = gps.GetPrice().ToString();
                        break;
                    case "chkTires_VW":
                        Car tires = new SnowTires(VWList.Last());
                        VWList.Add(tires);
                        tb_VW.Text = tires.GetPrice().ToString();
                        break;
                    case "chkAir_Ford":
                        Car aircoF = new AirCo(FordList.Last());
                        FordList.Add(aircoF);
                        tb_Ford.Text = aircoF.GetPrice().ToString();
                        break;
                    case "chkGPS_Ford":
                        Car gpsF = new GPS(FordList.Last());
                        FordList.Add(gpsF);
                        tb_Ford.Text = gpsF.GetPrice().ToString();
                        break;
                    case "chkTires_Ford":
                        Car tiresF = new SnowTires(FordList.Last());
                        FordList.Add(tiresF);
                        tb_Ford.Text = tiresF.GetPrice().ToString();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (checkBox.Name)
                {
                    case "chkAir_VW":
                        Car airco =
                            VWList.Select(car => car).Where(car => car.GetName() == "Air Conditioner").ToList().First();
                        if (airco == null) return;
                        LinkNextWithPreviousCarObjects(airco, VWList);
                        VWList.RemoveAll(car => car.GetName().Equals(airco.GetName()));
                        tb_VW.Text = VWList.Last().GetPrice().ToString();
                        break;
                    case "chkGPS_VW":
                        Car gps =
                            VWList.Select(car => car).Where(car => car.GetName() == "GPS Navigation").ToList().First();
                        if (gps == null) return;
                        LinkNextWithPreviousCarObjects(gps, VWList);
                        VWList.RemoveAll(car => car.GetName().Equals(gps.GetName()));
                        tb_VW.Text = VWList.Last().GetPrice().ToString();
                        break;
                    case "chkTires_VW":
                        Car tires =
                            VWList.Select(car => car).Where(car => car.GetName() == "Snow Tires").ToList().First();
                        if (tires == null) return;
                        LinkNextWithPreviousCarObjects(tires, VWList);
                        VWList.RemoveAll(car => car.GetName().Equals(tires.GetName()));
                        tb_VW.Text = VWList.Last().GetPrice().ToString();
                        break;
                    case "chkAir_Ford":
                        Car aircoF =
                            FordList.Select(car => car)
                                .Where(car => car.GetName() == "Air Conditioner")
                                .ToList()
                                .First();
                        if (aircoF == null) return;
                        LinkNextWithPreviousCarObjects(aircoF, FordList);
                        FordList.RemoveAll(car => car.GetName().Equals(aircoF.GetName()));
                        tb_Ford.Text = FordList.Last().GetPrice().ToString();
                        break;
                    case "chkGPS_Ford":
                        Car gpsF =
                            FordList.Select(car => car).Where(car => car.GetName() == "GPS Navigation").ToList().First();
                        if (gpsF == null) return;
                        LinkNextWithPreviousCarObjects(gpsF, FordList);
                        FordList.RemoveAll(car => car.GetName().Equals(gpsF.GetName()));
                        tb_Ford.Text = FordList.Last().GetPrice().ToString();
                        break;
                    case "chkTires_Ford":
                        Car tiresF =
                            FordList.Select(car => car).Where(car => car.GetName() == "Snow Tires").ToList().First();
                        if (tiresF == null) return;
                        LinkNextWithPreviousCarObjects(tiresF, FordList);
                        FordList.RemoveAll(car => car.GetName().Equals(tiresF.GetName()));
                        tb_Ford.Text = FordList.Last().GetPrice().ToString();
                        break;
                    default:
                        break;
                }
            }

        }

        private void LinkNextWithPreviousCarObjects(Car carObject, List<Car> list)
        {
            if (list.IndexOf(carObject) != list.Count - 1)
            {
                int index = list.IndexOf(carObject);
                Car nextcarobject = list.ElementAt(index + 1);
                if (nextcarobject is AirCo || nextcarobject is GPS || nextcarobject is SnowTires)
                {
                    ((Accessory)list.ElementAt(index + 1)).carObject = list.ElementAt(index - 1);
                }
            }
        }

    }
}

