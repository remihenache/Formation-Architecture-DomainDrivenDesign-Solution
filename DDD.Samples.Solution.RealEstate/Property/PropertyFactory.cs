using DDD.Samples.Solution.RealEstate.ValueObjects;

namespace DDD.Samples.Solution.RealEstate.Property;

public interface PropertyFactory
{
    Property CreateProperty(string address, Money askingPrice);
}