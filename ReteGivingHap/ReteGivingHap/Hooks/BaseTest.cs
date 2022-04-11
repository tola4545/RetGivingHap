using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using TechTalk.SpecFlow;

namespace ReteGivingHap.Hooks
{
    [Binding]
    public class BaseTest
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            // driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
