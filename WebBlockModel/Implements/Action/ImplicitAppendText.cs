using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebBlockModel
{
    public class ImplicitAppendText : IAppendText
    {
        protected DefaultWait<ISearchContext> ElementWaiter;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="elementWaiter"></param>
        public ImplicitAppendText(DefaultWait<ISearchContext> elementWaiter)
        {
            ElementWaiter = elementWaiter;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="text"></param>
        public void AppendText(By selector, string text)
        {
            ElementWaiter.Until(WaitCondition.AppendText(selector, text));
        }
    }
}
