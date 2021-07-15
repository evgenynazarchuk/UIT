using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebComponentModel
{
    public class ImplicitAppendText : IAppendText
    {
        protected DefaultWait<ISearchContext> Context;

        public ImplicitAppendText(DefaultWait<ISearchContext> context)
        {
            Context = context;
        }

        public void AppendText(By selector, string text)
        {
            Context.Until(WaitCondition.AppendText(selector, text));
        }
    }
}
