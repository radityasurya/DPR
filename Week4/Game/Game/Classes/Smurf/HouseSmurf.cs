using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Game.Interface;
using Game.Properties;

namespace Game.Classes.Smurf
{
    public class HouseSmurf : IHouse
    {
        public PictureBox pic;
        private Form1 Form;

        public HouseSmurf() { }
        public HouseSmurf(Form1 form)
        {
            pic = new PictureBox();
            pic.Image = Resources.SmurfHouse;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            Form = form;
            pic.Size = new Size(200, 200);
            pic.Location = new Point(Form.Size.Width - pic.Size.Width - 20, 100);
            Form.Controls.Add(pic);
        }
        public void Visit()
        {
            PictureBox pb = Form.Controls.Find("Smurf", true).FirstOrDefault() as PictureBox;
            if (pb?.Location.X >= pic.Location.X)
            {
                Form.game.GameOver = true;
            }
        }
    }
}
