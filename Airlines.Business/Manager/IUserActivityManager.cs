using Airlines.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Business.Manager
{
    interface IUserActivityManager
    {
        string LoginLogs(int id,DateTime date,TimeSpan time);
        bool LogoutLogs(int id, TimeSpan time);
        bool NoLogoutReason(int id, string reason);
        List<UserActivity> GetUserActivities(int id);

        bool CheckConfidence(string guid);
        string GetTotalTimeOnSystem(int id);
    }
}
