using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NUnit.Framework;

namespace Demoproject
{
    internal class TMPage
    {
        public void MyCreateTm(IWebDriver mydriver) 
        {
            // Create Time and Materials record

            // Navigate to Administration Menu and click on TM 
            IWebElement administration = mydriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administration.Click();
            IWebElement TimeandMaterials = mydriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TimeandMaterials.Click();

            // Click on the create new button
            IWebElement CreatenewBtn = mydriver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreatenewBtn.Click();

            // Select Type Code,enter code,enter discription,enter price per unit
            IWebElement Typecode = mydriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span"));
            Typecode.Click();

            IWebElement Material = mydriver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
            // Material.Click();
            IWebElement Entercode = mydriver.FindElement(By.Id("Code"));
            Entercode.SendKeys("12");

            IWebElement Discription = mydriver.FindElement(By.Id("Description"));
            Discription.SendKeys("My record");

            IWebElement amount = mydriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            amount.Click();

            IWebElement PriceperUnit = mydriver.FindElement(By.Id("Price"));
            PriceperUnit.SendKeys("25");


            // Click on Save button
            IWebElement SaveButton = mydriver.FindElement(By.Id("SaveButton"));
            SaveButton.Click();

            Thread.Sleep(2000);
            // Click on go to last page button
            IWebElement goToLastpageButton = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastpageButton.Click();

            //Check if record create is present in the table and has expected value
            //IWebElement actualCode = mydriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            ////*[@id="tmsGrid"]/div[3]/table/tbody/tr[10]/td[1]
            /////*[@id="tmsGrid"]/div[3]/table/tbody/tr[6]/td[1]
           /* Assert.That(actualCode.Text == "12", "Actual Code does not match");
            if (actualCode.Text == "12")
            {
                Assert.Pass("code present then Test pass ");

            }
            else
            {

                Assert.Fail("Missing code then Test fail");
            }
           */
            //if (actualCode.Text == "12")
            //{
            //    Console.WriteLine("code present then Test pass ");

            //}
            //else
            //{

            //    Console.WriteLine("Missing code then Test fail");
            //}
        }


        public string GetCode(IWebDriver driver)
        {
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return actualCode.Text;
        }

        public string GetTypeCode(IWebDriver driver)
        {
            IWebElement createdTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            return createdTypeCode.Text;
        }
         public string GetDescription(IWebDriver driver)
        {
            IWebElement createdDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return createdDescription.Text;
        }

        public string GetPrice(IWebDriver driver)
        {
            IWebElement createdPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return createdPrice.Text;
        }


        public void myEdit(IWebDriver myDriver, string desription, string code, string price)
        {
            Thread.Sleep(2000);
            //click on go to last page buton
            IWebElement Lastpagebutton = myDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            Lastpagebutton.Click();
            IWebElement actualCode = myDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (actualCode.Text == "12")
            {
                //Click the Edit Button
                IWebElement Edit = myDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                Edit.Click();


            }

            //Change the code
            IWebElement Entercode = myDriver.FindElement(By.Id("Code"));
            Entercode.Clear();
            Entercode.SendKeys(code);

            //change the Description

            IWebElement Discription = myDriver.FindElement(By.Id("Description"));
            Discription.Clear();
            Discription.SendKeys(desription);


            //change the price per unit

            /*IWebElement PriceperUnit = myDriver.FindElement(By.Id("Price"));
            PriceperUnit.Clear();
            PriceperUnit.SendKeys("34");*/
            // Edit price
            IWebElement priceTag = myDriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement priceTextbox = myDriver.FindElement(By.Id("Price"));

            priceTag.Click();
            priceTextbox.Clear();
            priceTag.Click();
            priceTextbox.SendKeys(price);



            // Click on Save button
            IWebElement SaveButton = myDriver.FindElement(By.Id("SaveButton"));

            SaveButton.Click();
            Thread.Sleep(1000);

            //click on go to last page buton
            IWebElement Lastpage = myDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            Lastpage.Click();

            Thread.Sleep(1000);
               
            // Assertion
            IWebElement createdCode = myDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
                                                                         
            IWebElement createdTypeCode = myDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement createdDescription = myDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement createdPrice = myDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));


            Assert.That(createdCode.Text == "13", "Code record hasn't been edited.");


        }

        public void Delete(IWebDriver driver)
        {
            Thread.Sleep(2000);

            // click on go to lsast page button
            IWebElement GoToLastPageButton = driver.FindElement(By.XPath("/*[@id='tmsGrid'/div[4]/a[4]/span"));
            GoToLastPageButton.Click();

            IWebElement findEditedRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));

            // click on delete button
            // In Pop up message box select yes
            driver.SwitchTo().Alert().Dismiss();
            // Refresh page
            // go to last page button
            //check if the deleted row is present  or not
        }



    }
}
