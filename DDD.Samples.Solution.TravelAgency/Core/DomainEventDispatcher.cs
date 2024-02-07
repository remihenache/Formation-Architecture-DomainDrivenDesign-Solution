namespace DDD.Samples.Solution.TravelAgency.Core;

public interface DomainEventDispatcher
{
    Task Publish<T>(T domainEvent) where T : DomainEvent;
}