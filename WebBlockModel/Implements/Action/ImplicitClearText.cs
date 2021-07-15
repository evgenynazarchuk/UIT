using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebComponentModel
{
    public class ImplicitClearText : IClearText
    {
        protected DefaultWait<ISearchContext> Context;

        public ImplicitClearText(DefaultWait<ISearchContext> context)
        {
            Context = context;
        }

        public void ClearText(By selector)
        {
            Context.Until(WaitCondition.ClearText(selector));
        }
    }
}
