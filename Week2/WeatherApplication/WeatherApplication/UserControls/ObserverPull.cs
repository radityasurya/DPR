using System.Windows.Forms;

namespace WeatherApplication.UserControls
{
    public partial class ObserverPull : UserControl
    {
        public ObserverPull()
        {
            InitializeComponent();
        }

        public void SetLabelTemperature(int temp)
        {
            label2.Text = temp.ToString();
        }

        public void SetLabelLocation(string loc)
        {
            label1.Text = loc;
        }
    }
}
