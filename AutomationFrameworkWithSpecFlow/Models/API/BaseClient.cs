using Gherkin;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkWithSpecFlow.Models.API
{
    public class BaseClient
    {

        private RestClient client;
        private RestRequest? request;

        public BaseClient()
        {
            var settings = new Settings();
            this.client = new RestClient(settings.LoadAPIBaseURL());
        }


        public RestResponse Post(string endPoint, Object data)
        {
            request = new RestRequest(endPoint, Method.Post);
            request.AddBody(data);
            return client.Execute(request);
        }

        public RestResponse Delete(string endPoint)
        {
            request = new RestRequest(endPoint, Method.Delete);
            return client.Execute(request);
        }

        public RestResponse Get(string endPoint) 
        {
            request = new RestRequest(endPoint, Method.Get);
            return client.Execute(request);
        }



    }
}
