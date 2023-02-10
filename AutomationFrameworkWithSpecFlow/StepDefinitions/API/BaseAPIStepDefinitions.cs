using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkWithSpecFlow.StepDefinitions.API
{
    [Binding]
    public class BaseAPIStepDefinitions
    {

        protected ScenarioContext scenarioContext;
        public BaseAPIStepDefinitions(ScenarioContext scenarioContext) 
        {
            this.scenarioContext = scenarioContext;
        }
    }
}
