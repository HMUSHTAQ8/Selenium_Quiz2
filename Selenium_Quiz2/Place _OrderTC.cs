using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Quiz2
{
    [TestClass]
    public class Place__OrderTC
    {
        Place__Order porder= new Place__Order();
        Base_Class bc = new Base_Class();
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
        public void place_ordercheckout()
        {
            porder.placeorder();
        }
    }
}
