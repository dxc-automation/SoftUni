using NUnit.Framework; 

namespace SoftUni
{
    [TestFixture]
    public class Test : TestBase
    {
        private HomePage homePage;



        [Test, Description("Tese_01 Open Amazon Home Page")]
        public void OpenHomePage()
        {
            testName = "Test Name";
            testDescription = "Test Description";
            logger.CreateTest(testName, testDescription);

            homePage = new HomePage(driver);

            homePage.OpenHomePage();
            assertions.CheckPageTitle(driver.Title, homePage.HomePageTitle);

            homePage.Login();

            logger.EndTest(testName, testDescription);

        }
    }
}
