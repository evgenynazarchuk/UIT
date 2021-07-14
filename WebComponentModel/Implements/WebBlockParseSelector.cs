using OpenQA.Selenium;

namespace WebComponentModel.Implements
{
    public partial class WebBlock
    {
        protected By ByCss(string selector) => By.CssSelector(selector);
        protected By ByXPath(string selector) => By.XPath(selector);
    }
}
