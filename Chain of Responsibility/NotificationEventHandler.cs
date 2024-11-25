using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public class NotificationEventHandler : EventHandler
    {
        public override void HandleRequest(EventRequest request)
        {
            if (request.EventType == "Notification")
            {
                Console.WriteLine($"Обработано событие типа '{request.EventType}': {request.Message}");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }

        public static implicit operator System.EventHandler(NotificationEventHandler v)
        {
            throw new NotImplementedException();
        }
    }
}
