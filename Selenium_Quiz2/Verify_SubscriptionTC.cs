using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium_Quiz2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Quiz2
{
    [TestClass]
    public class Verify_SubscriptionTC : ExtentReport
    {
        Base_Class bc = new Base_Class();
        Verify_Subscription vs = new Verify_Subscription();
        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void GetTestContext(TestContext test)
        {
            LogReport("TestReport");

        }
        [ClassCleanup]
        public static void ClassCleanUp()
        {
            extentReports.Flush();
        }
        [TestInitialize]
        public void TestInit()
        {
            bc.SeleniumInit("Chrome");
            Console.WriteLine(TestContext.TestName);
            LogReport(TestContext.TestName);

        }
        [TestCleanup]
        public void TestCleanup()
        {
            //bc.driver.Close();
        }
        [TestMethod]
        public void Verify_subscribtion()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Subcription");
            vs.verify_subcrib();
        }
    }
}

