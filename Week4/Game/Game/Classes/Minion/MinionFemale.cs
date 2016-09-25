using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Game.Interface;
using Game.Properties;
using WMPLib;

namespace Game.Classes.Minion
{
    class MinionFemale : IFemale
    {
        private WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
        public PictureBox pic;
        private Form1 Form;

        public MinionFemale(Form1 form)
        {
            pic = new PictureBox
            {
                Image = Resources.MinionFemale,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
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
                wplayer.URL = "Pharrell Williams - Happy.mp3";
                wplayer.controls.play();
            }
        }
    }
}
