using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;

namespace SoftUni
{
    public class ExtentLogger : TestBase
    {

        public static  ExtentReports       extent;
        public static  ExtentTest          test;
        private static ExtentHtmlReporter  htmlReporter;
        private static string exception { get; }



        private ExtentHtmlReporter getHtmlReporter()
        {
            htmlReporter = new ExtentHtmlReporter(utils.GetProjectPath() + "\\Report\\TestReport.html");
            htmlReporter.LoadConfig(utils.GetProjectPath() + "\\Resources\\extent-config.xml");
            return htmlReporter;
        }


        public ExtentReports GetExtent() 
        {
            if (extent != null) {
                return extent;
            }

            extent = new ExtentReports();
                extent.AttachReporter(getHtmlReporter());
                extent.AttachReporter(htmlReporter);
            return extent;
        }


        public void StartTestReport(string testName, string testDescription)
        {
            extent = GetExtent();
            test   = extent.CreateTest(
                "<b>" + testName + "</b>",
                "<pre><center>"
                        + "<center><b>* * * * * * * *    I N F O R M A T I O N    * * * * * * * *</b></center>"
                        + "<p align=justify>"
                        + testDescription
                        + "</p>"
                        + "</pre>");
            extent.AnalysisStrategy = AnalysisStrategy.Test;
        }


  
        public void GetResults(string testName)
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "" + TestContext.CurrentContext.Result.StackTrace + "";
            var errorMessage = TestContext.CurrentContext.Result.Message;

            if (status == TestStatus.Failed)
            {
                test.Fail("<pre><b>[Test Failed]\n</b>" + testName + "\n<b>[Error Message]\n</b>" + errorMessage + "<b>\n[StackTrace]\n</b>" + stackTrace);
                test.Fail("Exception Came!");
            }
            else if (status == TestStatus.Passed)
            {
                test.Pass("Description: " + testName + " [" + status + "] No of Assertions Passed: " + TestContext.CurrentContext.AssertCount);
            }
            else if (status == TestStatus.Skipped)
            {
                test.Skip("" + status);
            }
            EndReport();
        }
    

        public void EndReport()
        {
            extent.Flush();           
        }
    }
}

