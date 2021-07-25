using OpenQA.Selenium;

namespace UIT
{
    public class SimpleClickAction : IClick
    {
        protected IWebElement Element;

        public SimpleClickAction(IWebElement element)
        {
            Element = element;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        public void Click(By selector)
        {
            Element.FindElement(selector).Click();
        }
    }
}
