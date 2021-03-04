using Microsoft.VisualBasic.CompilerServices;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationTestLab
{
    [TestFixture]
    public abstract class TestBase : WebDriverInit
    {
        public static IWebDriver driver;

        public Assertions assertions = new Assertions();
        public Utils utils;


        /* Initialize browser and set browser options */
        [OneTimeSetUp]
        public void Init()
        {
           driver = BrowserInit();
        }

   



        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}