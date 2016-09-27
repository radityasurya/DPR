using System;
using System.Windows.Forms;
using Game.Classes;
using Game.Classes.Minion;
using Game.Classes.Smurf;
using Game.Interface;

namespace Game
{
    public partial class Form1 : Form
    {
        public IFactory factory;
        public GenericGame game;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Smurf");
            comboBox1.Items.Add("Minion");
            comboBox1.SelectedIndex = 0;
            game = new GenericGame(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedGame = comboBox1.Text;
            switch (selectedGame)
            {
                case "Smurf":
                    factory = new SmurfFactory();
                    break;
                case "Minion":
                    factory = new MinionFactory();
                    break;
                default:
                    factory = new SmurfFactory();
                    break;
            }
            Controls.Clear();
            game.run(factory);
        }
    }
}
