using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UIT
{
    public class ImplicitClickAction : IClick
    {
        protected DefaultWait<ISearchContext> Context;

        public ImplicitClickAction(DefaultWait<ISearchContext> context)
        {
            Context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        public void Click(By selector)
        {
            Context.Until(ExtCondition.Click(selector));
        }
    }
}
