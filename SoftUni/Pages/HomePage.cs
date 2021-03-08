using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SoftUni
{
    public class HomePage : TestBase
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }



        /*    Page Elements   */
        public string HomePageTitle = "Amazon.com: Online Shopping for Electronics, Apparel, Computers, Books, DVDs & more";

        private IWebElement headerSignInBtn => driver.FindElement(By.XPath("//header/div[@id='navbar']/div[@id='nav-flyout-anchor']/div[10]/div[2]/a[1]"));


        /*    Page Actions    */
        public void OpenHomePage()
        {
            var url = utils.GetBaseURL();
            driver.Url = url;
        }

        public void ClickSignInPopupBtn()
        {
            if (headerSignInBtn.Displayed == true)
            {
                headerSignInBtn.Click();
            }
        }
    }
}




  