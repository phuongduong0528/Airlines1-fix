using Airlines.Business.Models;
using Airlines.Business.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Business.Manager
{
    public class UserActivityManager : IUserActivityManager
    {
        UserActivityRepository userActivityRepository;
        Session1Entities session1;

        public UserActivityManager()
        {
            session1 = new Session1Entities();
            userActivityRepository = new UserActivityRepository();
        }

        public bool CheckConfidence(string guid)
        {
            Guid check;
            if (!Guid.TryParse(guid, out check))
                return false;
            else
            {
                UserActivity userActivity =
                session1.UserActivities.SingleOrDefault(ua => ua.Confidence.Equals(check));
                if (userActivity == null)
                    return false;
                else
                    return true;
            }
        }

        public List<UserActivity> GetUserActivities(int id)
        {
            return userActivityRepository.GetUserActivities(id);
        }

        public string LoginLogs(int id, DateTime date, TimeSpan time)
        {
            return userActivityRepository.LoginRecord(id, date, time);
        }

        public bool LogoutLogs(int id, TimeSpan time)
        {
            return userActivityRepository.LogoutRecord(id, time);
        }

        public bool NoLogoutReason(int id, string reason)
        {
            return userActivityRepository.SetNoLogoutReason(id, reason);
        }

        public string GetTotalTimeOnSystem(int id)
        {
            TimeSpan totaltime = new TimeSpan();
            foreach(UserActivity ua in 
                session1.UserActivities.Where(u => u.ID == id))
            {
                totaltime += ua.TimeSpend.Value;
            }
            return totaltime.ToString(@"hh\:mm\:ss");
        }
    }
}
