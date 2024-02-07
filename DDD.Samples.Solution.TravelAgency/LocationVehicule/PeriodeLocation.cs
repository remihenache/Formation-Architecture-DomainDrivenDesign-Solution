namespace DDD.Samples.Solution.TravelAgency.LocationVehicule;

public class PeriodeLocation
{
    public DateTime DateDebut { get; private set; }
    public DateTime DateFin { get; private set; }

    public PeriodeLocation(DateTime dateDebut, DateTime dateFin)
    {
        if (dateFin <= dateDebut)
            throw new ArgumentException("La date de fin doit être après la date de début.");
        DateDebut = dateDebut;
        DateFin = dateFin;
    }
}