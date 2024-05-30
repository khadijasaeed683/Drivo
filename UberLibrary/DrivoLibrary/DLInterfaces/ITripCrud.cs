using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UberNew;

namespace Drivo
{
    public interface ITripCrud
    {
        bool StoreTrip(Trip tr, Rider rider);

        List<Trip> LoadAllTripsToList();
        List<Trip> LoadActiveTripsToList();

        List<Trip> LoadActiveTripsForRiderToList(int riderId);
        List<Trip> LoadInActiveTripsToList();
        List<Trip> GetTripsForRider(string riderPhoneNumber);
        void UpdateRideStatus(int rideId);
        void DeleteRide(int rideId);
        bool IsRideDeleted(int rideId );
        List<Trip> GetAllPendingRides();
        void UpdateArrivalMinutes(int TripId, int minutes);
        void CompleteTrip(int TripId); //new
        List<Trip> LoadInCompleteTripsForDriverToList(string driverIdcard);     //new

        void UpdateRideStatusToAccepted(int rideId, string driverPhone, string driverIdCard);
        double GetDistance(string loc1, string loc2);
         List<string> LoadAllLocations();




    }
}
