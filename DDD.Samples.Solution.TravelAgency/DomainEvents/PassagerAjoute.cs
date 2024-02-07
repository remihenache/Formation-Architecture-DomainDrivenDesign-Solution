using DDD.Samples.Solution.TravelAgency.Core;

namespace DDD.Samples.Solution.TravelAgency.DomainEvents;

public class PassagerAjoute : DomainEvent
{
    public Guid Id { get; }
    public string Nom { get; }
    public string Prenom { get; }

    public PassagerAjoute(Guid id, string nom, string prenom)
    {
        Id = id;
        Nom = nom;
        Prenom = prenom;
    }
}