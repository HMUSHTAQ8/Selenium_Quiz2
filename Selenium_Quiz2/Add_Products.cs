using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_Quiz2
{
    public class Add_Products :Base_Class
    {
        By product_btn = By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[2]/a");
        By product1 = By.XPath("(//i[@class='fa fa-shopping-cart'])[2]");
        By Contin_btn = By.XPath("//*[@id=\"cartModal\"]/div/div/div[3]/button");
        By product2 = By.XPath("(//i[@class='fa fa-shopping-cart'])[4]");
        By view_Cart = By.XPath("//*[@id='cartModal']/div/div/div[2]/p[2]/a");
        By Ist_product = By.XPath("//*[@id=\"product-1\"]/td[2]/h4/a");
        By Sec_product = By.XPath("//*[@id=\"product-2\"]/td[2]/h4/a");
        public void Add_Product()
        {
            url_function();
            Verify_Homepage_Visibility();
            click(product_btn);
            ScrollToElement(product1);
            click(product1);
            Thread.Sleep(2000);
            click(Contin_btn);
            click(product2);
            Thread.Sleep(2000);
            click(view_Cart);
            var element = driver.FindElement(Ist_product);
            string Actual_result1 = element.Text;
            Assert.AreEqual("Blue Top", Actual_result1);

            var element1 = driver.FindElement(Sec_product);
            string Actual_result12 = element1.Text;
            Assert.AreEqual("Men Tshirt", Actual_result12);

        }
    }
}
