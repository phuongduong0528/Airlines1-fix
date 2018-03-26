using Airlines.Business.Models;
using Airlines.Business.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Business.Manager
{
    public class UserManager : IUserManager
    {
        UserRepository userRepository;
        Session1Entities session1;

        public UserManager()
        {
            userRepository = new UserRepository();
            session1 = new Session1Entities();
        }

        public bool AddUser(User s)
        {
            return userRepository.AddUser(s);
        }

        /// <summary>
        ///  -1 -> Fail  |
        ///   0 -> Account Disable  |
        ///   1 -> NoLogOut  |
        ///   2 -> OK  
        /// </summary>
        public int Authenticate(string email, string passwordhash)
        {
            User u = session1.Users.SingleOrDefault(user =>
                user.Email.Equals(email) &&
                user.Password.Equals(passwordhash));
            if (u != null)
            {
                if (NoLogOutCheck(u.ID))
                    return 1;
                if (u.Active == true)
                    return 2;
                else
                    return 0;
            }
            else
                return -1;
        }

        public bool DisableLogin(int id)
        {
            return userRepository.DisableLogin(id);
        }

        public bool EditUser(User s)
        {
            return userRepository.EditUser(s);
        }

        public User GetById(int id)
        {
            return userRepository.GetById(id);
        }

        public List<User> GetListUser()
        {
            return userRepository.GetListUser();
        }

        public List<User> GetListUserByOffice(string office)
        {
            List<User> result = new List<User>();
            foreach(User u in session1.Users.Where(u => u.Office.Title.Equals(office)))
            {
                result.Add(u);
            }
            return result;
        }

        public List<string> GetOfficeList()
        {
            OfficeRepository office = new OfficeRepository();
            return office.GetListOffice();
        }

        public int GetUserId(string email)
        {
            User user = session1.Users.SingleOrDefault(u => u.Email.Equals(email));
            if (user != null)
                return user.ID;
            else
                return -1;
        }

        public bool NoLogOutCheck(int id)
        {
            try
            {
                UserActivity userActivity =
                    session1.UserActivities
                    .Where(a => a.UserID == id)
                    .OrderByDescending(a => a.LogInTime)
                    .First();
                if (userActivity.LogOutTime == null && userActivity.Reason == null)
                    return true;
                else
                    return false;
            }
            catch(Exception ex)
            {
                return false;
            }

        }
    }
}
