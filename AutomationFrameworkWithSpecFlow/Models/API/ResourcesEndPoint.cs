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
    public class ResourcesEndPoint : BaseClient
    {

        public RestResponse GetSingleResource(string id)
        {

            var settings = new Settings();
            var response = Get(settings.LoadResourceEndPoint()+"/"+id);
            return response;
        }
    }
}