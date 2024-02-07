using DDD.Samples.Solution.RealEstate.Property;
using DDD.Samples.Solution.RealEstate.ValueObjects;

namespace DDD.Samples.Solution.RealEstate.Adapters;

public class FakePropertyRepository : IPropertyRepository
{
    private readonly Dictionary<PropertyId, Property.Property> properties = new Dictionary<PropertyId, Property.Property>();

    public Task<Property.Property> FindPropertyFromId(PropertyId id)
    {
        if (properties.TryGetValue(id, out var property))
            return Task.FromResult(property);
        return Task.FromResult<Property.Property>(null);
    }

    public Task SaveProperty(Property.Property property)
    {
        properties[property.Id] = property;
        return Task.CompletedTask;
    }
}