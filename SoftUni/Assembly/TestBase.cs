using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SoftUni
{
    
    public abstract class TestBase
    {
        public static IWebDriver driver;
        public static Utils utils = new Utils();
        public Assertions assertions = new Assertions();
        public static ExtentLogger logger   = new ExtentLogger();

        public string testName;
        public string testDescription;


        /* Initialize browser and set browser options */
        [OneTimeSetUp]
        public void Init()
        {
           driver = BrowserInit();
        }


        [SetUp]
        public void InitLogger()
        {
        }


        [TearDown]
        public void TearDownLogger()
        {
        }


        /* Close browser application */
        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Dispose();
            driver.Quit();
        }



        public IWebDriver BrowserInit()
        {
            var chromePath = utils.GetProjectPath() + "\\Resources";
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
    }
}