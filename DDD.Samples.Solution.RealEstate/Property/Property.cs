using DDD.Samples.Solution.RealEstate.ValueObjects;

namespace DDD.Samples.Solution.RealEstate.Property;

public class Property
{
    public PropertyId Id { get; private set; }
    public string Address { get; private set; }
    public Money AskingPrice { get; private set; }
    private List<Offer> offers = new List<Offer>();
    public IEnumerable<Offer> Offers => offers.AsReadOnly();

    public Property(PropertyId id, string address, Money askingPrice)
    {
        Id = id ?? throw new ArgumentNullException(nameof(id));
        Address = address ?? throw new ArgumentNullException(nameof(address));
        AskingPrice = askingPrice ?? throw new ArgumentNullException(nameof(askingPrice));
    }

    public void AddOffer(Money amount)
    {
        var offer = new Offer(new OfferId(Guid.NewGuid()), amount);
        if (offer == null) throw new ArgumentNullException(nameof(offer));
        offers.Add(offer);
    }

    // Cette méthode pourrait devenir un Domain Service si la logique de sélection d'offre devient plus complexe.
    public void FinalizeTransaction()
    {
        if (!Offers.Any())
            throw new InvalidOperationException("Une transaction ne peut pas être finalisée sans au moins une offre.");

        var highestOffer = Offers.OrderByDescending(o => o.Amount.Amount).First();
        highestOffer.Accept();
        // Émettre ici un événement de domaine, par exemple, TransactionFinalized
    }
}