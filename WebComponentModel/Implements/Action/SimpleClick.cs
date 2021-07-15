using OpenQA.Selenium;

namespace WebComponentModel
{
    public class SimpleClick : IClick
    {
        protected IWebElement Element;

        public SimpleClick(IWebElement element)
        {
            Element = element;
        }

        public void Click(By selector)
        {
            Element.FindElement(selector).Click();
        }
    }
}
