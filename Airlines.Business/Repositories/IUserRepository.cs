using Airlines.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Business.Repositories
{
    interface IUserRepository
    {
        User GetById(int id);
        List<User> GetListUser();
        bool AddUser(User s);
        bool EditUser(User s);
        bool DisableLogin(int id);
    }
}
