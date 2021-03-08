using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUni
{
    public class SignInPage : TestBase
    {
        private IWebDriver driver;

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
        }



        /*    Page Elements   */
        public string SignInPageTitle = "Amazon Sign-In";

        private IWebElement inputEmail => driver.FindElement(By.XPath("//input[@id='ap_email']"));



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
