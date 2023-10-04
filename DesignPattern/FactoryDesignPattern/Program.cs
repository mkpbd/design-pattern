using FactoryDesignPattern.FactoryClasses;
using FactoryDesignPattern.ProductFactory;

namespace FactoryDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CreditCardFactory creditCard = new CreditCardFactory();
           var platinum =  creditCard.GetCreditCard("Platinum");

            Console.WriteLine(platinum.GetCreditLimit());


            // ফ্যাক্টরি ক্লাস থেকে নতুন প্রোডাক্ট তৈরি করতে পারেন
            ProductForFactory factory = new ProductForFactory();
            Product product1 = factory.CreateProduct("ল্যাপটপ", 800.00);
            Product product2 = factory.CreateProduct("মোবাইল ফোন", 300.00);

            // তৈরি প্রোডাক্টের তথ্য দেখানো
            Console.WriteLine($"প্রোডাক্ট 1: {product1.Name}, মূল্য: ${product1.Price}");
            Console.WriteLine($"প্রোডাক্ট 2: {product2.Name}, মূল্য: ${product2.Price}");
        }
    }
}