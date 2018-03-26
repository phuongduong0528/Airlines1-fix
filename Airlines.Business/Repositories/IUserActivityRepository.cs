using Airlines.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Business.Repositories
{
    interface IUserActivityRepository
    {
        string LoginRecord(int userid,DateTime date,TimeSpan time);
        bool SetNoLogoutReason(int id, string reason);
        bool LogoutRecord(int id, TimeSpan time);
        List<UserActivity> GetUserActivities(int id);
    }
}
