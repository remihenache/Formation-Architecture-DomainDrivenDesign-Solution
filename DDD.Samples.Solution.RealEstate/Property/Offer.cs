using DDD.Samples.Solution.RealEstate.ValueObjects;

namespace DDD.Samples.Solution.RealEstate.Property;

public class Offer
{
    public OfferId Id { get; private set; }
    public Money Amount { get; private set; }
    public DateTime OfferDate { get; private set; }
    public bool IsAccepted { get; private set; }

    internal Offer(OfferId id, Money amount)
    {
        Id = id ?? throw new ArgumentNullException(nameof(id));
        Amount = amount ?? throw new ArgumentNullException(nameof(amount));
        OfferDate = DateTime.Now;
        IsAccepted = false;
    }

    public void Accept()
    {
        IsAccepted = true;
        // Émettre ici un événement de domaine, par exemple, OfferAccepted
    }
}