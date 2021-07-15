using OpenQA.Selenium;

namespace WebBlockModel
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
