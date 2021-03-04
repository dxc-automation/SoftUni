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

        private IWebElement Name => driver.FindElement(By.CssSelector("#name"));
        private IWebElement Password => driver.FindElement(By.CssSelector("#password"));
        private IWebElement LoginButton => driver.FindElement(By.CssSelector("#login"));
        private IWebElement DisplayName => driver.FindElement(By.CssSelector("#greetings > b"));


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


        /* Page Checks */
        public bool IsLoginSuccessful()
        {
            return DisplayName.Text.Equals("John Smith");
        }
    }
}




  