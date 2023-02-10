using AutomationFrameworkWithSpecFlow.Models.API;
using AutomationFrameworkWithSpecFlow.Models.Data;
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
    public class ReSourceStepDefinitions : BaseAPIStepDefinitions
    {
        private ResourcesEndPoint resourcesEndPoint;
        public ReSourceStepDefinitions(ScenarioContext scenarioContext) : base(scenarioContext)
        {
            this.resourcesEndPoint = new ResourcesEndPoint();
        }


        [When(@"I send a request with resource's id ""(.*)""")]
        public void WhenISendARequestWithResourcesId(string id)
        {
            var response = resourcesEndPoint.GetSingleResource(id);
            scenarioContext.Add("response", response);
        }

       
    }
}
