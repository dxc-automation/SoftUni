using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationTestLab
{
    public class WebDriverInit 
    {
        private IWebDriver driver;
        private string baseURL;
        private string browser;


        /* Start browser */
        public IWebDriver BrowserInit()
        {
            browser = GetBrowser();
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

    }
}
