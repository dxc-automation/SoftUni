using OpenQA.Selenium;


namespace SoftUni
{
    public class HomePage : TestBase
    { 
        public HomePage(IWebDriver webDriver)
        {
            webDriver = driver;
        }


        /* Page Elements */
        public string HomePageTitle = "Amazon.com: Online Shopping for Electronics, Apparel, Computers, Books, DVDs & more";

        private IWebElement headerSignInBtn => driver.FindElement(By.XPath("//div[@id='nav-flyout-abAccountLink']"));



        /* Page Actions */
        public void OpenHomePage()
        {
            var url = utils.GetBaseURL();
            driver.Url = url;
        }

        public void Login()
        {
            if (headerSignInBtn.Displayed == true)
            {
                headerSignInBtn.Click();
            }
        }
    }
}




  