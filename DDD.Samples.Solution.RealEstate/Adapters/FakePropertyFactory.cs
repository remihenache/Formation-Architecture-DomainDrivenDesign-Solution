using DDD.Samples.Solution.RealEstate.Property;
using DDD.Samples.Solution.RealEstate.ValueObjects;

namespace DDD.Samples.Solution.RealEstate.Adapters;

public class FakePropertyFactory : PropertyFactory
{
    public Property.Property CreateProperty(string address, Money askingPrice)
    {
        // Controle addresse existance and get GPS coordinates
        var propertyId = new PropertyId(Guid.NewGuid());
        return new Property.Property(propertyId, address, askingPrice);
    }
}