﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

namespace SoftUni
{
    public class TestBase
    {
        public IWebDriver driver;
        public WebDriverWait wait;
        public Utils utils = new Utils();

        public static Assertions assertions = new Assertions();
        public static ExtentLogger logger   = new ExtentLogger();


        #region Pages
        public LoginPage loginPage;
        #endregion


        #region Before & After Suite
        /* Initialize browser and set browser options */
        [OneTimeSetUp]
        public void BeforeSuite()
        {
            LaunchBrowser();
        }

        /* Close browser application */
        [OneTimeTearDown]
        public void AfterSuite()
        {
            driver.Dispose();
            driver.Quit();
        }
        #endregion




        public IWebDriver LaunchBrowser()
        {
            var chromePath = utils.GetProjectPath() + "\\Resources\\chromedriver.exe";
            var firefoxPath = utils.GetProjectPath() + "\\Resources\\";
            var browser = utils.GetBrowser();

            switch (browser)
            { 
                case "Chrome":
                    driver = new ChromeDriver(chromePath);
                    break;

                case "Firefox":
                    driver = new FirefoxDriver(firefoxPath);
                    break;

                default:
                    driver = new FirefoxDriver(firefoxPath);
                    break;
            }
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}