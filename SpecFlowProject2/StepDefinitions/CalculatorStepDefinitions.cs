using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        Login l=new Login();
        int id=1;
        string password="Aneesh22";

        [Given(@"User gives userid and password")]
        public void GivenUserGivesUseridAndPassword()
        {
            Console.WriteLine("Userid and password");
            //throw new PendingStepException();
        }

        [When(@"UserClicksLogin")]
        public void WhenUserClicksLogin()
        {
            l.userid=id;
            l.password=password;
            //throw new PendingStepException();
        }

        [Then(@"SuccessfulLogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            Assert.AreEqual(id,l.userid);
            Assert.AreEqual(password,l.password);
            Console.WriteLine("Login successfully.......");
            //throw new PendingStepException();
        }

        [When(@"User LogOut from the Application")]
        public void WhenUserLogOutFromTheApplication()
        {
          
            throw new PendingStepException();
        }

        [Then(@"Successful LogOut message should display")]
        public void ThenSuccessfulLogOutMessageShouldDisplay()
        {
            
            throw new PendingStepException();
        }
    }
}
