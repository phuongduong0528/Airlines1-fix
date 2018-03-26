using Airlines.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.FormApplication.Controller
{
    class UserDtoSerialization
    {
        public static object Serialize(UserDto userDto)
        {
            object o = new
            {
                id = userDto.Id,
                firstname = userDto.FirstName,
                lastname = userDto.LastName,
                age = userDto.Age,
                role = userDto.Role,
                email = userDto.Email,
                office = userDto.Office,
                birthdate = userDto.BirthDate,
                active = userDto.Active,
                password = userDto.Password
            };
            return o;
        }
    }
}
