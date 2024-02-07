using DDD.Samples.Solution.TravelAgency.LocationVehicule;

namespace DDD.Samples.Solution.TravelAgency.Adapters;

public class FakeLocationVoitureFactory : LocationVoitureFactory
{
    public LocationVoiture CreerLocationVoiture(DetailsVoiture detailsVoiture, PeriodeLocation periodeLocation,
        TarifLocation tarifLocation)
    {
        // Check vehicle availability
        return new LocationVoiture(Guid.NewGuid(),  detailsVoiture, periodeLocation, tarifLocation);
    }
}