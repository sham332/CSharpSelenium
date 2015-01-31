using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;
namespace Project.Pages
{
    

    public class BasePage
    {
        public IWebDriver _driver;

        protected BasePage(IWebDriver driver)
        {
            this._driver = driver;

        }
        protected BasePage(IWebDriver driver,String Title)
        {
            this._driver = driver;
            
            if (!Title.Equals(_driver.Title))
            {
                string msg = "Page with title : " + Title + " is not found";
                //takescreenshot();
                throw new NoSuchWindowException(msg);
                
            }
        }

        public void takescreenshot(string filename)
        {
            Screenshot ss = ((ITakesScreenshot)this._driver).GetScreenshot();
            ss.SaveAsFile(filename, System.Drawing.Imaging.ImageFormat.Gif);
        }
    }
}
