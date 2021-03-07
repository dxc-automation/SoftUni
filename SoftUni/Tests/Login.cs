using NUnit.Framework; 

namespace SoftUni
{
    [TestFixture]
    public class Login : TestBase
    {
        private HomePage homePage;



        [Test]
        public void OpenHomePage()
        {
            testName = "Test Name";
            testDescription = "Test Description";
 //           logger.CreateTest(testName, testDescription);

            homePage = new HomePage(driver);

            homePage.OpenHomePage();
            assertions.CheckPageTitle(driver.Title, homePage.HomePageTitle);

            homePage.Login();

    //        logger.EndTest(testName, testDescription);

        }
    }
}
