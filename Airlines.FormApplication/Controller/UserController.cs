using Airlines.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Airlines.FormApplication.Controller
{
    public class UserController
    {
        private const string baseUrl = "http://localhost:8733/UserService";

        public async Task<UserDto> UserById(int id)
        {
            RequestHandler<UserDto> request =
                new RequestHandler<UserDto>(baseUrl + $"/User/{id}", Method.GET);
            UserDto re = await request.GetData();
            return re;
        }

        public async Task<List<UserDto>> ListUser()
        {
            RequestHandler<List<UserDto>> request =
                new RequestHandler<List<UserDto>>(baseUrl + "/User", Method.GET);
            List<UserDto> re = await request.GetData();
            return re;
        }

        public async Task<List<UserDto>> ListUserByOffice(string office)
        {
            RequestHandler<List<UserDto>> request =
                new RequestHandler<List<UserDto>>(baseUrl + $"/User/Office/{office}", Method.GET);
            List<UserDto> re = await request.GetData();
            return re;
        }

        public async Task<List<string>> ListOffice()
        {
            RequestHandler<List<string>> request =
                new RequestHandler<List<string>>(baseUrl + $"/Office", Method.GET);
            List<string> re = await request.GetData();
            return re;
        }

        public async Task<bool> AddUser(UserDto _userDto,string _confidence)
        {
            RequestHandler<bool> request =
                new RequestHandler<bool>(baseUrl + $"/User", Method.POST);
            object obj = new
            {
                s = UserDtoSerialization.Serialize(_userDto),
                confidence = _confidence
            };
            bool re = await request.SubmitData(obj);
            return re;
        }

        public async Task<bool> EditUser(UserDto _userDto, string _confidence)
        {
            RequestHandler<bool> request =
                new RequestHandler<bool>(baseUrl + $"/User", Method.PUT);
            object obj = new
            {
                s = UserDtoSerialization.Serialize(_userDto),
                confidence = _confidence
            };
            bool re = await request.SubmitData(obj);
            return re;
        }

        public async Task<int> Authenticate(string _email,string _passwordhash)
        {
            RequestHandler<int> request =
                new RequestHandler<int>(baseUrl + $"/User/Auth", Method.POST);
            object obj = new
            {
                email = _email,
                passwordhash = _passwordhash
            };
            int re = await request.SubmitData(obj);
            return re;
        }

        public async Task<int> UserId(string email)
        {
            RequestHandler<int> request =
                new RequestHandler<int>(baseUrl + $"/User/ID", Method.POST);
            int re = await request.SubmitData(email);
            return re;
        }

        public async Task<bool> DisableLogin(int _id,string _confidence)
        {
            RequestHandler<bool> request =
                new RequestHandler<bool>(baseUrl + $"/User/Disable", Method.POST);
            object obj = new
            {
                id = _id,
                confidence = _confidence
            };
            bool re = await request.SubmitData(obj);
            return re;
        }
    }
}
