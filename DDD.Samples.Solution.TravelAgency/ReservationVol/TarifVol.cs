namespace DDD.Samples.Solution.TravelAgency.ReservationVol;

public class TarifVol
{
    public decimal Montant { get; private set; }
    public TarifVol(decimal montant)
    {
        if (montant <= 0)
            throw new ArgumentException("Le montant doit être positif.");
        Montant = montant;
    }
}