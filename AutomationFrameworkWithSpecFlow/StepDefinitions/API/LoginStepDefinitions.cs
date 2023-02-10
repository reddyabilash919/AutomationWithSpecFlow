using AutomationFrameworkWithSpecFlow.Models.API;
using AutomationFrameworkWithSpecFlow.Models.Data;
using AutomationFrameworkWithSpecFlow.StepDefinitions.API;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;


namespace AutomationFrameworkWithSpecFlow.StepDefinitions.API
{
    [Binding]
    public class LoginStepDefinitions : BaseAPIStepDefinitions
    {

        private LoginEndpoint loginEndpoint;
        public LoginStepDefinitions(ScenarioContext scenarioContext) : base(scenarioContext)
        {
            this.loginEndpoint = new LoginEndpoint();
        }

       

        [When(@"I login with user credentials")]
        public void WhenILoginWithUserCredentials(Table table)
        {
            var loginDetails = table.CreateInstance<Login>();
            var response = loginEndpoint.Login(loginDetails);
            scenarioContext.Add("response", response);
        }


       

        [Then(@"token should be generated successfully")]
        public void ThenTokenShouldBeGeneratedSuccessfully()
        {

            var response = scenarioContext.Get<RestResponse>("response");
            var content = JObject.Parse(response.Content);

            scenarioContext.Add("token", content["token"].ToString());

            Assert.That(content["token"].ToString(), Is.Not.Null);
        }
    }
}


