using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUni
{
    public class LoginPage
    {
        private IWebDriver driver;
        Utils utils = new Utils();

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        #region Page Elements
        public string LoginPageTitle = "Gmail";
        public string LoginPageURL = "https://accounts.google.com/";

        [FindsBy(How = How.XPath, Using = "//input[@id='identifierId']")]
        [CacheLookup]
        public IWebElement inputEmail { get; set; }
        #endregion


        #region Page Actions
        public void OpenLoginPage()
        {
            driver.Url = LoginPageURL;
        }
        #endregion
    }
}
