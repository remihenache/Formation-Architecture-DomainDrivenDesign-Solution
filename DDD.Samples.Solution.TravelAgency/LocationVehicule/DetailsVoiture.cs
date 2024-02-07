namespace DDD.Samples.Solution.TravelAgency.LocationVehicule;

public class DetailsVoiture
{
    public string Marque { get; private set; }
    public string Modele { get; private set; }

    public DetailsVoiture(string marque, string modele)
    {
        Marque = marque ?? throw new ArgumentNullException(nameof(marque));
        Modele = modele ?? throw new ArgumentNullException(nameof(modele));
    }
}