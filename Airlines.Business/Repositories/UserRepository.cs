using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airlines.Business.Models;

namespace Airlines.Business.Repositories
{
    public class UserRepository : IUserRepository
    {
        private Session1Entities session1;

        public UserRepository()
        {
            session1 = new Session1Entities();
        }

        public bool AddUser(User s)
        {
            try
            {
                if (s != null)
                {
                    if (session1.Users.Any(u => u.Email.Equals(s.Email)))
                        return false;
                    s.ID = session1.Users.Max(u => u.ID) + 1;
                    session1.Users.Add(s);
                    session1.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DisableLogin(int id)
        {
            User user = session1.Users.SingleOrDefault(u => u.ID == id);
            if (user == null)
                return false;
            else
            {
                if (user.Active == true)
                    user.Active = false;
                else
                    user.Active = true;
                session1.Entry(user).State = System.Data.Entity.EntityState.Modified;
                session1.SaveChanges();
                return true;
            }
        }

        public bool EditUser(User u)
        {
            try
            {
                if (session1.Users.Any(user => user.ID == u.ID))
                {
                    User temp = session1.Users.Single(user=>user.ID == u.ID);
                    temp.Email = u.Email;
                    temp.FirstName = u.FirstName;
                    temp.LastName = u.LastName;
                    temp.OfficeID = u.OfficeID;
                    temp.RoleID = u.RoleID;
                    session1.Entry(temp).State = System.Data.Entity.EntityState.Modified;
                    session1.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public User GetById(int id)
        {
            return session1.Users.SingleOrDefault(user => user.ID == id);
        }

        public List<User> GetListUser()
        {
            return session1.Users.ToList();
        }
    }
}
