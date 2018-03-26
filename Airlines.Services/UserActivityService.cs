using Airlines.Business.Manager;
using Airlines.Services.Adaptor;
using Airlines.Services.Dto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Airlines.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserActivityService" in both code and config file together.
    public class UserActivityService : IUserActivityService
    {
        UserActivityAdaptor userActivityAdaptor = new UserActivityAdaptor();
        UserActivityManager _userActivityManager;

        UserActivityManager UserActivityManager => _userActivityManager ??
            (_userActivityManager = new UserActivityManager());

        public string LoginLogs(int id, string date, string time)
        {
            DateTime d;
            TimeSpan t;
            if (DateTime.TryParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out d) &&
                TimeSpan.TryParseExact(time, @"hh\:mm\:ss", CultureInfo.InvariantCulture, out t))
            {
                return UserActivityManager.LoginLogs(id, d, t);
            }
            else
                return "";
        }

        public bool LogoutLogs(int id, string time, string confidence)
        {

            if (UserActivityManager.CheckConfidence(confidence))
            {
                TimeSpan t;
                if (TimeSpan.TryParseExact(time, @"hh\:mm\:ss", CultureInfo.InvariantCulture, out t))
                {
                    return UserActivityManager.LogoutLogs(id, t);
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool NoLogoutReason(int id, string reason, string confidence)
        {
            if (UserActivityManager.CheckConfidence(confidence))
                return UserActivityManager.NoLogoutReason(id, reason);
            return false;
        }

        public string TotalTimeOnSystem(int id, string confidence)
        {
            if (UserActivityManager.CheckConfidence(confidence))
                return UserActivityManager.GetTotalTimeOnSystem(id);
            else
                return "";
        }

        public List<UserActivityDto> UserActivities(int id, string confidence)
        {
            if (!UserActivityManager.CheckConfidence(confidence))
            {
                return null;
            }

            return userActivityAdaptor.GetListUserActivityDto(
                UserActivityManager.GetUserActivities(id)
            );
        }
    }
}
