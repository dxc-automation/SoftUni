using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni.Tests
{
    [TestFixture]
    public class TestCase_02_AddItem : TestBase
    {

        private string testName = "";
        private string testDescription = "The purpose of this test is to verify that user can sign in successfully";


        [SetUp]
        public void startReport()
        {
            logger.StartTestReport(testName, testDescription);
        }



        [TearDown]
        public void endReport()
        {
            logger.GetResults(testName);
        }


    }
}
