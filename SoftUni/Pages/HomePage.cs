using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace SoftUni
{
    public class HomePage 
    {
        private IWebDriver driver;
        Utils utils = new Utils();
        TestBase testBase = new TestBase();

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }


        /*    Page Elements   */
        public string HomePageTitle = "Amazon.com: Online Shopping for Electronics, Apparel, Computers, Books, DVDs & more";

        [FindsBy(How = How.XPath, Using = "//div[@id='nav-flyout-anchor']/div[10]/div[2]/a[1]")]
        public IWebElement headerSignInBtn;


        /*    Page Actions    */
        public void OpenHomePage()
        {
            var url = utils.GetBaseURL();
            driver.Url = url;
        }

        public void ClickSignInPopupBtn()
        {
            testBase.wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(3));
            
            if (headerSignInBtn.Displayed == true)
            {
                headerSignInBtn.Click();
            }
        }
    }
}




  