using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UberNew;

namespace Drivo
{
    public interface IRiderCrud
    {
        bool StoreUser(Rider user);
        Rider SignIn(Rider user );
        Rider SearchRiderWithId(int riderid );
        void UpdateRiderName(Rider rider, string newName);
        void UpdateRiderPassword(Rider rider, string newPass);
        void UpdateRiderPhoneNumber(Rider rider, string newPhn);
        void UpdateRiderEmail(Rider rider, string newEmail);  //7
        bool DeleteRider(int riderid);
        List<Rider> GetAllActiveRiders();
         bool IsUsernameUnique(string username);





    }
}
