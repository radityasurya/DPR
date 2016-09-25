using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game.Interface;
using Game.Properties;

namespace Game.Classes.Minion
{
    class Minion : IFigure
    {
        private PictureBox pic;
        private Form1 Form;
        private Timer timer;
        private int X;

        public Minion(Form1 form)
        {
            pic = new PictureBox();
            pic.Image = Resources.minion;
            Size size = new Size(200, 200);
            pic.Size = size;
            pic.Name = "Minion";
            pic.Location = new Point(0, 100);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            Form = form;
            Form.Controls.Add(pic);
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, args) =>
            {
                pic.Location = new Point(X, 100);
                Move();
                Form.Controls.Add(pic);
            };
            timer.Start();
        }

        public void Move()
        {
            if (X < (Form.Size.Width - pic.Size.Width))
            {
                X += 50;
            }
            else
            {
                timer.Stop();
            }
            
        }
    }
}
