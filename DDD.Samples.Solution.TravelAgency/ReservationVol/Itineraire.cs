namespace DDD.Samples.Solution.TravelAgency.ReservationVol;

public class Itineraire
{
    public string Depart { get; private set; }
    public string Destination { get; private set; }
    public DateTime DateDepart { get; private set; }
    public DateTime DateArrivee { get; private set; }

    public Itineraire(string depart, string destination, DateTime dateDepart, DateTime dateArrivee)
    {
        if (string.IsNullOrWhiteSpace(depart) || string.IsNullOrWhiteSpace(destination))
            throw new ArgumentException("Les lieux de départ et de destination sont requis.");
        if (dateArrivee <= dateDepart)
            throw new ArgumentException("La date d'arrivée doit être après la date de départ.");

        Depart = depart;
        Destination = destination;
        DateDepart = dateDepart;
        DateArrivee = dateArrivee;
    }
}