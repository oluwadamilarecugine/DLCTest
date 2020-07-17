using DLCTest.PageObjets;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DLCTest
{
    [Binding]
    public class QAEngineerTestSteps
    {
        QAEngineerTestPage qaEngineerTestPage;

        public QAEngineerTestSteps()
        {
            qaEngineerTestPage = new QAEngineerTestPage();
        }

        [Given(@"I navigate to url ""(.*)""")]
        public void GivenINavigateToUrl(string url)
        {
            qaEngineerTestPage.Navigatetopage(url);
        }


        [When(@"I enter username ""(.*)""")]
        public void WhenIEnterUsername(string username)
        {
            qaEngineerTestPage.EnterUsername(username);
        }

        [When(@"I enter password ""(.*)""")]
        public void WhenIEnterPassword(string password)
        {
            qaEngineerTestPage.EnterPassword(password);
        }
        
        [When(@"I click on login")]
        public void WhenIClickOnLogin()
        {
            qaEngineerTestPage.ClickOnLogin(); 
        }
        
        [Then(@"Successful login message should display ""(.*)""")]
        public void ThenSuccessfulLoginMessageFrameShouldDisplay(string successmessage)
        {
            Assert.True(qaEngineerTestPage.SuccessfulMessage(successmessage));
        }

        //InvalidUsername/passwordAssertion    

        [Then(@"The message ""(.*)"" Should not display")]
        public void ThenTheMessageShouldNotDisplay(string successmessage)
        {
            Assert.False(qaEngineerTestPage.SuccessfulMessage(successmessage));
        }


    }
}
