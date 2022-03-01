using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoproject.Pages
{
    internal class LoginPage
    {
       public void MyLoginPage(IWebDriver mydriver)
        {
            // OPEN CHROME BROWSER
           //  IWebDriver mydriver = new ChromeDriver();
           // mydriver.Manage().Window.Maximize();

            // LAUNCH TURNUP PORTAL
            mydriver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            // identify username textbox and enter valid username
            IWebElement usernameTextbox = mydriver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            // identify password textbox and enter valid password
            IWebElement passwordTextbox = mydriver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            // click on loginbutton
            IWebElement loginButton = mydriver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

            // check if user is logged in successfully
            IWebElement findloginuser = mydriver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (findloginuser.Text == "Hello hari!")
            {
                Console.WriteLine("logged in successful test passed");
                Console.WriteLine("end of test pass");
            }
            else
            {
                Console.WriteLine("test fail");
                Console.WriteLine("end of test fail");

            }
        }
    }
}
