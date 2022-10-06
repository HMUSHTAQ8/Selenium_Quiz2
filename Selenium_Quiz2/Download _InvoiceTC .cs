using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Quiz2
{
    [TestClass]
    public class Download__InvoiceTC
    {
        Download_Invoice din = new Download_Invoice();
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
        public void downloaded_invoice()
        {
            bc.url_function();
            din.download_invoice();
        }
    }

}
