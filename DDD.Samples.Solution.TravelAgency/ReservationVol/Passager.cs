namespace DDD.Samples.Solution.TravelAgency.ReservationVol;

public class Passager
{
    public Guid Id { get; private set; }
    public string Nom { get; private set; }
    public string Prenom { get; private set; }

    public Passager(Guid id, string nom, string prenom)
    {
        Id = id == Guid.Empty ? throw new ArgumentException("L'identifiant ne peut pas être vide.") : id;
        Nom = !string.IsNullOrWhiteSpace(nom) ? nom : throw new ArgumentException("Le nom est requis.");
        Prenom = !string.IsNullOrWhiteSpace(prenom) ? prenom : throw new ArgumentException("Le prénom est requis.");
    }
}