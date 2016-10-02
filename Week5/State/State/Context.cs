using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Context
    {
        private IState current;
        public Form1 Form;

        public Context(Form1 form)
        {
            Form = form;
        }

        public void setState(IState state)
        {
            current = state;
        }

        public IState getState()
        {
            return current;
        }

        public void goNext()
        {
            current.goNext(this);
        }
    }
}
