namespace DDD.Samples.Solution.RealEstate.ValueObjects;

public class OfferId
{
    public Guid Value { get; private set; }
        
    public OfferId(Guid value)
    {
        if (value == Guid.Empty)
            throw new ArgumentException("L'identifiant de l'offre ne peut pas être vide.", nameof(value));
        Value = value;
    }
}