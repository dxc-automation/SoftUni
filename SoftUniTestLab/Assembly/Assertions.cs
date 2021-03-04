using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationTestLab
{
    public class Assertions
    {
        IWebDriver driver;

        public Assertions()
        {
            driver = null;
        }


        /* Check current web page title */
        public void CheckPageTitle(string actualPageTitle, string expectedPageTitle)
        {
            Assert.AreEqual(expectedPageTitle, actualPageTitle);
        }
    }
}
