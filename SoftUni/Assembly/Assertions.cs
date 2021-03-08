using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUni
{
    public class Assertions
    {

        /* Check current web page title */
        public void CheckPageTitle(string actualPageTitle, string expectedPageTitle)
        {
            Assert.AreEqual(expectedPageTitle, actualPageTitle);
        }
    }
}
