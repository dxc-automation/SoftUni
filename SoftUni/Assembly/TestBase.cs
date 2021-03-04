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
        private string baseURL;
        private string browser;
        public Assertions assertions = new Assertions();
        public Utils utils = new Utils();


        public IWebDriver BrowserInit()
        {
            browser = utils.GetBrowser();
            switch (browser)
            {
                case "Chrome":
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("start-maximized");
                    driver = new ChromeDriver(options);
                    break;

                case "Firefox":
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    break;

                default:
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    break;
            }
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