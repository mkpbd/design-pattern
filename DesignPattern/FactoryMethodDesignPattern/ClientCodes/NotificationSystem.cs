using FactoryMethodDesignPattern.AllInterfaces;
using FactoryMethodDesignPattern.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.ClientCodes
{
    //Client Code
    public class NotificationSystem
    {
        public void NotifyUser(NotifierFactory factory, string message)
        {
            INotifier notifier = factory.CreateNotifier();
            notifier.SendNotification(message);
        }
    }
}
