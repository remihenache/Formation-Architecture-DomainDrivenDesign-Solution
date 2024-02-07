using DDD.Samples.Solution.TravelAgency.Adapters;
using DDD.Samples.Solution.TravelAgency.Core;
using DDD.Samples.Solution.TravelAgency.ReservationVol;

namespace DDD.Samples.Solution.TravelAgency;

class Program
{
    static async Task Main(string[] args)
    {
        var dispatcher = new FakeDomainEventDispatcher();
            
        // use case reserver un vol
        var repository = new FakeReservationVolRepository();
        var reservationFactory = new FakeReservationVolFactory();
        var reservationVol = reservationFactory.CreerReservationVol(
            new Itineraire(
                "Paris", 
                "Tokyo", 
                DateTime.Now.AddDays(1), 
                DateTime.Now.AddDays(7)), 
            new TarifVol(900));
            
        reservationVol.AjouterPassager(Guid.NewGuid(), "Doe", "John");
        reservationVol.AjouterPassager(Guid.NewGuid(), "Doe", "Jane");
        reservationVol.FinalizeReservation();
        repository.Ajouter(reservationVol);
            
        // si la reservation est confirmée, emettre le/les événements de domaine correspondants
        foreach (DomainEvent domainEvent in reservationVol.Events)
        {
            await dispatcher.Publish(domainEvent);
        }
    }
}