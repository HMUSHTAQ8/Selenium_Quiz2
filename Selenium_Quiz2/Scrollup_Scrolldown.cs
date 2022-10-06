using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_Quiz2
{
    public class Scrollup_Scrolldown:Base_Class
    {
        Verify_Subscription subscrip =new Verify_Subscription();
        By Findtext = By.XPath("//*[@id=\"slider-carousel\"]/div/div[1]/div[1]/h2");
        public void scrolldown_up_assert()
        {
            subscrip.Assert_subscriptiontext();
            Thread.Sleep(1000);
            ScrollToTop();

            var verify_text = driver.FindElement(Findtext);
            string Actual_result3 = verify_text.Text;

            Assert.AreEqual("Full-Fledged practice website for Automation Engineers", Actual_result3);
        }
    }
}
