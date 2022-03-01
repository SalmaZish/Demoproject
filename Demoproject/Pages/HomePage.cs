using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoproject.Pages
{
    internal class HomePage
    {
        public void MyHomePage(IWebDriver mydriver)
        { // Navigate to Administration Menu and click on TM 
            IWebElement administration = mydriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administration.Click();
            IWebElement TimeandMaterials = mydriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TimeandMaterials.Click();

        }
    }
}
