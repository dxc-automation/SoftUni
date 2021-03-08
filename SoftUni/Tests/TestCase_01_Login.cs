using NUnit.Framework;
using SeleniumExtras.PageObjects;

namespace SoftUni
{
    [TestFixture]
    public class Login : TestBase
    {
        private string testName = "User Login";
        private string testDescription = "The purpose of this test is to verify that user can sign in successfully";


        [SetUp]
        public void startReport()
        { 
            logger.StartTestReport(testName, testDescription);
        }



        [TearDown]
        public void endReport()
        {
            logger.GetResults(testName);
        }



        [Test]
        public void UserLogin()
        {
            var loginPage = new LoginPage(driver);
            PageFactory.InitElements(driver, loginPage);

            var homePage = new HomePage(driver);
            PageFactory.InitElements(driver, homePage);

            loginPage.OpenLoginPage();
            assertions.CheckPageTitle(driver.Title, loginPage.LoginPageTitle);

            loginPage.inputEmail.SendKeys(utils.GetUserName());
            loginPage.inputEmail.Submit();
        }
    }
}
