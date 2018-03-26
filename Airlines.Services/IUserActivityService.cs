using Airlines.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Airlines.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserActivityService" in both code and config file together.
    [ServiceContract]
    public interface IUserActivityService
    {
        [OperationContract]
        [WebInvoke(
            UriTemplate = "/UserActivity",
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            ResponseFormat = WebMessageFormat.Json)]
        string LoginLogs(int id, string date, string time);

        [OperationContract]
        [WebInvoke(
            UriTemplate = "/UserActivity",
            Method = "PUT",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            ResponseFormat = WebMessageFormat.Json)]
        bool LogoutLogs(int id, string time,string confidence);

        [OperationContract]
        [WebInvoke(
            UriTemplate = "/UserActivity/NoLogOut",
            Method = "PUT",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            ResponseFormat = WebMessageFormat.Json)]
        bool NoLogoutReason(int id, string reason, string confidence);

        [OperationContract]
        [WebInvoke(
            UriTemplate = "/UserActivity/List",
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            ResponseFormat = WebMessageFormat.Json)]
        List<UserActivityDto> UserActivities(int id, string confidence);

        [OperationContract]
        [WebInvoke(
            UriTemplate = "/UserActivity/Totaltime",
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            ResponseFormat = WebMessageFormat.Json)]
        string TotalTimeOnSystem(int id, string confidence);
    }
}
