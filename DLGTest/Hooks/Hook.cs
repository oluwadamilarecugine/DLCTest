using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace DLCTest.Hooks
{
    [Binding]
    class Hook
    {
        public static IWebDriver driver;
        [BeforeScenario]
        public void BeforeScenerio()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [AfterScenario]
        public void AfterScenerio()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
