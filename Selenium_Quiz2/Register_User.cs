using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using Selenium_Quiz2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Quiz2
{
    public class Register_User : Base_Class
    {

        Base_Class bs1 = new Base_Class();
        By Login_btn = By.XPath("//*[@id='header']/div/div/div/div[2]/div/ul/li[4]/a");
        By Verifysigup = By.CssSelector("#form > div > div > div:nth-child(3) > div > h2");
        By name = By.XPath("//*[@id=\"form\"]/div/div/div[3]/div/form/input[2]");
        By Email = By.XPath("//*[@id=\"form\"]/div/div/div[3]/div/form/input[3]");
        By Signup_btn = By.XPath("//*[@id=\"form\"]/div/div/div[3]/div/form/button");
        By Enter_ac_info = By.XPath("//*[@id=\"form\"]/div/div/div/div[1]/h2/b");
        By title = By.Id("id_gender1");
        By pass = By.XPath("//*[@id='password']");
        By select_day = By.XPath("//*[@id='days']");
        By select_month = By.XPath("//*[@id='months']");
        By select_year = By.XPath("//*[@id='years']");
        By newsletter = By.Id("newsletter");
        By special_offer = By.Id("optin");
        By First_name = By.Id("first_name");
        By last_name = By.Id("last_name");
        By Company = By.Id("company");
        By Address = By.Id("address1");
        By Address1 = By.Id("address2");
        By Country = By.XPath("//*[@id='country']");
        By state = By.XPath("//* [@id='state']");
        By city = By.XPath("//*[@id='city']");
        By zipcode = By.XPath("//*[@id='zipcode']");
        By mobile = By.XPath("//*[@id='mobile_number']");
        By create_ac = By.XPath("//*[@id='form']/div/div/div/div[1]/form/button");
        By Acc_created = By.XPath("//*[@id=\"form\"]/div/div/div/h2/b");
        By Continue_btn = By.XPath("//*[@id=\"form\"]/div/div/div/div/a");
        By Username = By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[10]/a/b");
        
        public void ClickSignUp_Btn()
        {
            //Verify_Homepage_Visibility();
            log.Info("Homepage is verify Successfully");
/*            driver.Url = "http://automationexercise.com";
            Assert.AreEqual("https://automationexercise.com/", driver.Url);*/
            bs1.click(Login_btn);
            log.Info("lOGIN OR Signup button is clicked ");
            var signup_verify = driver.FindElement(Verifysigup);
            string Actual_result = signup_verify.Text;
            Assert.AreEqual("New User Signup!", Actual_result);
            type(name, "Humayun Mushtaq");
            type(Email, "hmushtaq.inbox22@gmail.com");
            bs1.click(Signup_btn);
            TakeScreenShot();
        }
        public void RegisterUser()
        {
            ClickSignUp_Btn();
            var Ac_verify = driver.FindElement(Enter_ac_info);
            string Actual_result1 = Ac_verify.Text;
            Assert.AreEqual("ENTER ACCOUNT INFORMATION", Actual_result1);
            var element = driver.FindElement(title);
            Actions action = new Actions(driver);
            action.Click(element).Build().Perform();
            type(pass, "Humayun786");
            select_date();
            select_month1();
            select_year1();
            click(newsletter);
            click(special_offer);
            type(First_name, "Humayun");
            type(last_name, "Mushtaq");
            type(Company, "Contour");
            type(Address, "Street 8 , 54800 ,Lahore");
            type(Address1, "Lahore");

            var country = driver.FindElement(Country);
            var selectdrpdown3 = new SelectElement(country); ;
            selectdrpdown3.SelectByValue("India");

            type(state, "Punjab");
            type(city, "Lahore");
            type(zipcode, "54800");
            type(mobile, "03013324144");
            click(create_ac);

            var Acc_created1 = driver.FindElement(Acc_created);
            string Actual_result3 = Acc_created1.Text;
            Assert.AreEqual("ACCOUNT CREATED!", Actual_result3);
            TakeScreenShot();
            click(Continue_btn);
            var value = driver.FindElement(Username);
            string result = value.Text; 
            Assert.AreEqual("Humayun Mushtaq", result);
        }
        public void select_date()
        {
            var select_day1 = driver.FindElement(select_day);
            var selectdrpdown = new SelectElement(select_day1); ;
            selectdrpdown.SelectByValue("15");
        }
        
        public void select_month1()
        {
            var select_month1 = driver.FindElement(select_month);
            var selectdrpdown1 = new SelectElement(select_month1); ;
            selectdrpdown1.SelectByValue("2");
        }
        public void select_year1()
        {
            var select_year1 = driver.FindElement(select_year);
            var selectdrpdown2 = new SelectElement(select_year1); ;
            selectdrpdown2.SelectByValue("2020");
        }
    }
}

