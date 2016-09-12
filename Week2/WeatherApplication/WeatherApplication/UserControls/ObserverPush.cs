using System.Windows.Forms;

namespace WeatherApplication.UserControls
{
    public partial class ObserverPush : UserControl
    {
        public ObserverPush()
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
