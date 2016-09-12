using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WeatherApplication.Classes;
using WeatherApplication.UserControls;

namespace WeatherApplication
{
    public partial class Form1 : Form
    {
        WeatherSubject Subject = new WeatherSubject();
        private int ID, counter;
        private List<string> listLocations = new List<string> {"Eindhoven", "Amsterdam", "Madrid", "Lisbon", "Paris", "Berlin"};


        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                WeatherObserverPush observer = new WeatherObserverPush(ID, Subject, tabControl1);
                string Observertag = "Observer push: " + observer.ID;
                listBox1.Items.Add(Observertag);
                ObserverPush newObserverPull = new ObserverPush();
                TabPage tb = new TabPage(Observertag);
                tb.Name = Observertag;
                tabControl1.TabPages.Add(tb);
                tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(newObserverPull);
            }
            else
            {
                WeatherObserverPull observer = new WeatherObserverPull(ID, Subject, tabControl1);
                string Observertag = "Observer pull: " + observer.ID;
                listBox1.Items.Add(Observertag);
                ObserverPull newObserverPull = new ObserverPull();
                TabPage tb = new TabPage(Observertag);
                tb.Name = Observertag;
                tabControl1.TabPages.Add(tb);
                tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(newObserverPull);
            }
            ID++;
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int obs = listBox1.Items.IndexOf(listBox1.SelectedItem);
                if (listBox1.SelectedItem.ToString().Contains("push"))
                {
                    Intefaces.ObserverPush el = Subject.FindObserverPush(obs);
                    Subject.Detach(el);
                }
                else
                {
                    Intefaces.ObserverPull el = Subject.FindObserverPull(obs);
                    Subject.Detach(el);
                }
                listBox1.Items.RemoveAt(obs);
                tabControl1.TabPages.RemoveAt(obs);
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            Subject.SetTemperature(rand.Next(15, 30));
            Subject.SetLocation(listLocations.ElementAt(rand.Next(0, 5)));
            Subject.Notify();
            counter++;
            label1.Text = counter.ToString();
        }
    }
}
