namespace Game.Interface
{
    public interface IFactory
    {
        IFigure createFigure(Form1 form);
        IHouse createHouse(Form1 form);
        IFood createFood(Form1 form);
        IFemale createFemale(Form1 form);

    }
}
