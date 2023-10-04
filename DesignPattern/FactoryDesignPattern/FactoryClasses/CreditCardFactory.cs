using FactoryDesignPattern.FactoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.FactoryClasses
{
    internal class CreditCardFactory
    {

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
