﻿using System.Drawing;
using System.Windows.Forms;
using Game.Interface;
using Game.Properties;

namespace Game.Classes.Smurf
{
    public class FoodSmurf : IFood
    {
        public PictureBox pic;
        private Form1 Form;

        public FoodSmurf() { }
        public FoodSmurf(Form1 form)
        {
            pic = new PictureBox();
            pic.Image = Resources.animated_pizza;
            pic.Enabled = false;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            Form = form;
            pic.Size = new Size(100, 100);
            pic.Location = new Point(300, 450);
            Form.Controls.Add(pic);
        }
        public void Eat()
        {
            pic.Enabled = true;
        }
    }
}
