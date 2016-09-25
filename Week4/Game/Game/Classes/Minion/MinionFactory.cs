using Game.Interface;

namespace Game.Classes.Minion
{
    class MinionFactory : IFactory
    {
        public IFigure createFigure(Form1 form)
        {
            return new Minion(form);
        }

        public IHouse createHouse(Form1 form)
        {
            return new HouseMinion(form);
        }

        public IFood createFood(Form1 form)
        {
            return new FoodMinion(form);
        }

        public IFemale createFemale(Form1 form)
        {
            return new MinionFemale(form);
        }
    }
}
