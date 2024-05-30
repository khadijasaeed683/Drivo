using Drivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberNew.DL
{
    public class RatingCrudDB
    {
        public static string con = Utils.GetConnectionString();
        static RatingCrudDB instance;
        public static RatingCrudDB GetInstance()
        {
            if (instance == null)
            {
                instance = new RatingCrudDB();
            }


            return instance;

        }
        public RatingCrudDB()
        {

        }
    }
}
