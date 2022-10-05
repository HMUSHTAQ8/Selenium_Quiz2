using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Quiz2
{
    [TestClass]
    public class Scrollup_ScrolldownTC
    {
        Base_Class bc = new Base_Class();
        Scrollup_Scrolldown TC = new Scrollup_Scrolldown();
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
        public void Scrolldown()
        {
            TC.scrolldown_assert();
        }
    }
}
