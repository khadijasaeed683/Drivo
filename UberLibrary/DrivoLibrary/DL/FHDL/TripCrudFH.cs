using System;
using System.Collections.Generic;
using System.IO;

namespace Drivo
{
    public class TripCrudFH : ITripCrud
    {
        private static string filePath = Utils.GetTripFilePath();


        private static int nextTripId = 1; // Next available trip ID
        static TripCrudFH instance;
        public static TripCrudFH GetInstance()
        {
            if (instance == null)
            {
                instance = new TripCrudFH();
            }


            return instance;

        }
       
        public TripCrudFH()
        {
            // Initialize nextTripId by reading the file and finding the maximum trip ID
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        int tripId = int.Parse(parts[0]);
                        nextTripId = Math.Max(nextTripId, tripId + 1);
                    }
                }
            }
        }

        public bool StoreTrip(Trip tr, Rider rider)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    // Format the trip data as: TripId,PickupLocation,DropoffLocation,Fare,IsActive,IsDeleted,RiderId
                    string tripData = $"{nextTripId++},{tr.getPickupLocation()},{tr.getDropoffLocation()},{tr.getFare()},true,false,{rider.getID()}";
                    writer.WriteLine(tripData);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error storing trip: {ex.Message}");
                return false;
            }
        }

        public List<Trip> LoadAllTripsToList()
        {
            List<Trip> trips = new List<Trip>();
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        int tripId = int.Parse(parts[0]);
                        string pickupLocation = parts[1];
                        string dropoffLocation = parts[2];
                        double fare = double.Parse(parts[3]);
                        bool isActive = bool.Parse(parts[4]);
                        // Skip deleted trips
                        if (!bool.Parse(parts[5]))
                        {
                            int riderId = int.Parse(parts[6]);
                            // Assuming you have a method to retrieve Rider object by ID
                            RiderCrudFH riderc = new RiderCrudFH();
                            Rider rider = riderc.SearchRiderWithId(riderId); // Implement this method
                            Trip trip = new Trip(pickupLocation, dropoffLocation, fare, isActive, tripId);
                            trips.Add(trip);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading trips: {ex.Message}");
            }
            return trips;
        }
        public List<Trip> LoadActiveTripsToList()
        {
            List<Trip> trips = new List<Trip>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        string pickupLocation = parts[1];
                        string dropoffLocation = parts[2];
                        double fare = double.Parse(parts[3]);
                        bool isActive = bool.Parse(parts[4]);
                        bool isCompleted = bool.Parse(parts[5]);
                        bool isDeleted = bool.Parse(parts[6]);
                        if (isActive && !isCompleted && !isDeleted)
                        {
                            Trip trip = new Trip(pickupLocation, dropoffLocation, fare);
                            trips.Add(trip);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading active trips: {ex.Message}");
            }

            return trips;
        }

        public List<Trip> LoadActiveTripsForRiderToList(int riderId)
        {
            List<Trip> trips = new List<Trip>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        string pickupLocation = parts[1];
                        string dropoffLocation = parts[2];
                        double fare = double.Parse(parts[3]);
                        bool isActive = bool.Parse(parts[4]);
                        bool isDeleted = bool.Parse(parts[6]);
                        int tripRiderId = int.Parse(parts[7]);
                        int tripId = int.Parse(parts[0]);
                        if (isActive && !isDeleted && tripRiderId == riderId)
                        {
                            Trip trip = new Trip(pickupLocation, dropoffLocation, fare, tripId);
                            trips.Add(trip);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading active trips for rider: {ex.Message}");
            }

            return trips;
        }

        public List<Trip> LoadInActiveTripsToList()
        {
            List<Trip> trips = new List<Trip>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        string pickupLocation = parts[1];
                        string dropoffLocation = parts[2];
                        double fare = double.Parse(parts[3]);
                        bool isCompleted = bool.Parse(parts[5]);
                        bool isDeleted = bool.Parse(parts[6]);
                        int tripId = int.Parse(parts[0]);
                        if (!isCompleted || isDeleted)
                        {
                            Trip trip = new Trip(pickupLocation, dropoffLocation, fare, tripId);
                            trips.Add(trip);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading inactive trips: {ex.Message}");
            }

            return trips;
        }
        public List<Trip> LoadInActiveTripsForRiderToList(int riderId)
        {
            List<Trip> trips = new List<Trip>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        string pickupLocation = parts[1];
                        string dropoffLocation = parts[2];
                        double fare = double.Parse(parts[3]);
                        bool isDeleted = bool.Parse(parts[6]);
                        int tripRiderId = int.Parse(parts[7]);
                        int tripId = int.Parse(parts[0]);
                        if (isDeleted && tripRiderId == riderId)
                        {
                            Trip trip = new Trip(pickupLocation, dropoffLocation, fare, tripId);
                            trips.Add(trip);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading inactive trips for rider: {ex.Message}");
            }

            return trips;
        }
        public List<Trip> GetTripsForRider(string riderPhoneNumber)
        {
            List<Trip> trips = new List<Trip>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        int tripId = int.Parse(parts[0]);
                        string pickupLocation = parts[1];
                        string dropoffLocation = parts[2];
                        bool isActive = bool.Parse(parts[3]);
                        double fare = double.Parse(parts[4]);
                        string riderPhoneNo = parts[5];
                        if (riderPhoneNo == riderPhoneNumber)
                        {
                            Trip trip = new Trip(pickupLocation, dropoffLocation, fare, isActive, tripId);
                            trips.Add(trip);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting trips for rider: {ex.Message}");
            }

            return trips;
        }

        public void UpdateRideStatus(int rideId)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        int tripId = int.Parse(parts[0]);
                        if (tripId == rideId)
                        {
                            parts[3] = "false"; // Update IsActive to false
                            writer.WriteLine(string.Join(",", parts));
                        }
                        else
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating ride status: {ex.Message}");
            }
        }

        public void UpdateRideStatusToAnonymous(int rideId)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        int tripId = int.Parse(parts[0]);
                        if (tripId == rideId)
                        {
                            parts[1] = "Anonymous"; // Update PickUpLocation
                            parts[2] = "Anonymous"; // Update DropOffLocation
                            parts[4] = "0"; // Update Fare
                            // Update other fields as needed
                            writer.WriteLine(string.Join(",", parts));
                        }
                        else
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating ride status to anonymous: {ex.Message}");
            }
        }

        public void DeleteRide(int rideId)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        int tripId = int.Parse(parts[0]);
                        if (tripId == rideId)
                        {
                            parts[6] = "1"; // Update IsDeleted to true
                            writer.WriteLine(string.Join(",", parts));
                        }
                        else
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting ride: {ex.Message}");
            }
        }

        public bool IsRideDeleted(int rideId)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        int tripId = int.Parse(parts[0]);
                        if (tripId == rideId)
                        {
                            return parts[6] == "1"; // Check if IsDeleted is true
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error checking if ride is deleted: {ex.Message}");
            }

            return false;
        }
        public List<Trip> GetAllPendingRides()
        {
            List<Trip> pendingRides = new List<Trip>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        int tripId = int.Parse(parts[0]);
                        string pickupLocation = parts[1];
                        string dropoffLocation = parts[2];
                        double fare = double.Parse(parts[3]);
                        int riderId = int.Parse(parts[4]);

                        // Check if pickupLocation is not "Anonymous"
                        if (pickupLocation != "Anonymous")
                        {
                            // Retrieve rider information
                            RiderCrudDB riderC = new RiderCrudDB();
                            Rider rider = riderC.SearchRiderWithId(riderId);

                            if (rider != null)
                            {
                                Trip trip = new Trip(pickupLocation, dropoffLocation, fare, rider);
                                trip.setTripId(tripId);
                                pendingRides.Add(trip);
                            }
                            else
                            {
                                Console.WriteLine("Rider id not found");
                            }
                        }
                    }
                }

                if (pendingRides.Count == 0)
                {
                    Console.WriteLine("No pending rides found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting pending rides: {ex.Message}");
            }

            return pendingRides;
        }

        public double GetDistance(string loc1, string loc2)
        {
            double dis = 0;
            if (loc1 == loc2)
            {
                return 0;
            }

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    string location1 = parts[1];
                    string location2 = parts[2];
                    double distance = double.Parse(parts[5]); // Assuming distance is at index 5
                    if ((location1 == loc1 && location2 == loc2) || (location1 == loc2 && location2 == loc1))
                    {
                        dis = distance;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting distance: {ex.Message}");
            }

            return dis;
        }

        public void UpdateArrivalMinutes(int TripId, int minutes)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        int tripId = int.Parse(parts[0]);
                        if (tripId == TripId)
                        {
                            parts[6] = minutes.ToString(); // Assuming arrival minutes is at index 6
                            writer.WriteLine(string.Join(",", parts));
                        }
                        else
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating arrival minutes: {ex.Message}");
            }
        }

        public Trip GetTripById(int TripId)
        {
            Trip trip = null;

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    int tripId = int.Parse(parts[0]);
                    if (tripId == TripId)
                    {
                        string pickupLocation = parts[1];
                        string dropoffLocation = parts[2];
                        double fare = double.Parse(parts[3]);
                        int riderId = int.Parse(parts[4]);
                        RiderCrudDB riderCr = new RiderCrudDB();
                        Rider rider = riderCr.SearchRiderWithId(riderId);
                        trip = new Trip(pickupLocation, dropoffLocation, fare, rider);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting trip by id: {ex.Message}");
            }

            return trip;
        }

        public void CompleteTrip(int TripId)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        int tripId = int.Parse(parts[0]);
                        if (tripId == TripId)
                        {
                            parts[7] = "1"; // Assuming IsCompleted flag is at index 7
                            writer.WriteLine(string.Join(",", parts));
                        }
                        else
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error completing trip: {ex.Message}");
            }
        }

        public List<Trip> LoadInCompleteTripsForDriverToList(string driverIdcard)
        {
            List<Trip> trips = new List<Trip>();

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    string driverId = parts[8]; // Assuming driver id is at index 8
                    if (driverId == driverIdcard && parts[7] == "")
                    {
                        string pickupLocation = parts[1];
                        string dropoffLocation = parts[2];
                        double fare = double.Parse(parts[3]);
                        int tripId = int.Parse(parts[0]);
                        int riderId = int.Parse(parts[4]);
                        Trip trip = new Trip(pickupLocation, dropoffLocation, fare, tripId);
                        RiderCrudDB riderC = new RiderCrudDB();
                        Rider rider = riderC.SearchRiderWithId(riderId);
                        if (rider != null)
                        {
                            trip.setRider(rider);
                        }
                        trips.Add(trip);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading incomplete trips for driver: {ex.Message}");
            }

            return trips;
        }

        public void UpdateRideStatusToAccepted(int rideId, string driverPhone, string driverIdCard)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        int tripId = int.Parse(parts[0]);
                        if (tripId == rideId)
                        {
                            parts[4] = "0"; // Assuming IsActive flag is at index 4
                            parts[9] = driverPhone; // Assuming driver phone is at index 9
                            parts[8] = driverIdCard; // Assuming driver id card is at index 8
                            writer.WriteLine(string.Join(",", parts));
                        }
                        else
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating ride status to accepted: {ex.Message}");
            }
        }

        public List<string> LoadAllLocations()
        {
            List<string> locations = new List<string>();

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    string pickupLocation = parts[1];
                    string dropoffLocation = parts[2];
                    if (!locations.Contains(pickupLocation))
                    {
                        locations.Add(pickupLocation);
                    }
                    if (!locations.Contains(dropoffLocation))
                    {
                        locations.Add(dropoffLocation);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading all locations: {ex.Message}");
            }

            return locations;
        }

    }

}




        // Implement other methods similarly...
    

