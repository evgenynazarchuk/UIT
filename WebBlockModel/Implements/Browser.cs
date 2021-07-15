using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebBlockModel
{
    public class Browser
    {
        public readonly IWebDriver Driver;
        public readonly WebDriverWait Waiter;

        public Browser(IWebDriver driver)
        {
            Driver = driver;
            Waiter = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));
        }
    }
}
