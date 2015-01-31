using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;


namespace Project.Pages
{
    public class GmailUserPage:BasePage
    {

        public GmailUserPage(IWebDriver _driver)
            : base(_driver)
        {


        }
    }
}
