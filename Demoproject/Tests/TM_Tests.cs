using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using NUnit.Framework;
using Demoproject.utilities;

namespace Demoproject.Pages

{
    [TestFixture]
    internal class TM_Tests: CommonDriver
    {

        //static void Main(string[] args)
        //{
        //    LoginFunction();
        //}

           

       [Test,Order (1), Description("check create worked")]
        public void CreatFunction()
        {
            // Call homepage
            HomePage HomeObj = new HomePage();
            HomeObj.MyHomePage(Driver);

            // Call TMPage
            TMPage TMObj = new TMPage();
            TMObj.MyCreateTm(Driver);

        }

       [Test, Order(2), Description("check edit worked")]
        public void EditFunction()
        {
            // Call homepage
            HomePage HomeObj = new HomePage();
            HomeObj.MyHomePage(Driver);

            // Call TMPage
            TMPage TMObj = new TMPage();
            TMObj.myEdit(Driver, "dummy", "dummy2", "dummy3");
        }

    [Test]
        public void DeleteFunction()
        {
            //Call TMPage
            TMPage TMObj = new TMPage();
            TMObj.Delete(Driver);
        }

       // [Test]

        public void CloseTestRun()
        {
            // Call TMPage
            //TMPage TMObj = new TMPage();
            //TMObj.MMyCreateTm(Driver);
        }
       














        /* OLD CODE
         static void Main(string[] args)
    {
        try
        {
            throw new Exception("Error");


        //// OPEN CHROME BROWSER
        IWebDriver mydriver = new ChromeDriver();
        mydriver.Manage().Window.Maximize();

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
        catch(Exception ex)
        {
            Console.WriteLine("Error in Try" + ex.Message.ToString());
        }
        }
        */







    }
}

