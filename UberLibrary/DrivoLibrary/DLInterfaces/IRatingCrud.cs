using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivo
{
    public interface IRatingCrud
    {
        void GetRiderRating(double rating);
        int CalculateAverageRating(double rating);
    }
}
