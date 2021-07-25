using OpenQA.Selenium;

namespace UIT
{
    public class SimpleAppendTextAction : IAppendText
    {
        protected IWebElement Element;

        public SimpleAppendTextAction(IWebElement element)
        {
            Element = element;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="text"></param>
        public void AppendText(By selector, string text)
        {
            Element.FindElement(selector).SendKeys(text);
        }
    }
}
