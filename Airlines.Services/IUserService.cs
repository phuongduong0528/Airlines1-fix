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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserService" in both code and config file together.
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        [WebGet(
            UriTemplate = "/User/{id}",
            ResponseFormat = WebMessageFormat.Json)]
        UserDto UserById(string id);

        [OperationContract]
        [WebGet(
            UriTemplate = "/User",
            ResponseFormat = WebMessageFormat.Json)]
        List<UserDto> ListUser();

        [OperationContract]
        [WebGet(
            UriTemplate = "/User/Office/{office}",
            ResponseFormat = WebMessageFormat.Json)]
        List<UserDto> ListUserByOffice(string office);

        [OperationContract]
        [WebGet(
            UriTemplate = "/Office",
            ResponseFormat = WebMessageFormat.Json)]
        List<string> ListOffice();

        [OperationContract]
        [WebInvoke(
            UriTemplate = "/User",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        bool AddUser(UserDto s, string confidence);

        [OperationContract]
        [WebInvoke(
            UriTemplate = "/User",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            Method = "PUT",
            ResponseFormat = WebMessageFormat.Json)]
        bool EditUser(UserDto s, string confidence);

        [OperationContract]
        [WebInvoke(
            UriTemplate = "/User/Auth",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json)]
        int Authenticate(string email, string passwordhash);

        [OperationContract]
        [WebInvoke(
            UriTemplate = "/User/ID",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json)]
        int UserID(string email);

        [OperationContract]
        [WebInvoke(
            UriTemplate = "/User/Disable",
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            ResponseFormat = WebMessageFormat.Json)]
        bool DisableLogin(int id, string confidence);
    }
}
