using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using SoftUni;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUni
{
    public class ExtentLogger : TestBase
    {
        public  ExtentReports extent;
        public  ExtentTest test;



        public void CreateTest(string testName, string testDescription)
        {

            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(utils.GetProjectPath() + "\\Report\\TestReport.html");
            htmlReporter.LoadConfig(utils.GetProjectPath() + "\\Resources\\logger-config.xml");
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);


            test = extent.CreateTest("<b>" + testName + "</b>",
                  "<pre>"
                          + "<center><b>* * * * * * * *    I N F O R M A T I O N    * * * * * * * *</b></center>"
                          + "<p align=justify>"
                          + testDescription
                          + "</p>"
                          + "</pre>");
        }


        public void EndTest(string testName, string testDescription)
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;

            try
            {
                if (status == NUnit.Framework.Interfaces.TestStatus.Failed)
                {
                    string stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace) ? ""
                    : string.Format("{0}", TestContext.CurrentContext.Result.StackTrace);
                    string errorMessage = TestContext.CurrentContext.Result.Message;
                    Console.WriteLine("\n ERROR MSG \n" + stacktrace);
                    string exception = TestContext.CurrentContext.Result.Message;
                    Console.WriteLine("\n ERROR  \n" + exception);
                    test.Fail("<pre>"
                            + "<br/>"
                            + "<center><b>* * * * * * * *    " + testName + "    * * * * * * * *</b></center>"
                            + "<br/>"
                            + "<br/>" + testDescription
                            + "<br/>"
                            + "<b>Error Message</b>"
                            + "<br/>"
                            + exception
                            + "<br/>"
                            + "<b>Stack Trace</b>"
                            + "<br/>"
                            + stacktrace
                            + "<br/>"
                        //    + GetResponseBody()
                            + "</pre>");
                }
                else
                {
                    test.Pass("<pre>"
                               + "<br/>"
                               + "<center><b>* * * * * * * *    " + testName + "    * * * * * * * *</b></center>"
                               + "<br/>"
                               + "<br/>" + testDescription
                               + "<br/>"
                               + "</pre>");
                }
            }
            catch (Exception e)
            {
                test.Fail(e.Message);
            }
            extent.Flush();
        }

        //      public IWebDriver GetDriver()
        //     {
        //        return driver;
        //   }


    }
}
