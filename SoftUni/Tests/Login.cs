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
            var signInPage = new SignInPage(driver);
            PageFactory.InitElements(driver, signInPage);

            var homePage = new HomePage(driver);
            PageFactory.InitElements(driver, homePage);
           

            homePage.OpenHomePage();
            assertions.CheckPageTitle(driver.Title, homePage.HomePageTitle);

            homePage.headerSignInBtn.Click();
            assertions.CheckPageTitle(driver.Title, signInPage.SignInPageTitle);

            signInPage.inputEmail.SendKeys(utils.GetUserName());
            signInPage.inputEmail.Submit();
        }
    }
}
