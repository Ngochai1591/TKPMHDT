using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Order_Manager.StatePattern
{
   class StateContext
    {
        private State state;

        public void setState(State state)
        {
            this.state = state;
        }

        public void applyState()
        {
            this.state.handleRequest();
        }
    }
}
