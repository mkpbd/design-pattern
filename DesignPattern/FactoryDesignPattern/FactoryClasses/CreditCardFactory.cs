using FactoryDesignPattern.FactoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.FactoryClasses
{
    public class CreditCardFactory
    {
        /**
         * 
         *  A factory is an object used for creating other objects. 
         *  In technical terms, we can say that a factory is a class with a method. 
         *  That method will create and return different objects based on the received input parameter.
         * 
         * In simple words, if we have a superclass and n number of subclasses, and based on the data provided, if we have to create and return the object of one of the subclasses, then we need to use the Factory Design Pattern in C#.
         * 
         */


        public ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard creditCard = null;
            if(cardType == "MonyBank")
            {
                creditCard = new MoneyBack();
                return creditCard;
            }
            if(cardType == "Platinum")
            {
                creditCard = new Platinum();
                return creditCard;
            }
            if(cardType == "Titanium")
            {
                creditCard = new Titanium();
                return creditCard;
            }
            return  creditCard;

        }
    }
}
