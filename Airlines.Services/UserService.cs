using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Airlines.Business.Manager;
using Airlines.Services.Adaptor;
using Airlines.Services.Dto;

namespace Airlines.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in both code and config file together.
    public class UserService : IUserService
    {
        UserAdaptor userAdaptor = new UserAdaptor();
        UserManager _userManager;
        UserActivityManager _userActivityManager;

        UserManager UserManager => _userManager ??
            (_userManager = new UserManager());

        UserActivityManager UserActivityManager => _userActivityManager ??
            (_userActivityManager = new UserActivityManager());

        public bool AddUser(UserDto s, string confidence)
        {
            if (UserActivityManager.CheckConfidence(confidence))
            {
                return UserManager.AddUser(
                    userAdaptor.ToUserEntity(s)
                    );
            }
            else
                return false;
        }

        public int Authenticate(string email, string passwordhash)
        {
            return UserManager.Authenticate(email, passwordhash);
        }

        public bool EditUser(UserDto s, string confidence)
        {
            if (UserActivityManager.CheckConfidence(confidence))
            {
                return UserManager.EditUser(
                    userAdaptor.ToUserEntity(s)
                    );
            }
            else
                return false;
        }

        public UserDto UserById(string id)
        {
            int _id;
            if (Int32.TryParse(id, out _id))
            {
                return userAdaptor.GetUserDto(
                UserManager.GetById(_id)
                );
            }
            else
                return null;
        }

        public List<UserDto> ListUser()
        {
            return userAdaptor.GetListUserDto(
                UserManager.GetListUser()
                );
        }

        public List<UserDto> ListUserByOffice(string office)
        {
            return userAdaptor.GetListUserDto(
                UserManager.GetListUserByOffice(office)
                );
        }

        public List<string> ListOffice()
        {
            return UserManager.GetOfficeList();
        }

        public int UserID(string email)
        {
            return UserManager.GetUserId(email);
        }

        public bool DisableLogin(int id, string confidence)
        {
            if (UserActivityManager.CheckConfidence(confidence))
                return UserManager.DisableLogin(id);
            else
                return false;
        }
    }
}
