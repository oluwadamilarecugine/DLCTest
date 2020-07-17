using DLCTest.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;

namespace DLCTest.PageObjets
{
    class QAEngineerTestPage
    {
        IWebDriver driver;

        public QAEngineerTestPage()
        {
            driver = Hook.driver;
        }
        public void Navigatetopage(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        IWebElement enterUsername => driver.FindElement(By.XPath("//*[@type='text']"));
        IWebElement enterPassword => driver.FindElement(By.XPath("//*[@type='password']"));
        IWebElement clickOnLogin => driver.FindElement(By.XPath("//*[@type='submit']"));
        IWebElement successfulMessage => driver.FindElement(By.XPath("//*[@class='logged-in__success']"));


        public void EnterUsername(String username)
        {
            enterUsername.SendKeys(username);
        }

        public void EnterPassword(String password)
        {
            enterPassword.SendKeys(password);
        }

        public void ClickOnLogin()
        {
            clickOnLogin.Click();
        }

        public bool SuccessfulMessage(string successmessage)
        {
           
            return successfulMessage.Displayed;
        }




    }
}
