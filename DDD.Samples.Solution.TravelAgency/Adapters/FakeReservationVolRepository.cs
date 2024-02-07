using DDD.Samples.Solution.TravelAgency.ReservationVol;

namespace DDD.Samples.Solution.TravelAgency.Adapters;

public class FakeReservationVolRepository: ReservationVolRepository
{
    private readonly List<ReservationVol.ReservationVol> _reservations = new List<ReservationVol.ReservationVol>();

    public void Ajouter(ReservationVol.ReservationVol reservationVol)
    {
        _reservations.Add(reservationVol);
    }

    public ReservationVol.ReservationVol ObtenirParId(Guid id) => _reservations.First(r => r.Id == id);
}