using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Quiz2
{
    public class Ruser_existingemail :Base_Class
    {
        Register_User ruser = new Register_User();
        By already_exist = By.CssSelector("#form > div > div > div:nth-child(3) > div > form > p");
        public void Ruserwithexistingemail()
        {
            ruser.ClickSignUp_Btn();
            var already_exist1 = driver.FindElement(already_exist);
            string Actual_result24 = already_exist1.Text;
            Assert.AreEqual("Email Address already exist!", Actual_result24);
        }
    }
}
