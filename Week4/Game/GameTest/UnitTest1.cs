using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Classes;
using Game.Classes.Minion;
using Game.Classes.Smurf;
using Game.Interface;
using System.Windows.Forms;

namespace GameTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GameTest()
        {
            Form form = new Form();

            GenericGame game = new GenericGame();
            Assert.IsInstanceOfType(game, typeof(GenericGame));     //passes

            IFactory SmurfFactory = new SmurfFactory();
            Assert.IsInstanceOfType(SmurfFactory, typeof(SmurfFactory));     //passes

            IFactory MinionFactory = new MinionFactory();
            Assert.IsInstanceOfType(MinionFactory, typeof(MinionFactory));

            IFigure SFigure = new Smurf();
            IHouse SHouse = new HouseSmurf();
            IFemale SFemale = new Smurfin();
            IFood SFood = new FoodSmurf();
            Assert.IsInstanceOfType(SFigure, typeof(IFigure));     //passes
            Assert.IsInstanceOfType(SHouse, typeof(IHouse));     //passes
            Assert.IsInstanceOfType(SFemale, typeof(IFemale));     //passes
            Assert.IsInstanceOfType(SFood, typeof(IFood));     //passes

            IFigure MFigure = new Minion();
            IHouse MHouse = new HouseMinion();
            IFemale MFemale = new MinionFemale();
            IFood MFood = new FoodMinion();
            Assert.IsInstanceOfType(MFigure, typeof(IFigure));     //passes
            Assert.IsInstanceOfType(MHouse, typeof(IHouse));     //passes
            Assert.IsInstanceOfType(MFemale, typeof(IFemale));     //passes
            Assert.IsInstanceOfType(MFood, typeof(IFood));     //passes





        }

    }
}
