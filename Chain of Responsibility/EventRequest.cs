using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public class EventRequest
    {
        public string EventType { get; set; }
        public string Message { get; set; }

        public EventRequest(string eventType, string message)
        {
            EventType = eventType;
            Message = message;
        }
    }
}
