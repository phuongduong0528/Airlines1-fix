using Airlines.Business.Models;
using Airlines.Services.Dto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Services.Adaptor
{
    public class UserActivityAdaptor
    {
        public UserActivityDto GetUserActivity(UserActivity userActivity)
        {
            UserActivityDto result = new UserActivityDto();
            result.date = userActivity.Date.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture);
            result.loginTime = userActivity.LogInTime.ToString();
            result.logoutTime = userActivity.LogOutTime.ToString();
            result.timeSpend = userActivity.TimeSpend.ToString();
            result.reason = userActivity.Reason;
            return result;
        }

        public List<UserActivityDto> GetListUserActivityDto(List<UserActivity> userActivities)
        {
            List<UserActivityDto> result = new List<UserActivityDto>();
            foreach(UserActivity u in userActivities)
            {
                result.Add(GetUserActivity(u));
            }
            return result;
        }
    }
}
