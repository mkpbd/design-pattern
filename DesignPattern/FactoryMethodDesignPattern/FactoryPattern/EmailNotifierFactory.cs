using FactoryMethodDesignPattern.AllInterfaces;
using FactoryMethodDesignPattern.ConcreateClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.FactoryPattern
{
    //Concrete Creators
    public class EmailNotifierFactory : NotifierFactory
    {
        public override INotifier CreateNotifier()
        {
            return new EmailNotifier();
        }
    }

    public class SMSNotifierFactory : NotifierFactory
    {
        public override INotifier CreateNotifier()
        {
            return new SMSNotifier();
        }
    }

    public class PushNotifierFactory : NotifierFactory
    {
        public override INotifier CreateNotifier()
        {
            return new PushNotifier();
        }
    }
}
