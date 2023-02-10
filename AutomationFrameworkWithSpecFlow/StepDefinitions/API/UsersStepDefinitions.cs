using AutomationFrameworkWithSpecFlow.Models.API;
using AutomationFrameworkWithSpecFlow.Models.Data;
using FluentAssertions.Execution;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace AutomationFrameworkWithSpecFlow.StepDefinitions.API
{
    [Binding]
    public class UsersStepDefinitions : BaseAPIStepDefinitions
    {

        private UsersEndPoint usersEndPoint;
        public UsersStepDefinitions(ScenarioContext scenarioContext) : base(scenarioContext)
        {
            this.usersEndPoint = new UsersEndPoint();
        }

        [Given(@"I am in user's page number ""(.*)""")]
        public void GivenIAmInUsersPageNumber(string pageNumber)
        {
            scenarioContext.Add("pageNumber", pageNumber);
        }

        [When(@"I delete user with id ""(.*)""")]
        public void WhenIDeleteUserWithId(string id)
        {
            var response = usersEndPoint.DeleteUser(id);
            scenarioContext.Add("response",response);
        }

        [Then(@"the response status code should be ""(.*)""")]
        public void ThenTheResponseStatusCodeShouldBe(string statusCode)
        {
            var response = scenarioContext.Get<RestResponse>("response");

            Assert.That(response.StatusCode.ToString(), Is.EqualTo(statusCode));
        }

        [When(@"I create a new user with following information")]
        public void WhenICreateANewUserWithFollowingInformation(Table table)
        {
            var userData = table.CreateInstance<User>();
            var response = usersEndPoint.CreateNewUser(userData);

            scenarioContext.Add("response", response);
            scenarioContext.Add("userData", userData);
        }
    
        [Then(@"new user information should be displayed successfully")]
        public void ThenNewUserInformationShouldBeDisplayedSuccessfully()
        {
            var userData = scenarioContext.Get<User>("userData");
            var response = scenarioContext.Get<RestResponse>("response");
            var content = JObject.Parse(response.Content);
           
            Assert.That(content["name"].ToString(), Is.EqualTo(userData.Name));
            Assert.That(content["job"].ToString(), Is.EqualTo(userData.Job));
        }


        [When(@"I send request to get list of existing users")]
        public void WhenISendRequestToGetListOfExistingUsers()
        {
            var pageNumber = scenarioContext.Get<string>("pageNumber");
            var response = usersEndPoint.GetListOfUsers(int.Parse(pageNumber));
            scenarioContext.Add("response", response);
        }

        [Then(@"The overall total number of existing users should be ""(.*)""")]
        public void ThenTheTotalNumberOfExistingUsersShouldBe(string total)
        {

            var response = scenarioContext.Get<RestResponse>("response");
            var content = JObject.Parse(response.Content);
            Assert.That(content["total"].ToString(), Is.EqualTo(total)); 
        }

        [Then(@"existing user information should be displayed")]
        public void ThenExistingUserInformationShouldBeDisplayedSuccessfully(Table table)
        {
            var userData = table.CreateInstance<User>();
            var response = scenarioContext.Get<RestResponse>("response");
            var content = JObject.Parse(response.Content);

            Assert.That(int.Parse(content["data"]["id"].ToString()), Is.EqualTo(userData.Id));
            Assert.That(content["data"]["email"].ToString(), Is.EqualTo(userData.Email));
            Assert.That(content["data"]["first_name"].ToString(), Is.EqualTo(userData.FirstName));
            Assert.That(content["data"]["last_name"].ToString(), Is.EqualTo(userData.LastName));
            Assert.That(content["data"]["avatar"].ToString(), Is.EqualTo(userData.Avatar));
           
        }

        [When(@"I send a request with user's id ""(.*)""")]
        public void WhenISendARequestWithUsersId(string id)
        {
            var response = usersEndPoint.GetSingleUser(id);
            scenarioContext.Add("response", response);
        }


        [Then(@"the existing users list should contain following user information")]
        public void ThenTheListOfExistingUsersShouldContainFollowingUserInformation(Table table)
        {
            var userData = table.CreateInstance<User>();
            var response = scenarioContext.Get<RestResponse>("response");
            var content = JObject.Parse(response.Content);

            bool userFound = false;

            foreach(var user in content["data"]) {
                if (user["first_name"].ToString().Equals(userData.FirstName))
                {
                    Console.WriteLine(user["first_name"] + "inside if");
                    Assert.That(user["first_name"].ToString(), Is.EqualTo(userData.FirstName));
                    Assert.That(user["last_name"].ToString(), Is.EqualTo(userData.LastName));
                    userFound = true;
                    break;
                }
            }

            if(!userFound)
            {
                Assert.Fail("User information doesn't exist");
            }
        }

    }
}
