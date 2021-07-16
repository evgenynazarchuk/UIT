using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebBlockModel
{
    public class ImplicitClearText : IClearText
    {
        protected DefaultWait<ISearchContext> Context;

        public ImplicitClearText(DefaultWait<ISearchContext> context)
        {
            Context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        public void ClearText(By selector)
        {
            Context.Until(WaitCondition.ClearText(selector));
        }
    }
}
