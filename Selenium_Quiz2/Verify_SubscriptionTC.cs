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
    public class Verify_SubscriptionTC
    {
        Base_Class bc = new Base_Class();
        Verify_Subscription vs = new Verify_Subscription();
        [TestInitialize]
        public void TestInit()
        {
            bc.SeleniumInit("Chrome");
        }
        [TestCleanup]
        public void TestCleanup()
        {
            //bc.driver.Close();
        }
        [TestMethod]
        public void Verify_subscribtion()
        {
            vs.verify_subcrib();
        }
    }
}

