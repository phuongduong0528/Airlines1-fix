using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airlines.Services.Dto;
using RestSharp;

namespace Airlines.FormApplication.Controller
{
    public class UserActivityController
    {
        private const string baseUrl = "http://localhost:8733/UserActivityService";

        public async Task<string> LoginLogs(int _id,string _date,string _time)
        {
            RequestHandler<string> request =
                new RequestHandler<string>(baseUrl + "/UserActivity", Method.POST);
            object obj = new
            {
                id = _id,
                date = _date,
                time = _time
            };
            string re = await request.SubmitData(obj);
            return re;
        }

        public async Task<bool> LogoutLogs(int _id, string _time, string _confidence)
        {
            RequestHandler<bool> request =
               new RequestHandler<bool>(baseUrl + "/UserActivity", Method.PUT);
            object obj = new
            {
                id = _id,
                time = _time,
                confidence = _confidence
            };
            bool re = await request.SubmitData(obj);
            return re;
        }

        public async Task<bool> NoLogOutLogs(int _id, string _reason, string _confidence)
        {
            RequestHandler<bool> request =
               new RequestHandler<bool>(baseUrl + "/UserActivity/NoLogOut", Method.PUT);
            object obj = new
            {
                id = _id,
                reason = _reason,
                confidence = _confidence
            };
            bool re = await request.SubmitData(obj);
            return re;
        }

        public async Task<List<UserActivityDto>> UserActivity(int _id, string _confidence)
        {
            RequestHandler<List<UserActivityDto>> request =
               new RequestHandler<List<UserActivityDto>>(baseUrl + "/UserActivity/List", Method.POST);
            object obj = new
            {
                id = _id,
                confidence = _confidence
            };
            List<UserActivityDto> re = await request.SubmitData(obj);
            return re;
        }

        public async Task<string> TotalTimeOnSystem(int _id, string _confidence)
        {
            RequestHandler<string> request =
               new RequestHandler<string>(baseUrl + "/UserActivity/Totaltime", Method.POST);
            object obj = new
            {
                id = _id,
                confidence = _confidence
            };
            string re = await request.SubmitData(obj);
            return re;
        }
    }
}
