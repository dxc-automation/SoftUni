using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni.Pages
{
    public class LambdaTestPage
    {
        private IWebDriver driver;
        private Utils utils = new Utils();

        public LambdaTestPage(IWebDriver driver)
        {
            this.driver = driver;
        }



        [FindsBy(How = How.XPath, Using = "//input[@id='sampletodotext']")]
        public IWebElement inputField;




        public void OpenLambdaTestPage()
        {
       //     driver.Url = utils.GetLambdaURL();
        }


        public void AddText(string text)
        {
            inputField.SendKeys(text);
        }
    }
}
