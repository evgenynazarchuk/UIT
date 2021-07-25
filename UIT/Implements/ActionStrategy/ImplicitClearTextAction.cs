using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UIT
{
    public class ImplicitClearTextAction : IClearText
    {
        protected DefaultWait<ISearchContext> Context;

        public ImplicitClearTextAction(DefaultWait<ISearchContext> context)
        {
            Context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        public void ClearText(By selector)
        {
            Context.Until(ExtCondition.ClearText(selector));
        }
    }
}
