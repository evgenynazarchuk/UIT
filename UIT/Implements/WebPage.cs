using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace UIT
{
    public class WebPage
    {
        public readonly Browser Browser;
        public readonly WebDriverWait PageWaiter;

        // TODO: to config
        public readonly int DefaultWaiterTimeout = 60;

        public WebPage(Browser browser)
        {
            Browser = browser;
            PageWaiter = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(DefaultWaiterTimeout));
        }

        protected virtual void Wait() { }

        protected virtual void Click(By selector)
        {
            Wait();
            PageWaiter.Until(ExtCondition.Click(selector));
        }

        protected virtual void ClearText(By selector)
        {
            Wait();
            PageWaiter.Until(ExtCondition.ClearText(selector));
        }

        protected virtual void AppendText(By selector, string text)
        {
            Wait();
            PageWaiter.Until(ExtCondition.AppendText(selector, text));
        }

        protected virtual IWebElement Find(By selector)
        {
            Wait();
            return PageWaiter.Until(ExtCondition.Find(selector));
        }
    }
}
