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
    public class UserActivityDto
    {
        [DataMember(Order = 0)]
        [DisplayName("Date")]
        public string date { get; set; }

        [DataMember(Order = 1)]
        [DisplayName("Log in time")]
        public string loginTime { get; set; }

        [DataMember(Order = 2)]
        [DisplayName("Log out time")]
        public string logoutTime { get; set; }

        [DataMember(Order = 3)]
        [DisplayName("Time spend")]
        public string timeSpend { get; set; }

        [DataMember(Order = 4)]
        [DisplayName("Reason")]
        public string reason { get; set; }
    }
}
