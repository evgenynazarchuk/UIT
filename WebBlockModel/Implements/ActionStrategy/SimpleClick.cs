using OpenQA.Selenium;

namespace WebBlockModel
{
    public class SimpleClick : IClick
    {
        protected IWebElement Element;

        public SimpleClick(IWebElement element)
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
