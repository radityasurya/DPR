using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherApplication.Classes;
using System.Collections.Generic;
using WeatherApplication.UserControls;
using System.Windows.Forms;

namespace WeatherApplication_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ObserverTest()
        {
            WeatherSubject Subject = new WeatherSubject();
            int ID = 0;
            int counter = 0;

            TabControl tabControl1 = new TabControl();

            WeatherObserverPush observer = new WeatherObserverPush(ID, Subject, tabControl1);
            ObserverPush newObserverPull = new ObserverPush();

            Subject.SetTemperature(99);
            Subject.SetLocation("Eindhoven");
            Subject.Notify();

            Assert.AreEqual("Eindhoven", Subject.GetWeather().Key);
            Assert.AreEqual(99, Subject.GetWeather().Value);

        }
    }

}