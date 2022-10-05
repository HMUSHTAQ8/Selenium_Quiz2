using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Quiz2
{
    [TestClass]
    public class Ruser_existingemail_TC
    {
        Base_Class bc = new Base_Class();
        Ruser_existingemail ruser1=new Ruser_existingemail();
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
        public void Verifyuserwithexistingemail()
        {
            ruser1.Ruserwithexistingemail();
        }
    }
}
