using FactoryDesignPattern.FactoryClasses;

namespace FactoryDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CreditCardFactory creditCard = new CreditCardFactory();
           var platinum =  creditCard.GetCreditCard("Platinum");

            Console.WriteLine(platinum.GetCreditLimit());
        }
    }
}