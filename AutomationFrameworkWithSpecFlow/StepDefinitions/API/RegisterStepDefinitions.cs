using AutomationFrameworkWithSpecFlow.Models.API;
using AutomationFrameworkWithSpecFlow.Models.Data;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace AutomationFrameworkWithSpecFlow.StepDefinitions.API
{
    [Binding]
    public class RegisterStepDefinitions : BaseAPIStepDefinitions
    {

        private RegisterEndPoint registerEndPoint;
        public RegisterStepDefinitions(ScenarioContext scenarioContext) : base(scenarioContext)
        {
            this.registerEndPoint = new RegisterEndPoint();
        }

        [When(@"I register as a user")]
        public void WhenIRegsiterAsAUser(Table table)
        {
            var registerDetials = table.CreateInstance<Register>();
            var response = registerEndPoint.RegisterNewUser(registerDetials);
            scenarioContext.Add("response", response);
        }


      

        [Then(@"""(.*)"" error message should be displayed")]
        public void ThenErrorMessageShouldBeDisplayed(string errorMessage)
        {
            var response = scenarioContext.Get<RestResponse>("response");
            var content = JObject.Parse(response.Content);

            Assert.That(content["error"].ToString(), Is.EqualTo(errorMessage));
           
        }

        [Then(@"Id should be generated successfully")]
        public void ThenIdShouldBeGeneratedSuccessfully()
        {
            var response = scenarioContext.Get<RestResponse>("response");
            var content = JObject.Parse(response.Content);

            scenarioContext.Add("id", content["id"]);
            Assert.That(content["id"], Is.Not.Null);
           
        }
    }
}
