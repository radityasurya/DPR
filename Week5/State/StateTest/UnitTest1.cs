using System;
using State;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StateTest
{
    [TestClass]
    public class UnitTest1
    {
        private Context ctxt;

        [TestMethod]
        public void StateChangeTest()
        {
            Form1 form = new Form1();
            ctxt = new Context(form);
            ctxt.setState(new StateDeposit());

            form.CheckState(ctxt);

            Assert.IsInstanceOfType(ctxt.getState(), typeof(IState));     //passes
        }

        [TestMethod]
        public void DepositTest()
        {
            Form1 form = new Form1();
            ctxt = new Context(form);
            ctxt.setState(new StateDeposit());

            form.CheckState(ctxt);

            Assert.IsInstanceOfType(ctxt.getState(), typeof(StateDeposit));     //passes
        }

        [TestMethod]
        public void Withdraw()
        {
            Form1 form = new Form1();
            ctxt = new Context(form);
            ctxt.setState(new StateDeposit());

            form.CheckState(ctxt);
            ctxt.goNext();

            Assert.IsInstanceOfType(ctxt.getState(), typeof(StateWithdraw));     //passes
        }
    }
}
