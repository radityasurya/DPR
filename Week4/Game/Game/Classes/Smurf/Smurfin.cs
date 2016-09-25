using System.Drawing;
using System.Windows.Forms;
using Game.Interface;
using Game.Properties;
using WMPLib;

namespace Game.Classes.Smurf
{
    class Smurfin : IFemale
    {
        public PictureBox pic;
        private Form1 Form;
        private WindowsMediaPlayer wplayer = new WindowsMediaPlayer();

        public Smurfin(Form1 form)
        {
            pic = new PictureBox();
            pic.Image = Resources.Smurffette;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            Form = form;
            pic.Size = new Size(200, 200);
            pic.Location = new Point(10, 350);
            Form.Controls.Add(pic);
        }
        public void Sing()
        {
            if (wplayer.playState == WMPPlayState.wmppsPlaying)
            {
                wplayer.controls.stop();
            }
            else
            {
                wplayer.URL = @"The Smurfs Theme Song La La La.mp3";
                wplayer.controls.play();
            }
        
        }
    }
}
