using FactoryMethodDesignPattern.AllInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.ConcreateClasses
{
    public class PushNotifier : INotifier
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending Push Notification: {message}");
            // Actual push notification logic goes here...
        }
    }

}
