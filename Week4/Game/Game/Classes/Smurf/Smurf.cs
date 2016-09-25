using System.Drawing;
using System.Windows.Forms;
using Game.Interface;
using Game.Properties;

namespace Game.Classes.Smurf
{
    class Smurf : IFigure
    {
        private PictureBox pic;
        private Form1 Form;
        private Timer timer;
        private int X = 0;

        public Smurf(Form1 form)
        {
            pic = new PictureBox();
            pic.Image = Resources.Smurf;
            Size size = new Size(200, 200);
            pic.Size = size;
            pic.Name = "Smurf";
            pic.Location = new Point(0, 100);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            Form = form;
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
                X += 80;
            }
            else
            {
                timer.Stop();
            }
            
        }
    }
}
