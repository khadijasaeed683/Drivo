using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivo
{
    public class Utils
    {
        private static string ConnectionString = "";
        private static string RiderFilePath = "";
         private static string TripFilePath = "";

        public static void SetConnectionString(string conn)
        {
            ConnectionString = conn;
        }
        public static string GetConnectionString()
        {
            return ConnectionString;
        }
        public static void SetRiderFilePath(string filePath)
        {
            RiderFilePath = filePath;
        }
        public static string GetRiderFilePath()
        {
            return RiderFilePath;
        }
        public static void SetTripFilePath(string filePath)
        {
            TripFilePath = filePath;
        }
         public static string GetTripFilePath()
        {
            return TripFilePath;
        }

       

    }
}
