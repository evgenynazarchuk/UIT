using OpenQA.Selenium;

namespace UIT
{
    public partial class WebBlock<WebPageType>
        where WebPageType : WebPage
    {
        protected static By ByCss(string selector) => By.CssSelector(selector);
        protected static By ByXPath(string selector) => By.XPath(selector);
        protected static By ById(string selector) => By.Id(selector);
        protected static By ByText(string selector) => By.LinkText(selector);
        protected static By ByPartialText(string selector) => By.PartialLinkText(selector);
    }
}
