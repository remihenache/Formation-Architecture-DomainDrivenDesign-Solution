namespace DDD.Samples.Solution.TravelAgency.LocationVehicule;

public class LocationVoiture
{
    public Guid Id { get; private set; }
    public DetailsVoiture Voiture { get; private set; }
    public PeriodeLocation Periode { get; private set; }
    public TarifLocation Tarif { get; private set; }

    public LocationVoiture(Guid id, DetailsVoiture voiture, PeriodeLocation periode, TarifLocation tarif)
    {
        Id = id == Guid.Empty ? throw new ArgumentException("L'identifiant ne peut pas être vide.") : id;
        Voiture = voiture ?? throw new ArgumentNullException(nameof(voiture));
        Periode = periode ?? throw new ArgumentNullException(nameof(periode));
        Tarif = tarif ?? throw new ArgumentNullException(nameof(tarif));
    }
}