using DDD.Samples.Solution.TravelAgency.LocationVehicule;

namespace DDD.Samples.Solution.TravelAgency.Adapters;

public class FakeLocationVoitureRepository : ILocationVoitureRepository
{
    public async Task AjouterAsync(LocationVoiture locationVoiture)
    {
        await Task.CompletedTask;
    }
}