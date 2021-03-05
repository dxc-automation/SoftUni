using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SoftUni
{
    [TestFixture]
    public abstract class TestBase
    {
        public static IWebDriver driver;
        public Assertions assertions = new Assertions();
        public Utils utils = new Utils();


        public IWebDriver BrowserInit()
        {
            var chromePath = utils.GetProjectPath() + "/Resources";
            var browser = utils.GetBrowser();
            switch (browser)
            {
                case "Chrome":            
                    driver = new ChromeDriver(chromePath);
                    break;

                case "Firefox":
                    driver = new FirefoxDriver();
                    break;

                default:
                    driver = new FirefoxDriver();
                    break;
            }
            driver.Manage().Window.Maximize();
            return driver;
        }


        /* Initialize browser and set browser options */
        [OneTimeSetUp]
        public void Init()
        {
           driver = BrowserInit();
        }

   


        /* Close browser application */
        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Dispose();
            driver.Quit();
        }
    }
}