using Chain_of_Responsibility;

public class Program
{
    public static void Main(string[] args)
    {
        Chain_of_Responsibility.EventHandler notificationHandler = new NotificationEventHandler();
        Chain_of_Responsibility.EventHandler errorHandler = new Chain_of_Responsibility.ErrorEventHandler();
        Chain_of_Responsibility.EventHandler userRequestHandler = new UserRequestEventHandler();

        notificationHandler.SetNextHandler(errorHandler);
        errorHandler.SetNextHandler(userRequestHandler);

        EventRequest notificationRequest = new EventRequest("Notification", "Новое уведомление");
        EventRequest errorRequest = new EventRequest("Error", "Ошибка на сервере");
        EventRequest userRequest = new EventRequest("UserRequest", "Запрос от пользователя");

        Console.WriteLine("Обработка запроса о уведомлении:");
        notificationHandler.HandleRequest(notificationRequest);  // Без присваивания

        Console.WriteLine("\nОбработка запроса об ошибке:");
        notificationHandler.HandleRequest(errorRequest);  // Без присваивания

        Console.WriteLine("\nОбработка запроса от пользователя:");
        notificationHandler.HandleRequest(userRequest);  // Без присваивания
    }
}

