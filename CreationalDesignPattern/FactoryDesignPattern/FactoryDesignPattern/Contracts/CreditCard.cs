namespace FactoryDesignPattern.Contracts
{

    public interface CreditCard
    {
        // step 1: create interface 
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
