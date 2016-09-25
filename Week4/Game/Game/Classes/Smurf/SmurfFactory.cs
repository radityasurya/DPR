using Game.Interface;

namespace Game.Classes.Smurf
{
    class SmurfFactory : IFactory
    {
        public IFigure createFigure(Form1 form)
        {
            return new Smurf(form);
        }

        public IHouse createHouse(Form1 form)
        {
            return new HouseSmurf(form);
        }

        public IFood createFood(Form1 form)
        {
            return new FoodSmurf(form);
        }

        public IFemale createFemale(Form1 form)
        {
            return new Smurfin(form);
        }
    }
}
