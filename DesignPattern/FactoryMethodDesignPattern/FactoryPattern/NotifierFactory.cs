using FactoryMethodDesignPattern.AllInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.FactoryPattern
{
    //Creator (Abstract Class)
    public abstract class NotifierFactory
    {
        public abstract INotifier CreateNotifier();
    }
}
