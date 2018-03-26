using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Airlines.FormApplication.Controller
{
    class RequestHandler<T>
    {
        private RestClient client;
        private RestRequest request;

        public RequestHandler(string Url,Method method)
        {
            client = new RestClient(new Uri(Url));
            request = new RestRequest(method);
        }

        public async Task<T> GetData()
        {
            IRestResponse<T> response = 
                await client.ExecuteTaskAsync<T>(request);
            return response.Data;
        }

        public async Task<T> SubmitData(object obj)
        {
            if (request.Method == Method.GET)
                throw new Exception("Method not allowed");
            else
            {
                request.RequestFormat = DataFormat.Json;
                request.AddBody(obj);
                IRestResponse<T> response =
                    await client.ExecuteTaskAsync<T>(request);
                return response.Data;
            }
        }
    }
}
