using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomationTestLab
{
    public class HomePage : TestBase
    { 
        public HomePage(IWebDriver webDriver)
        {
            webDriver = driver;
        }


        #region
        /* Page Elements */
        public string HomePageTitle = "Amazon.com: Online Shopping for Electronics, Apparel, Computers, Books, DVDs & more";

        private IWebElement Name => driver.FindElement(By.CssSelector("#name"));
        private IWebElement Password => driver.FindElement(By.CssSelector("#password"));
        private IWebElement LoginButton => driver.FindElement(By.CssSelector("#login"));
        private IWebElement DisplayName => driver.FindElement(By.CssSelector("#greetings > b"));
        #endregion


        #region
        /* Page Actions */
        public void OpenHomePage()
        {
            var url = utils.GetBaseURL();
            driver.Url = url;
        }

        public void Login()
        {
            Name.SendKeys("John Smith");
            Password.SendKeys("12345");
            LoginButton.Click();
        }
        #endregion


        #region
        /* Page Checks */
        public bool IsLoginSuccessful()
        {
            return DisplayName.Text.Equals("John Smith");
        }
        #endregion
    }
}




  