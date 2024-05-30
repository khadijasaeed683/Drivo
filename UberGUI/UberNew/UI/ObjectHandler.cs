using Drivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberNew
{
    internal class ObjectHandler
    {
        static private IRiderCrud RiderCrud = RiderCrudDB.GetInstance();
        static private IDriverCrud DriverCrud = DriverCrudDB.GetInstance();
        static private ITripCrud TripCrud = TripCrudDB.GetInstance();
       
        
      /*  static private IRiderCrud RiderCrud = RiderCrudFH.GetInstance();
        static private ITripCrud TripCrud = TripCrudDB.GetInstance();
*/

        public static  IRiderCrud GetRiderCrud()
        {
            return RiderCrud;
        }
        public static IDriverCrud GetDriverCrud()
        {
            return DriverCrud;
        }
        public static ITripCrud GetTripCrud()
        {
            return TripCrud;
        }
    }
}
