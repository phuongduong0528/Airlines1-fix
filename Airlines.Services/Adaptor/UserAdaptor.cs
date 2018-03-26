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
    public class UserAdaptor
    {
        public UserDto GetUserDto(User user)
        {
            UserDto udto = new UserDto();
            udto.Id = user.ID;
            udto.FirstName = user.FirstName;
            udto.LastName = user.LastName;
            udto.Age = DateTime.UtcNow.Year - user.Birthdate.Value.Year;
            udto.Role = user.Role.Title;
            udto.Email = user.Email;
            udto.Office = user.Office.Title;
            udto.BirthDate = user.Birthdate.Value.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture);
            udto.Active = user.Active;
            udto.Password = "";
            return udto;
        }

        public List<UserDto> GetListUserDto(List<User> users)
        {
            List<UserDto> userDtos = new List<UserDto>();
            foreach(User u in users)
            {
                userDtos.Add(GetUserDto(u));
            }
            return userDtos;
        }

        public User ToUserEntity(UserDto udto)
        {
            User u = new User();
            u.ID = udto.Id;
            u.FirstName = udto.FirstName;
            u.LastName = udto.LastName;
            u.Email = udto.Email;
            u.Birthdate = DateTime.ParseExact(udto.BirthDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            u.Active = udto.Active;
            u.Password = udto.Password;
            using(Session1Entities session1 = new Session1Entities())
            {
                u.RoleID = session1.Roles.Single(r => r.Title.Equals(udto.Role)).ID;
                u.OfficeID = session1.Offices.Single(o => o.Title.Equals(udto.Office)).ID;
            }
            return u;
        }
    }
}
