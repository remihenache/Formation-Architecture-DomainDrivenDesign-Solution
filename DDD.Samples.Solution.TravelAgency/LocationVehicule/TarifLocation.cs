namespace DDD.Samples.Solution.TravelAgency.LocationVehicule;

public class TarifLocation
{
    public decimal PrixParJour { get; private set; }

    public TarifLocation(decimal prixParJour)
    {
        if (prixParJour <= 0)
            throw new ArgumentException("Le prix par jour doit être positif.");
        PrixParJour = prixParJour;
    }
}