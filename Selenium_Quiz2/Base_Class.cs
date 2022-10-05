using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Selenium_Quiz2
{
    public class Base_Class
    {
        public static IWebDriver driver;
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IWebDriver SeleniumInit(string browser)
        {
            IWebDriver mydriver = null;
            if (browser == "Chrome")
            {
                /*ChromeOptions options = new ChromeOptions();
                options.AddArguments("--disable-notifications");*/
                mydriver = new ChromeDriver();
                driver = mydriver;
                driver.Manage().Window.Maximize();
                return driver;
            }
            else if (browser == "Edge")
            {
                mydriver = new EdgeDriver();
                driver = mydriver;
                return driver;
            }
            else if (browser == "Firefox")
            {
                mydriver = new FirefoxDriver();
                driver = mydriver;
                return driver;
            }
            return driver;
        }
        IWebElement findElement(By locator)
        {
            return driver.FindElement(locator);
        }
        public void type(By locator, String text)
        {
            IWebElement element = findElement(locator);
            element.Clear();
            element.SendKeys(text);
        }
        /*        public IWebElement onlylocater(By locator)
                {
                    IWebElement element = findElement(locator);
                    return element;
                }*/
        public void click(By locator)
        {
            findElement(locator).Click();
        }

        public void ScrollToElement(By by)
        {
            IWebElement element1 = findElement(by);
            //Scroll To Element
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element1);
        }
        public void url_function()
        {
            driver.Url = "http://automationexercise.com";
        }
        public void Verify_Homepage_Visibility()
        {
            Assert.AreEqual("https://automationexercise.com/", driver.Url);
        }

        public void TakeScreenShot()
        {
            // Taking a full-screen screenshot
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(@"D:\Selenium_Projects\Selenium_Quiz2\Selenium_Quiz2\Reports\", ScreenshotImageFormat.Png);

        }


    }
}

