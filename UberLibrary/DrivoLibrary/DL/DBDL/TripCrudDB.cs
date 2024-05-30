using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivo
{
    public class TripCrudDB : ITripCrud
    {
        public static string con = Utils.GetConnectionString();
         static TripCrudDB instance;
        public static TripCrudDB GetInstance()
        {
            if (instance == null)
            {
                instance = new TripCrudDB();
            }


            return instance;

        }
        public TripCrudDB()
        {

        }
        public bool StoreTrip(Trip tr, Rider rider)
        {
            bool act = true;
            bool isdeleted = false;
            string con = Utils.GetConnectionString();
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string query = String.Format("Insert into Trips (RiderPhoneNo, PickUpLocation, DropOffLocation, Fare, IsActive, IsDeleted, Rider_id) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", tr.getRider().getPhoneNumber(), tr.getPickupLocation(), tr.getDropoffLocation(), tr.getFare(), act, isdeleted, rider.getID());
            SqlCommand command = new SqlCommand(query, connection);
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public  List<Trip> LoadAllTripsToList()
        {
            List<Trip> trips = new List<Trip>();

            using (SqlConnection connection = new SqlConnection(con))
            {
                string query = "SELECT PickUpLocation, DropOffLocation, Fare, Rider_id FROM Trips ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string pickupLocation = reader["PickUpLocation"].ToString();
                            string dropoffLocation = reader["DropOffLocation"].ToString();
                            double fare = Convert.ToDouble(reader["Fare"]);
                            int Rider_id = Convert.ToInt32(reader["Rider_id"]);
                            RiderCrudDB riderC = new RiderCrudDB();


                            Rider rider = riderC.SearchRiderWithId(Rider_id);


                            Trip trip = new Trip(pickupLocation, dropoffLocation, fare, rider);
                            trips.Add(trip);
                        }
                    }
                }
            }

            return trips;
        }
        public  List<Trip> LoadActiveTripsToList()
        {
            List<Trip> trips = new List<Trip>();

            using (SqlConnection connection = new SqlConnection(con))
            {
                string query = "SELECT PickUpLocation, DropOffLocation, Fare FROM Trips WHERE IsActive = 1  AND IsCompleted = 0";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string pickupLocation = reader["PickUpLocation"].ToString();
                            string dropoffLocation = reader["DropOffLocation"].ToString();
                            double fare = Convert.ToDouble(reader["Fare"]);

                            Trip trip = new Trip(pickupLocation, dropoffLocation, fare);
                            trips.Add(trip);
                        }
                    }
                }
            }

            return trips;
        }
        public  List<Trip> LoadActiveTripsForRiderToList(int riderId)
        {
            List<Trip> trips = new List<Trip>();

            using (SqlConnection connection = new SqlConnection(con))
            {
                string query = "SELECT PickUpLocation, DropOffLocation, Fare, trip_id FROM Trips WHERE IsActive = 1  AND IsDeleted = 0 AND Rider_id=@riderId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@riderId", riderId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string pickupLocation = reader["PickUpLocation"].ToString();
                            string dropoffLocation = reader["DropOffLocation"].ToString();
                            double fare = Convert.ToDouble(reader["Fare"]);
                            int TripID = Convert.ToInt32(reader["trip_id"]);

                            Trip trip = new Trip(pickupLocation, dropoffLocation, fare, TripID);
                            trips.Add(trip);
                        }
                    }
                }
            }

            return trips;
        }

        public List<Trip> LoadInActiveTripsToList()
        {
            List<Trip> trips = new List<Trip>();

            using (SqlConnection connection = new SqlConnection(con))
            {
                string query = "SELECT PickUpLocation, DropOffLocation, Fare , trip_id FROM Trips WHERE IsActive = 0  OR IsCompleted = 1 OR IsDeleted = 1";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string pickupLocation = reader["PickUpLocation"].ToString();
                            string dropoffLocation = reader["DropOffLocation"].ToString();
                            double fare = Convert.ToDouble(reader["Fare"]);
                            int id = Convert.ToInt32(reader["trip_id"]);

                            Trip trip = new Trip(pickupLocation, dropoffLocation, fare);
                            trip.setTripId(id);
                            trips.Add(trip);
                        }
                    }
                }
            }

            return trips;
        }
        public static List<Trip> LoadInActiveTripsForRiderToList(int riderId)
        {
            List<Trip> trips = new List<Trip>();

            using (SqlConnection connection = new SqlConnection(con))
            {
                string query = "SELECT PickUpLocation, DropOffLocation, Fare, trip_id FROM Trips WHERE (IsActive = 0  OR IsDeleted = 1) AND Rider_id=@riderId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@riderId", riderId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string pickupLocation = reader["PickUpLocation"].ToString();
                            string dropoffLocation = reader["DropOffLocation"].ToString();
                            double fare = Convert.ToDouble(reader["Fare"]);
                            int TripID = Convert.ToInt32(reader["trip_id"]);

                            Trip trip = new Trip(pickupLocation, dropoffLocation, fare, TripID);

                            trips.Add(trip);
                        }
                    }
                }
            }

            return trips;
        }
        public  List<Trip> GetTripsForRider(string riderPhoneNumber)
        {
            List<Trip> trips = new List<Trip>();

            // SQL query to select trips for the given rider's phone number
            string query = @"SELECT T.trip_id, T.PickUpLocation, T.DropOffLocation, T.IsActive, T.Fare
                               FROM Trips T

WHERE RiderPhoneNo = @PhoneNumber" ;

            using (SqlConnection connection = new SqlConnection(con))
            {
                // Open the database connection
                connection.Open();

                // Create a command object with the SQL query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add a parameter for the rider's phone number
                    command.Parameters.AddWithValue("@PhoneNumber", riderPhoneNumber);

                    // Execute the SQL query and read the results
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Iterate through the result set
                        while (reader.Read())
                        {


                            int TripId = reader.GetInt32(0);
                            string StartLocation = reader.GetString(1);
                            string EndLocation = reader.GetString(2);
                            bool IsActive = reader.GetBoolean(3);
                            double fare = reader.GetDouble(4);
                            // Populate more properties if needed
                            Trip trip = new Trip(StartLocation, EndLocation, fare, IsActive, TripId);

                            // Add the Trip object to the list of trips
                            trips.Add(trip);
                        }
                    }
                }
            }

            // Return the list of trips for the specified rider
            return trips;
        }

        public  void UpdateRideStatus(int rideId)
        {
            //changed IsActive to ACCEPTED rather than pending
            // Implement database update query to set IsActive to false for the selected ride
            string updateQuery = "UPDATE Trips SET IsActive = 0 WHERE trip_id = @RideId";

            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@RideId", rideId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public  void UpdateRideStatusToAnonymous(int rideId)
        {
            // Update query to set relevant fields to anonymized values
            string updateQuery = "UPDATE Trips " +
                                  "SET PickUpLocation = 'Anonymous', DropOffLocation = 'Anonymous', " +
                                  "Fare = 0 " +  // Add other fields as needed
                                  "WHERE trip_id = @RideId";

            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@RideId", rideId);
                    command.ExecuteNonQuery();
                }
            }
        }
        public  void DeleteRide(int rideId)
        {
            // Update query to set relevant fields to anonymized values
            string updateQuery = "UPDATE Trips " +
                        "SET IsDeleted = 1 " +  // Comma added here
                        "WHERE trip_id = @RideId";

            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@RideId", rideId);
                    command.ExecuteNonQuery();
                }
            }
        }
        public  bool IsRideDeleted(int rideId)
        {
            bool isDeleted = false;
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                string query = "SELECT IsDeleted FROM Trips WHERE trip_id = @RideId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RideId", rideId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows && reader.Read())
                        {
                            isDeleted = reader.GetBoolean(0); // Assuming IsDeleted is at index 0
                        }
                    }
                }
            }

            return isDeleted;
        }
        public  List<Trip> GetAllPendingRides()
        {
            List<Trip> pendingRides = new List<Trip>();

          
                using (SqlConnection connection = new SqlConnection(con))
                {
                    string query = "SELECT trip_id, PickUpLocation, DropOffLocation, Fare, Rider_id FROM Trips WHERE IsActive = 1";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int tripId = reader.GetInt32(0);
                                string pickupLocation = reader.GetString(1);
                                string dropoffLocation = reader.GetString(2);
                                double fare = reader.GetDouble(3);
                                int riderId = reader.GetInt32(4);

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


                                        // MessageBox.Show(rider.getPhoneNumber(), rider.getName());
                                        pendingRides.Add(trip);
                                    }

                                    else
                                    {
                                       // MessageBox.Show("Rider id not found");
                                    }
                                }
                            }
                        }
                    }
                }

                if (pendingRides.Count == 0)
                {
                   // MessageBox.Show("No pending rides found.");
                }
            

            return pendingRides;
        }
        public  double GetDistance(string loc1, string loc2)
        {
            double dis = 0;
            if (loc1 == loc2)
            {
                return 0;
            }
            string query = "SELECT Distance FROM Stops WHERE (Location1 = @Loc1 AND Location2 = @Loc2) OR (Location1 = @Loc2 AND Location2 = @Loc1)";

            using (SqlConnection connection = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@Loc1", loc1);
                    command.Parameters.AddWithValue("@Loc2", loc2);



                    // Open the database connection
                    connection.Open();

                    // Execute the query and get the result
                    object result = command.ExecuteScalar();

                    // Check if result is not null and convert it to double
                    if (result != null && result != DBNull.Value)
                    {
                        dis = Convert.ToDouble(result);
                    }
                   

                    return dis;
                }
            }


        }
        public  void UpdateArrivalMinutes(int TripId, int minutes)
        {
            // Update the database
            using (SqlConnection sqlConnection = new SqlConnection(con))
            {
                sqlConnection.Open();
                string updateQuery = "UPDATE Trips SET ArrivalMinutes = @Minutes WHERE trip_id = @TripId";

                using (SqlCommand command = new SqlCommand(updateQuery, sqlConnection))
                {
                    command.Parameters.AddWithValue("@Minutes", minutes);
                    command.Parameters.AddWithValue("@TripId", TripId);
                    command.ExecuteNonQuery();
                }
            }

            // Update the class
            Trip trip = GetTripById(TripId);
            if (trip != null)
            {
                trip.setArrivalMinutes(minutes);
            }
            else
            {
                Console.WriteLine("Trip not found.");
            }
        }
        public static Trip GetTripById(int TripId)
        {
            Trip trip = null;

            using (SqlConnection connection = new SqlConnection(con))
            {
                string query = "SELECT PickUpLocation, DropOffLocation, Fare, Rider_id FROM Trips WHERE trip_id = @TripId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TripId", TripId);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string pickupLocation = reader["PickUpLocation"].ToString();
                            string dropoffLocation = reader["DropOffLocation"].ToString();
                            double fare = Convert.ToDouble(reader["Fare"]);
                            int Rider_id = Convert.ToInt32(reader["Rider_id"]);

                            RiderCrudDB riderCr=new RiderCrudDB();
                            Rider rider = riderCr.SearchRiderWithId(Rider_id);

                            trip = new Trip(pickupLocation, dropoffLocation, fare, rider);
                        }
                    }
                }
            }

            return trip;
        }
        public void CompleteTrip(int TripId) //new
        {
            // Update the database
            using (SqlConnection sqlConnection = new SqlConnection(con))
            {
                sqlConnection.Open();
                string updateQuery = "UPDATE Trips SET IsCompleted = 1 WHERE trip_id = @TripId";

                using (SqlCommand command = new SqlCommand(updateQuery, sqlConnection))
                {
                    // command.Parameters.AddWithValue("@Minutes", minutes);
                    command.Parameters.AddWithValue("@TripId", TripId);
                    command.ExecuteNonQuery();
                }
            }

            // Update the class
            Trip trip = GetTripById(TripId);
           /*  if (trip != null)
            {
                trip.setArrivalMinutes(minutes);
            }
            else
            {
                Console.WriteLine("Trip not found.");
            }*/
            
        }
        public List<Trip> LoadInCompleteTripsForDriverToList(string driverIdcard)  //new
        {
            List<Trip> trips = new List<Trip>();

            using (SqlConnection connection = new SqlConnection(con))
            {
                string query = "SELECT PickUpLocation, DropOffLocation, Fare, trip_id, Rider_id FROM Trips WHERE IsCompleted IS NULL AND Driver_idcard=@driveridcard";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@driveridcard", driverIdcard);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string pickupLocation = reader["PickUpLocation"].ToString();
                            string dropoffLocation = reader["DropOffLocation"].ToString();
                            double fare = Convert.ToDouble(reader["Fare"]);
                            int TripID = Convert.ToInt32(reader["trip_id"]);
                            int riderId = Convert.ToInt32(reader["Rider_id"]);
                            Trip trip = new Trip(pickupLocation, dropoffLocation, fare, TripID);

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
            }

            return trips;
        }
        public  void UpdateRideStatusToAccepted(int rideId, string driverPhone, string driverIdCard)
        {
            //changed IsActive to ACCEPTED rather than pending
            // Implement database update query to set IsActive to false for the selected ride
            string updateQuery = "UPDATE Trips SET IsActive = 0, DriverPhoneNo=@phone, Driver_idcard=@idcard WHERE trip_id = @RideId";

            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@RideId", rideId);
                    command.Parameters.AddWithValue("@phone", driverPhone);
                    command.Parameters.AddWithValue("@idcard", driverIdCard);


                    command.ExecuteNonQuery();
                }
            }
        }
        public List<string> LoadAllLocations()
        {
            List<string> locations = new List<string>();
            string query = "SELECT DISTINCT Location1 FROM Stops UNION SELECT DISTINCT Location2 FROM Stops";

            // Create a SqlConnection to connect to the database
            using (SqlConnection connection = new SqlConnection(con))
            {
                // Create a SqlCommand to execute the query
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                   
                        // Open the database connection
                        connection.Open();

                        // Execute the query and read the results
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Loop through the results and add them to dropdown lists
                            while (reader.Read())
                            {
                                string location = reader.GetString(0);
                                locations.Add(location);
                            }
                        }                                    
                }
            }
            return locations;
        }

    }
}
