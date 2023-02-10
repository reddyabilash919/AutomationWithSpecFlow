using AutomationFrameworkWithSpecFlow.Models.Data;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkWithSpecFlow.Models.API
{
    public class LoginEndpoint : BaseClient
    {
        public RestResponse Login(Login loginCredentials)
        {
            var settings = new Settings(); 
            var response = Post(settings.LoadLoginEndPoint(), loginCredentials);
            return response;
        }
    }
}
