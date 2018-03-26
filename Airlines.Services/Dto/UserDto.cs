using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Services.Dto
{
    [DataContract]
    public class UserDto
    {
        [DataMember(Name = "id", Order = 0)]
        public int Id { get; set; }

        [DataMember(Name = "firstname", Order = 1)]
        [DisplayName("Name")]
        public string FirstName { get; set; }

        [DataMember(Name = "lastname", Order = 2)]
        [DisplayName("Last name")]
        public string LastName { get; set; }

        [DataMember(Name = "age", Order = 3)]
        [DisplayName("Age")]
        public int Age { get; set; }

        [DataMember(Name = "role", Order = 4)]
        [DisplayName("User role")]
        public string Role { get; set; }

        [DataMember(Name = "email", Order = 5)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [DataMember(Name = "office", Order = 6)]
        [DisplayName("Office")]
        public string Office { get; set; }

        [DataMember(Name = "birthdate", Order = 7)]
        public string BirthDate { get; set; }

        [DataMember(Name = "active", Order = 8)]
        public bool? Active { get; set; }

        [DataMember(Name = "password", Order = 9)]
        public string Password { get; set; }
    }
}
