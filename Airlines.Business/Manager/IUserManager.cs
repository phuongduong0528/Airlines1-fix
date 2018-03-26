using Airlines.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Business.Manager
{
    interface IUserManager
    {
        User GetById(int id);
        List<User> GetListUser();
        bool AddUser(User s);
        bool EditUser(User s);
        bool DisableLogin(int id);

        List<string> GetOfficeList();
        List<User> GetListUserByOffice(string office);
        int GetUserId(string email);
        int Authenticate(string email, string passwordhash);
        bool NoLogOutCheck(int id);
    }
}
