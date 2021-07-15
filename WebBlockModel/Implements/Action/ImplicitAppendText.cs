using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebBlockModel
{
    public class ImplicitAppendText : IAppendText
    {
        protected DefaultWait<ISearchContext> Context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public ImplicitAppendText(DefaultWait<ISearchContext> context)
        {
            Context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="text"></param>
        public void AppendText(By selector, string text)
        {
            Context.Until(WaitCondition.AppendText(selector, text));
        }
    }
}
