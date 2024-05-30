using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Drivo
{
    public class RiderCrudFH : IRiderCrud
    {
        private static string filePath = Utils.GetRiderFilePath();

        static RiderCrudFH instance;
        public static RiderCrudFH GetInstance()
        {
            if (instance == null)
            {
                instance = new RiderCrudFH();
            }
            return instance;
        }

        public RiderCrudFH()
        {
        }

        public bool StoreUser(Rider user)
        {
            try
            {
                // Generate a unique rider ID (auto-increment)
                int riderId = GetNextRiderId();

                // Append rider ID along with other user details to the file
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{riderId}|{user.getName()}|{user.getEmail()}|{user.getPassword()}|{user.getAddress()}|{user.getPhoneNumber()}");
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error storing user: " + ex.Message);
                return false;
            }
        }

        private int GetNextRiderId()
        {
            int nextRiderId = 1; // Initialize to 1 as the starting ID

            try
            {
                // If file doesn't exist or is empty, return 1 as the next ID
                if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
                {
                    return nextRiderId;
                }

                // Read the last rider ID from the file and increment it for the next rider
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string lastLine = File.ReadLines(filePath).LastOrDefault();
                    if (lastLine != null)
                    {
                        string[] parts = lastLine.Split('|');
                        nextRiderId = int.Parse(parts[0]) + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error generating next rider ID: " + ex.Message);
            }

            return nextRiderId;
        }


        public Rider SignIn(Rider user)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        if (parts[1] == user.getName() && parts[3] == user.getPassword())
                        {
                            return new Rider(parts[1], parts[2], parts[3], parts[4], parts[5]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sign IN error: " + ex.Message);
            }
            return null;
        }
        public Rider SearchRiderWithId(int riderid)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        if (int.Parse(parts[0]) == riderid)
                        {
                            return new Rider(parts[0], parts[1], parts[2], parts[3], parts[4]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching rider by ID: " + ex.Message);
            }
            return null;
        }

        public void UpdateRiderName(Rider rider, string newName)
        {
            try
            {
                string tempFile = Path.GetTempFileName();
                using (StreamWriter writer = new StreamWriter(tempFile))
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        int riderId = int.Parse(parts[0]); // Parse rider ID to int
                        if (riderId == rider.getID()) // Compare rider ID as int
                        {
                            parts[1] = newName;
                            line = string.Join("|", parts);
                        }
                        writer.WriteLine(line);
                    }
                }
                File.Delete(filePath);
                File.Move(tempFile, filePath);
                Console.WriteLine("Rider name updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating rider name: " + ex.Message);
            }
        }

        public void UpdateRiderPassword(Rider rider, string newPass)
        {
            try
            {
                List<string> lines = File.ReadAllLines(filePath).ToList();

                for (int i = 0; i < lines.Count; i++)
                {
                    string[] parts = lines[i].Split('|');
                    if (int.Parse(parts[0]) == rider.getID())
                    {
                        parts[3] = newPass;
                        lines[i] = string.Join("|", parts);
                        break;
                    }
                }

                File.WriteAllLines(filePath, lines);
                Console.WriteLine("Rider Password updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating rider Password: " + ex.Message);
            }
        }

        public void UpdateRiderPhoneNumber(Rider rider, string newPhn)
        {
            try
            {
                List<string> lines = File.ReadAllLines(filePath).ToList();

                for (int i = 0; i < lines.Count; i++)
                {
                    string[] parts = lines[i].Split('|');
                    if (int.Parse(parts[0]) == rider.getID())
                    {
                        parts[5] = newPhn;
                        lines[i] = string.Join("|", parts);
                        break;
                    }
                }

                File.WriteAllLines(filePath, lines);
                Console.WriteLine("Rider PhoneNumber updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating rider PhoneNumber: " + ex.Message);
            }
        }

        public void UpdateRiderEmail(Rider rider, string newEmail)
        {
            try
            {
                List<string> lines = File.ReadAllLines(filePath).ToList();

                for (int i = 0; i < lines.Count; i++)
                {
                    string[] parts = lines[i].Split('|');
                    if (int.Parse(parts[0]) == rider.getID())
                    {
                        parts[2] = newEmail;
                        lines[i] = string.Join("|", parts);
                        break;
                    }
                }

                File.WriteAllLines(filePath, lines);
                Console.WriteLine("Rider email updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating rider email: " + ex.Message);
            }
        }

        public List<Rider> GetAllActiveRiders()
        {
            List<Rider> allRiders = new List<Rider>();

            try
            {
                foreach (string line in File.ReadAllLines(filePath))
                {
                    string[] parts = line.Split('|');
                    int riderId = int.Parse(parts[0]);
                    string name = parts[1];
                    string email = parts[2];
                    string password = parts[3];
                    string address = parts[4];
                    string phoneNumber = parts[5];

                    Rider rider = new Rider(riderId, name, email, password, phoneNumber);
                    allRiders.Add(rider);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving active riders: " + ex.Message);
            }

            return allRiders;
        }

        public bool DeleteRider(int riderId)
        {
            try
            {
                List<string> lines = File.ReadAllLines(filePath).ToList();

                for (int i = 0; i < lines.Count; i++)
                {
                    string[] parts = lines[i].Split('|');
                    if (int.Parse(parts[0]) == riderId)
                    {
                        lines.RemoveAt(i);
                        File.WriteAllLines(filePath, lines);
                        Console.WriteLine("Rider deleted successfully.");
                        return true;
                    }
                }

                Console.WriteLine("No rider found with the specified ID.");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting rider: " + ex.Message);
                return false;
            }
        }
        public bool IsUsernameUnique(string username)
        {
            try
            {
                // Check if the file exists
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        string existingUsername = parts[1];

                        if (existingUsername.Equals(username, StringComparison.OrdinalIgnoreCase))
                        {
                            return false;
                        }
                    }
                }

                // If no matching username found, return true (unique)
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error checking username uniqueness: " + ex.Message);
                return false;
            }
        }


    }
}







