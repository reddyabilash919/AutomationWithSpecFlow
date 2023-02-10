using AutomationFrameworkWithSpecFlow.Models.Data;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkWithSpecFlow.Models.API
{
    public class RegisterEndPoint: BaseClient
    {


        public RestResponse RegisterNewUser(Register RegisterDetials)
        {
            var settings = new Settings();
            var response = Post(settings.LoadRegisterEndPoint(), RegisterDetials);
            return response;
        }
    }
}
