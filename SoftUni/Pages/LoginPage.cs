using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SoftUni
{
    public class LoginPage
    {
        private IWebDriver driver;
        private Utils utils = new Utils();

        /*    Page Constructor    */
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        /*    Page Elements     */
        public string LoginPageTitle = "Gmail";
        public string LoginPageURL = "https://accounts.google.com/";

        public IWebElement EmailInputField => driver.FindElement(By.XPath("//input[@id='identifierId']"));


        /*    Page Actions      */
        public void OpenLoginPage()
        {
            driver.Url = LoginPageURL;
        }

        public void AddUsername()
        {
            EmailInputField.SendKeys(utils.GetUserName());
            EmailInputField.Submit();
        }
    }
}
