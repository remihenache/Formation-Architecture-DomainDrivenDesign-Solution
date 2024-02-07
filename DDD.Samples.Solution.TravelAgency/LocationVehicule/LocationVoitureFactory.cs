namespace DDD.Samples.Solution.TravelAgency.LocationVehicule;

internal interface LocationVoitureFactory
{
    LocationVoiture CreerLocationVoiture(DetailsVoiture detailsVoiture, PeriodeLocation periodeLocation, TarifLocation tarifLocation);
}