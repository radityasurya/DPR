using System.Windows.Forms;
using Game.Interface;

namespace Game.Classes
{
    public class GenericGame
    {
        public bool GameOver = false;
        public Form1 Form;
        private Timer timer;
        private IFigure figure;
        private IFemale female;
        private IFood food;
        private IHouse house;

        public GenericGame(Form1 form)
        {
            Form = form;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, args) =>
            {
                if (!GameOver)
                {
                    house.Visit();
                }
                if (GameOver)
                {
                    timer.Stop();
                    MessageBox.Show("GameOver! Figure reached the house");
                    female.Sing();
                    figure = null;
                    female = null;
                    food = null;
                    house = null;
                    Form.Controls.Clear();
                }
            };
        }

        public void run(IFactory f)
        {
            figure = f.createFigure(Form);
            female = f.createFemale(Form);
            food = f.createFood(Form);
            house = f.createHouse(Form);
           
            food.Eat();
            
            timer.Start();

            female.Sing();
        }

    }
}
