using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_Quiz2
{
    
    public class Download_Invoice : Base_Class
    {
        Register_User Ruser1 = new Register_User();
        By view_pr_btn = By.XPath("/html/body/section[2]/div/div/div[2]/div[1]/div[2]/div/div[2]/ul/li/a");
        By add_to_cart = By.XPath("/html/body/section/div/div/div[2]/div[2]/div[2]/div/span/button");
        By view_Cart = By.XPath("//*[@id='cartModal']/div/div/div[2]/p[2]/a");
        By proceed_to_checkout = By.XPath("//*[@id=\"do_action\"]/div[1]/div/div/a");
        By resgister_login = By.XPath("//*[@id=\"checkoutModal\"]/div/div/div[2]/p[2]/a/u");
        By cart_btn = By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[3]/a");
        By address_detail = By.XPath("//*[@id=\"cart_items\"]/div/div[2]/h2");
        By order_review = By.XPath("//*[@id=\"cart_items\"]/div/div[4]/h2");
        By description_text = By.XPath("//*[@id=\"ordermsg\"]/textarea");
        By place_order = By.XPath("//*[@id=\"cart_items\"]/div/div[7]/a");
        By Name_on_card = By.XPath("//*[@id=\"payment-form\"]/div[1]/div/input");
        By card_Number = By.XPath("//*[@id=\"payment-form\"]/div[2]/div/input");
        By CVV_NO = By.XPath("//*[@id=\"payment-form\"]/div[3]/div[1]/input");
        By Ex_MM = By.XPath("//*[@id=\"payment-form\"]/div[3]/div[2]/input");
        By Ex_year = By.XPath("//*[@id=\"payment-form\"]/div[3]/div[3]/input");
        By pay_confirm = By.Id("submit");
        By Success_Message = By.XPath("//*[@id=\"form\"]/div/div/div/p");
        By download_btn = By.XPath("//*[@id=\"form\"]/div/div/div/a");
        By Contin_btn = By.XPath("//*[@id=\"form\"]/div/div/div/div/a");
        public void download_invoice()
        {
            //Verify_Homepage_Visibility();
            click(view_pr_btn);
            click(add_to_cart);
            Thread.Sleep(2000);
            click(view_Cart);
            string title = driver.Title;
            Assert.AreEqual("Automation Exercise - Checkout", title);
            click(proceed_to_checkout);
            click(resgister_login);
            Thread.Sleep(1000);
            Ruser1.RegisterUser();
            click(cart_btn);
            click(proceed_to_checkout);
            var Address_detail = driver.FindElement(address_detail);
            string Actual_result = Address_detail.Text;
            Assert.AreEqual("Address Details", Actual_result);

            var Order_detail = driver.FindElement(order_review);
            string Actual_result1 = Order_detail.Text;
            Assert.AreEqual("Address Details", Actual_result);
            type(description_text, "We have place the order successfully");
            click(place_order);
            type(Name_on_card, "Humayun");
            type(card_Number, "123456789");
            type(CVV_NO, "515");
            type(Ex_MM, "06");
            type(Ex_year, "2020");
            click(pay_confirm);

            var succes_verify = driver.FindElement(Success_Message);
            string Actual_result2 = succes_verify.Text;
            Assert.AreEqual("Congratulations! Your order has been confirmed!", Actual_result2);

            verify_downloadinvoice();
        }
        public void verify_downloadinvoice()
        {
            click(download_btn);
            Thread.Sleep(2000);
            var Path = @"C:\\Users\\hmush\\Downloads\\";
            string[] filePaths = Directory.GetFiles(Path);
            bool result =filePaths.Contains("invoice.txt");
            if (result == true)
            {
                Assert.IsTrue(true);
            }

            File.Delete("invoice.txt");
            click(Contin_btn);
        }
    }
}
