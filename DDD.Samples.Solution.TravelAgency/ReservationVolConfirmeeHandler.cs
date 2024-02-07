using DDD.Samples.Solution.TravelAgency.Adapters;
using DDD.Samples.Solution.TravelAgency.Core;
using DDD.Samples.Solution.TravelAgency.DomainEvents;
using DDD.Samples.Solution.TravelAgency.LocationVehicule;

namespace DDD.Samples.Solution.TravelAgency;

public class ReservationVolConfirmeeHandler : DomainEventListener<ReservationFinalisee>
{
    private readonly ILocationVoitureRepository locationVoitureRepository;
    private readonly LocationVoitureFactory locationVoitureFactory;

    public ReservationVolConfirmeeHandler()
    {
        locationVoitureRepository = new FakeLocationVoitureRepository();
        locationVoitureFactory = new FakeLocationVoitureFactory();
    }

    public async Task Handle(ReservationFinalisee domainEvent)
    {
        // Simuler la logique pour déterminer les détails de la voiture et le tarif basé sur la destination et les dates
        var detailsVoiture = new DetailsVoiture("Toyota", "Corolla");
        var periodeLocation = new PeriodeLocation(domainEvent.DateDebut.AddDays(1), domainEvent.DateFin.AddDays(-1));
        var tarifLocation = new TarifLocation(50m); // Tarif exemple par jour

        // Utiliser la factory pour créer l'agrégat de location de voiture
        var locationVoiture = locationVoitureFactory.CreerLocationVoiture(detailsVoiture, periodeLocation, tarifLocation);

        // Persister la nouvelle location de voiture
        await locationVoitureRepository.AjouterAsync(locationVoiture);

        Console.WriteLine($"Location de voiture proposée pour la réservation {domainEvent.Id} du {periodeLocation.DateDebut} au {periodeLocation.DateFin}.");
    }
}