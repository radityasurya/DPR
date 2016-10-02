using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class StateWithdraw:IState
    {
 
        public StateWithdraw()
        {
        }
        public void goNext(Context ctxt)
        {
            IState s = new StateDeposit();
            ctxt.setState(s);
        }
    }
}
