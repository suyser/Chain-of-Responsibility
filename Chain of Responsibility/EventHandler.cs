using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public abstract class EventHandler
    {
        protected EventHandler _nextHandler;

        public void SetNextHandler(EventHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void HandleRequest(EventRequest request);
    }
}
