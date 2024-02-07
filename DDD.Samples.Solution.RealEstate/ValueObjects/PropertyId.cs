namespace DDD.Samples.Solution.RealEstate.ValueObjects;

public class PropertyId
{
    public Guid Value { get; private set; }
        
    public PropertyId(Guid value)
    {
        if (value == Guid.Empty)
            throw new ArgumentException("L'identifiant de la propriété ne peut pas être vide.", nameof(value));
        Value = value;
    }
}