## What is Factory Design Pattern in C#?

According to Gang of Four (GoF), a factory is an object used to create other objects.
In technical terms, a factory is a class with a method. That method creates and returns different objects based on the received input parameter.

We are going to develop an application for showing Credit Card Details. As you can see, we have three credit card classes: MoneyBack, Titanium, and Platinum. These three classes are the subclasses of the CreditCard superclass or, you can say, super interface. The CreditCard superclass or super interface has three methods: GetCardType, GetCreditLimit, and GetAnnualCharge. The subclasses, MoneyBack, Titanium, and Platinum, have implemented the above three methods of the CreditCard.

![1725197723028](https://file+.vscode-resource.vscode-cdn.net/g%3A/Practices/design-pattern/CreationalDesignPattern/FactoryDesignPattern/image/readme/1725197723028.png)

We are required to ask the user to select the credit card. Once the user selects the credit card, we need to display the required information about that selected credit card. Let us first discuss achieving this without using the Factory Design Pattern in C#. Then, we will discuss the problems, and finally, we will create the same application using the Factory Design Pattern in C#.


##### **Factory Design Pattern Implementation in C#:**

According to the definition of the Factory Design Pattern, the Pattern creates an object without exposing the object creation logic to the client, and the client refers to the newly created object using a common interface.

Please have a look at the following image. Our factory class is responsible for creating and returning the appropriate Product (i.e., MoneyBack, Titanium, and Platinum) object. As you can see, this class has one static method, i.e., GetCreditcard, and this method takes one input parameter and, based on the parameter value it will create one of the credit card (i.e., MoneyBack, Platinum, and Titanium) objects and store that object in the superclass (CrditCard) reference variable and finally return that superclass reference variable to the caller of this method i.e. to the client or you can say in our example it is the Main method of the Program class.


![1725197774838](image/readme/1725197774838.png)

Now, the client needs to get the object through CreditCardFactory. For example, if the client wants to create an instance of a Platinum card, he/she needs to do something like the below. As you can see, he/she needs to pass the Credit card type to the GetCreditcard method of the CreditCardFactory class. Now, the GetCreditcard() method will create a Platinum class instance and return that instance to the client.


![1725197805921](image/readme/1725197805921.png)


##### **Step 1: Create the Abstract Product or Product Interface (CreditCard)** 

```
// CreditCard.cs
namespace FactoryDesignPattern
{
    public interface CreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
```


##### **Step 2: Creating Product Classes (MoneyBack, Titanium, and Platinum)**

we have three Credit cards. So, we need to create three classes by implementing the CreditCard Interface and providing implementation to all three CreditCard methods.

```
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

```



##### **Step 3: Creating Factory Class**


Create a class file named **CreditCardfactory.cs** and copy and paste the following. This class contains the logic to create and initialize the appropriate object and returns that object based on some condition. As you can see, this class contains one static method. That static method takes one string parameter, and based on the parameter value, it will create and return the appropriate product instance (MoneyBack, Titanium, and Platinum) to the client.



using FactoryDesignPattern.ConcreteProducts;
using FactoryDesignPattern.Contracts;

namespace FactoryDesignPattern
{
    internal class CreditCardFactory
    {
        public static CreditCard GetCreditCard(string cardType)
        {
            CreditCard cardDetails = null;

    if (cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }

    return cardDetails;
        }
    }
}


##### **Step 3: Client Code (Main Method)**



using FactoryDesignPattern.Contracts;

namespace FactoryDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");

    if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }
}
