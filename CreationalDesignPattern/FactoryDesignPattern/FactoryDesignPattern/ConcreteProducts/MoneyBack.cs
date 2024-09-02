using FactoryDesignPattern.Contracts;

namespace FactoryDesignPattern.ConcreteProducts
{
    // step 2 : create  supclass  and implements SupperClass 
    internal class MoneyBack : CreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }
        public int GetCreditLimit()
        {
            return 15000;
        }
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}
