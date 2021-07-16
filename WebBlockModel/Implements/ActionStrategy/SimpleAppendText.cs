using OpenQA.Selenium;

namespace WebBlockModel
{
    public class SimpleAppendText : IAppendText
    {
        protected IWebElement Element;

        public SimpleAppendText(IWebElement element)
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
