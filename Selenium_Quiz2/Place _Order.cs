using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_Quiz2
{
    public class Place__Order : Base_Class
    {
        Download_Invoice din1 = new Download_Invoice();
        By Delete_btn = By.XPath("//a[@href=\"/delete_account\"]");
        By continue_btn = By.XPath("//a[contains(text() ,\"Continue\")]");
        public void placeorder()
        {
            din1.download_invoice();
            click(Delete_btn);
           // click(continue_btn);

        }

    }
}
