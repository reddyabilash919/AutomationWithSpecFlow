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
    public class UsersEndPoint : BaseClient
    {

        public RestResponse GetListOfUsers(int pageNumber)
        {
            var settings = new Settings();
            var response = Get(settings.LoadUserEndPoint() + "?page="+ pageNumber.ToString());
            return response;
        }

        public RestResponse GetSingleUser(string id)
        {

            var settings = new Settings();
            var response = Get(settings.LoadUserEndPoint()+"/" +id);
            return response;

        }

        public RestResponse DeleteUser(string id)
        {

            var settings = new Settings();
            var response = Delete(settings.LoadUserEndPoint() + "/"+ id);
            return response;
        }


        public RestResponse CreateNewUser(User userData)
        {
            var settings = new Settings();
            var response = Post(settings.LoadUserEndPoint(), new User
            {
                Name = userData.Name,
                Job = userData.Job
            });
            return response;

        }
    }
}