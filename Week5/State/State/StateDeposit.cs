using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class StateDeposit:IState
    {
        public StateDeposit()
        { 
        }
        public void goNext(Context ctxt)
        {
            IState s = new StateWithdraw();
            ctxt.setState(s);
        }
    }
}
