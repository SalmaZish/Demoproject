using Demoproject.utilities;
using System;
using TechTalk.SpecFlow;
using Demoproject.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace Demoproject.StepDefinitions
{
    [Binding]
    public class TMfeatureStepDefinitions : CommonDriver
    {
        //Initializing page objects
        LoginPage LoginObj = new LoginPage();
        HomePage HomeObj = new HomePage();
        TMPage TMObj = new TMPage();

        [Given(@"I logged into the Turnup portal successfully")]
        public void GivenILoggedIntoTheTurnupPortalSuccessfully()
        {
            Driver = new ChromeDriver();
          
            LoginObj.MyLoginPage(Driver);

        }

        [Given(@"I navigate to time and material page")]
        public void GivenINavigateToTimeAndMaterialPage()
        {
            // Call homepage
         
            HomeObj.MyHomePage(Driver);

        }

        [When(@"I create time and material record")]
        public void WhenICreateTimeAndMaterialRecord()
        {

            // Call TMPage
           
            TMObj.MyCreateTm(Driver);
        }

        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            TMPage tMPageObj = new TMPage();

            string newCode = tMPageObj.GetCode(Driver);
            string newTyCode = tMPageObj.GetTypeCode(Driver);
            string newTypeCode = tMPageObj.GetTypeCode(Driver);
            string newDescription = tMPageObj.GetDescription(Driver);
            string newPrice = tMPageObj.GetPrice(Driver);

            Assert.That(newCode == "12", "Actual Code does not match");
            Assert.That(newTypeCode == "m", "Actual typecode and expected typecode do not match");
            Assert.That(newDescription == "My record", "Actual description and expected description do not match");
            Assert.That(newPrice == "$25.00", "Actual price and expected price do not match");
        }

        [When(@"I update '([^']*)','([^']*)','([^']*)' on existing Time and material record")]
        public void WhenIUpdateOnExistingTimeAndMaterialRecord(string demo, string asd, string p2)
        {
            throw new PendingStepException();
        }

        [Then(@"the record should have the updated '([^']*)','([^']*)','([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string demo, string asd, string p2)
        {
            throw new PendingStepException();
        }




    }
}
