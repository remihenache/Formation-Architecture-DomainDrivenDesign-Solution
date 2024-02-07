namespace DDD.Samples.Solution.TravelAgency.ReservationVol;

public interface ReservationVolRepository
{
    void Ajouter(ReservationVol reservationVol);
    ReservationVol ObtenirParId(Guid id);
    // D'autres méthodes selon les besoins
}