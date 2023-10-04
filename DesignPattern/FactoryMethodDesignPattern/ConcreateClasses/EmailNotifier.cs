using FactoryMethodDesignPattern.AllInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.ConcreateClasses
{
    // Concrete Emails
    public class EmailNotifier : INotifier
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending Email: {message}");
            // Actual email sending logic goes here...
        }
    }

}
