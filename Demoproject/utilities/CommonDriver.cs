using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Demoproject.Pages;

namespace Demoproject.utilities
{
    internal class CommonDriver
    {
        public static IWebDriver Driver;

        [OneTimeSetUp]
        public static void LoginFunction()
        {

            //// OPEN CHROME BROWSER
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();

            // Call login Page
            LoginPage LoginObj = new LoginPage();
            LoginObj.MyLoginPage(Driver);


        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            Driver.Quit();
        }

    }
}
