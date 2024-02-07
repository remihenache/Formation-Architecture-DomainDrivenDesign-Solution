namespace DDD.Samples.Solution.TravelAgency.Core;

public interface DomainEventListener<T> where T : DomainEvent
{
    Task Handle(T domainEvent);
}