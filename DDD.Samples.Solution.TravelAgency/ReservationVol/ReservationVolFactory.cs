namespace DDD.Samples.Solution.TravelAgency.ReservationVol;

public interface ReservationVolFactory
{
    ReservationVol CreerReservationVol(Itineraire itineraire, TarifVol tarif);
}