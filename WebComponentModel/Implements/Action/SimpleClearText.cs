using OpenQA.Selenium;

namespace WebComponentModel
{
    public class SimpleClearText : IClearText
    {
        protected IWebElement Element;

        public SimpleClearText(IWebElement element)
        {
            Element = element;
        }

        public void ClearText(By selector)
        {
            Element.FindElement(selector).Clear();
        }
    }
}
