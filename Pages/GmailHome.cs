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
using Helper;

namespace Project.Pages
{
    public class GmailHomePage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "#Email")]
        private IWebElement textEmail;

        [FindsBy(How = How.CssSelector, Using = "#Passwd")]
        private IWebElement textPassword;

        [FindsBy(How = How.CssSelector, Using = "#signIn")]
        private IWebElement btnSignIn;

        [FindsBy(How = How.CssSelector, Using = ".gb_g.gb_i")]
        private IWebElement loggedInElement;
        
        private static readonly String Title = "Gmail";

        public GmailHomePage(IWebDriver _driver)
            : base(_driver, Title)
        {


        }

        public void LoginUser(string sUserName, String sPassword)
        {

            textEmail.SendKeys(sUserName);
            textPassword.SendKeys(sPassword);
            btnSignIn.Click();

            var elem = _driver.FindElement(By.CssSelector(".gb_g.gb_i"), 20);

            if (elem != null)
            {
                System.Console.WriteLine("Logged in successfully");
            }
            else
            {
                System.Console.WriteLine("Failed to login");
            }

        }
    }

}
