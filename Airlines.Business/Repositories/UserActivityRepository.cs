using Airlines.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Business.Repositories
{
    class UserActivityRepository : IUserActivityRepository
    {
        Session1Entities session1;

        public UserActivityRepository()
        {
            session1 = new Session1Entities();
        }

        public List<UserActivity> GetUserActivities(int id)
        {
            return session1.UserActivities.Where(ua => ua.UserID == id).ToList();
        }

        public string LoginRecord(int userid, DateTime date, TimeSpan time)
        {
            try
            {
                UserActivity userActivity = new UserActivity();
                if (session1.UserActivities.Count() == 0)
                    userActivity.ID = 1;
                else
                    userActivity.ID = session1.UserActivities.Max(ua => ua.ID) + 1;
                userActivity.UserID = userid;
                userActivity.Date = date;
                userActivity.LogInTime = time;
                userActivity.Confidence = Guid.NewGuid();
                session1.UserActivities.Add(userActivity);
                session1.SaveChanges();
                return userActivity.Confidence.ToString();
            }
            catch(Exception ex)
            {
                return "";
            }
        }

        public bool LogoutRecord(int id, TimeSpan time)
        {
            try
            {
                UserActivity userActivity =
                session1.UserActivities.Where(ua => ua.UserID == id)
                .OrderByDescending(ua => ua.ID).First();
                userActivity.LogOutTime = time;
                userActivity.TimeSpend = userActivity.LogOutTime - userActivity.LogInTime;
                session1.Entry(userActivity).State = System.Data.Entity.EntityState.Modified;
                session1.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool SetNoLogoutReason(int id, string reason)
        {
            try
            {
                UserActivity userActivity =
                session1.UserActivities.Where(ua => ua.UserID == id)
                .OrderByDescending(ua => ua.ID).Skip(1).First();
                userActivity.Reason = reason;
                session1.Entry(userActivity).State = System.Data.Entity.EntityState.Modified;
                session1.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
