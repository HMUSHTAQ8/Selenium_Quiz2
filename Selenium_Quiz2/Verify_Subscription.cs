using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Selenium_Quiz2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Quiz2
{
    public class Verify_Subscription : Base_Class
    {


        Base_Class bs2 = new Base_Class();
        By Subtext = By.XPath("//*[@id=\"footer\"]/div[2]/div/div/div[2]/div/h2");
        By email_field = By.Id("susbscribe_email");
        By arrow_btn = By.Id("subscribe");
        public void Assert_subscriptiontext()
        {
            Verify_Homepage_Visibility();
            ScrollToElement(Subtext);
            var verify_sub = driver.FindElement(Subtext);
            string Actual_result3 = verify_sub.Text;
            Assert.AreEqual("SUBSCRIPTION", Actual_result3);
        }
        public void verify_subcrib()
        {
            url_function();
            Assert_subscriptiontext();
            type(email_field, "hmushtaq.inbox@gmail.com");
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Text");
            click(arrow_btn);
            TakeScreenShot();
            
        }

    }
}
