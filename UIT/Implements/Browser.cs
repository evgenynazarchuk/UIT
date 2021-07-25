using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace UIT
{
    public class Browser
    {
        public readonly IWebDriver Driver;

        public Browser(IWebDriver driver)
        {
            Driver = driver;
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
        /// <typeparam name="WebPageType"></typeparam>
        /// <param name="url"></param>
        /// <returns></returns>
        public WebPageType GoToUrl<WebPageType>(string url)
            where WebPageType : WebPage
        {
            Driver.Navigate().GoToUrl(url);
            var page = new WebPage(this);
            return page as WebPageType;
        }
    }
}
