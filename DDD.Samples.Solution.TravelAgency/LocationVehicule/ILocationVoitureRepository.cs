namespace DDD.Samples.Solution.TravelAgency.LocationVehicule;

internal interface ILocationVoitureRepository
{
    Task AjouterAsync(LocationVoiture locationVoiture);
}