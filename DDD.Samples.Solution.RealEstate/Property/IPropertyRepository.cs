using DDD.Samples.Solution.RealEstate.ValueObjects;

namespace DDD.Samples.Solution.RealEstate.Property;

public interface IPropertyRepository
{
    Task<Property> FindPropertyFromId(PropertyId id);
    Task SaveProperty(Property property);
}