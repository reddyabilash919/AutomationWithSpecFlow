using AutomationFrameworkWithSpecFlow.Models.API;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkWithSpecFlow
{
    public  class Settings
    {


    public string LoadEnvironmentPath(string path)
        {
            DotNetEnv.Env.Load();
            DotNetEnv.Env.TraversePath().Load();
            return DotNetEnv.Env.GetString(path);
        }

        public string LoadAPIBaseURL()
        {
            return LoadEnvironmentPath("BASE_URL");
        }

        public string LoadUserEndPoint()
        {
            return LoadEnvironmentPath("USER_ENDPOINT");

        }

        public string LoadResourceEndPoint()
        {
            return LoadEnvironmentPath("RESOURCE_ENDPOINT");

        }

        public string LoadRegisterEndPoint()
        {
            return LoadEnvironmentPath("REGISTER_ENDPOINT");      

        }

        public string LoadLoginEndPoint()
        {
            return LoadEnvironmentPath("LOGIN_ENDPOINT");

        }
    }
}
