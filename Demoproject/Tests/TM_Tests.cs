using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Demoproject.Pages

{
    internal class TM_Tests
    {
        static void Main(string[] args)
        {
            // OPEN CHROME BROWSER
            IWebDriver mydriver = new ChromeDriver();
            mydriver .Manage().Window.Maximize();

            // Call login Page
            LoginPage LoginObj = new LoginPage();
            LoginObj.MyLoginPage(mydriver);

            // Call homepage
            HomePage HomeObj = new HomePage();
            HomeObj.MyHomePage(mydriver);

            // Call TMPage
            TMPage TMObj = new TMPage();
            TMObj.MMyCreateTm(mydriver);


            
            


        }
    }
}

