using NUnit.Framework;


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
        public void OpenHomePage()
        {
            signInPage = new SignInPage(driver);
            homePage = new HomePage(driver);
           

            homePage.OpenHomePage();
            assertions.CheckPageTitle(driver.Title, homePage.HomePageTitle);

            homePage.ClickSignInPopupBtn();

            signInPage.EnterUserEmail();
        }
    }
}
