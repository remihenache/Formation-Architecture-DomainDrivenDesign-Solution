using DDD.Samples.Solution.TravelAgency.ReservationVol;

namespace DDD.Samples.Solution.TravelAgency.Adapters;

public class FakeReservationVolFactory: ReservationVolFactory
{
    public ReservationVol.ReservationVol CreerReservationVol(Itineraire itineraire, TarifVol tarif)
    {
        return new ReservationVol.ReservationVol(Guid.NewGuid(), itineraire, tarif);
    }
}