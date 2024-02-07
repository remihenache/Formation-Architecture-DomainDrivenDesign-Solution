namespace DDD.Samples.Solution.RealEstate.ValueObjects;

public class Money
{
    public decimal Amount { get; private set; }
    public string Currency { get; private set; }
        
    public Money(decimal amount, string currency = "EUR")
    {
        if (amount <= 0)
            throw new ArgumentException("Le montant doit être supérieur à 0.", nameof(amount));
        Amount = amount;
        Currency = currency ?? throw new ArgumentNullException(nameof(currency));
    }
}