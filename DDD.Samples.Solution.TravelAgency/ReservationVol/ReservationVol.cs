using DDD.Samples.Solution.TravelAgency.Core;
using DDD.Samples.Solution.TravelAgency.DomainEvents;

namespace DDD.Samples.Solution.TravelAgency.ReservationVol;

public class ReservationVol
{
    public Guid Id { get; private set; }
    public Itineraire Itineraire { get; private set; }
    public List<Passager> Passagers { get; private set; }
    public TarifVol Tarif { get; private set; }

    public List<DomainEvent> Events { get; private set; }  = new List<DomainEvent>();
    
    public ReservationVol(Guid id, Itineraire itineraire, TarifVol tarif)
    {
        Id = id == Guid.Empty ? throw new ArgumentException("L'identifiant ne peut pas être vide.") : id;
        Itineraire = itineraire ?? throw new ArgumentNullException(nameof(itineraire));
        Tarif = tarif ?? throw new ArgumentNullException(nameof(tarif));
        Passagers = new List<Passager>();
    }

    public void AjouterPassager(Guid id, string nom, string prenom)
    {
        var passager = new Passager(id, nom, prenom);
        if (passager == null) throw new ArgumentNullException(nameof(passager));
        Passagers.Add(passager);
        Events.Add(new PassagerAjoute(id, nom, prenom));
    }
    
    public void FinalizeReservation()
    {
        Events.Add(new ReservationFinalisee(Id, Passagers.Select(p => p.Id).ToList(), Itineraire.DateDepart, Itineraire.DateArrivee));
    }
}