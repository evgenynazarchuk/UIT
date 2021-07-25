using OpenQA.Selenium;

namespace UIT
{
    public class SimpleClearTextAction : IClearText
    {
        protected IWebElement Element;

        public SimpleClearTextAction(IWebElement element)
        {
            Element = element;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        public void ClearText(By selector)
        {
            Element.FindElement(selector).Clear();
        }
    }
}
