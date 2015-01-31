using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using OpenQA.Selenium;
using Project.Pages;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.PageObjects;
namespace Tests
{
    public class BaseTest
    {
        public static IWebDriver Driver { get; set; }
        
    }
}
