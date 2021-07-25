using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UIT
{
    public class ImplicitAppendTextAction : IAppendText
    {
        protected DefaultWait<ISearchContext> ElementWaiter;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="elementWaiter"></param>
        public ImplicitAppendTextAction(DefaultWait<ISearchContext> elementWaiter)
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
            ElementWaiter.Until(ExtCondition.AppendText(selector, text));
        }
    }
}
