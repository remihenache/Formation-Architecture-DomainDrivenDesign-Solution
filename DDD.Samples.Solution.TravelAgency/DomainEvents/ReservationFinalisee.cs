using DDD.Samples.Solution.TravelAgency.Core;

namespace DDD.Samples.Solution.TravelAgency.DomainEvents;

public class ReservationFinalisee : DomainEvent
{
    public Guid Id { get; }
    public List<Guid> List { get; }
    public DateTime DateDebut { get; }
    public DateTime DateFin { get; }

    public ReservationFinalisee(Guid id, List<Guid> list, DateTime dateDebut, DateTime dateFin)
    {
        Id = id;
        List = list;
        DateDebut = dateDebut;
        DateFin = dateFin;
    }
}