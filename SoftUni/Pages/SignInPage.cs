﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUni
{
    public class SignInPage
    {
        private IWebDriver driver;
        Utils utils = new Utils();

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
        }



        /*    Page Elements   */
        public string SignInPageTitle = "Amazon Sign-In";

        [FindsBy(How = How.XPath, Using = "//input[@id='ap_email']")]
        public IWebElement inputEmail;



        /*    Page Actions    */
        public void EnterUserEmail()
        {
            var username = utils.GetUserName();
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy((By)inputEmail));
            inputEmail.SendKeys(username);
            inputEmail.Submit();
        }
    }
}
