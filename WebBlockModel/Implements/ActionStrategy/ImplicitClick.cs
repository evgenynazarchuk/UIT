using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebBlockModel
{
    public class ImplicitClick : IClick
    {
        protected DefaultWait<ISearchContext> Context;

        public ImplicitClick(DefaultWait<ISearchContext> context)
        {
            Context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        public void Click(By selector)
        {
            Context.Until(WaitCondition.Click(selector));
        }
    }
}
