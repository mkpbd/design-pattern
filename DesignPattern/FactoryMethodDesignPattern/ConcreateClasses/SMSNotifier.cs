using FactoryMethodDesignPattern.AllInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.ConcreateClasses
{
    public class SMSNotifier : INotifier
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
            // Actual SMS sending logic goes here...
        }
    }
}
