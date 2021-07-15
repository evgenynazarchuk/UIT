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

        /// <summary>
        /// 
        /// </summary>
        public void Refresh() => Driver.Navigate().Refresh();

        /// <summary>
        /// 
        /// </summary>
        public void Back() => Driver.Navigate().Back();

        /// <summary>
        ///
        /// </summary>
        public void Forward() => Driver.Navigate().Forward();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="WebBlockType"></typeparam>
        /// <param name="url"></param>
        /// <returns></returns>
        public WebBlockType GoToUrl<WebBlockType>(string url)
            where WebBlockType : WebBlock
        {
            Driver.Navigate().GoToUrl(url);
            var webBlock = new WebBlock(this);
            return webBlock as WebBlockType;
        }
    }
}
