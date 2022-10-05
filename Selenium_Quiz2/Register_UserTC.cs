using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium_Quiz2;
using System;

namespace Selenium_Quiz2
{

    [TestClass]
    public class Register_UserTC : Base_Class
    {
        Register_User Ruser = new Register_User();
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
        public void RegisterUserWithvalidData()
        {
            Ruser.RegisterUser();
        }
    }
}
