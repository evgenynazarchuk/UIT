using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebComponentModel
{
    public partial class WebBlock
    {
        protected readonly Browser Browser;
        protected readonly By Selector;
        protected readonly WebBlock Parent;
        protected readonly WebBlock Root;
        protected readonly IWebElement SourceElement;
        protected readonly DefaultWait<ISearchContext> Waiter;
        protected readonly int ExtImplicitWait = 60;

        public WebBlock(Browser browser, By selector)
        {
            Browser = browser;
            Selector = selector;
            Parent = this;
            Root = this;
            SourceElement = Browser.Waiter.Until(WaitCondition.Find(selector));
            Waiter = new DefaultWait<ISearchContext>(SourceElement)
            {
                Timeout = TimeSpan.FromSeconds(ExtImplicitWait)
            };

            UseDefaultAction();
        }

        public WebBlock(WebBlock webBlockParent, By selector)
        {
            Browser = webBlockParent.Browser;
            Selector = selector;
            Parent = webBlockParent;
            Root = Parent.Root;
            SourceElement = Parent.Find(selector);
            Waiter = new DefaultWait<ISearchContext>(SourceElement)
            {
                Timeout = TimeSpan.FromSeconds(ExtImplicitWait)
            };

            UseDefaultAction();
        }

        public virtual RootBlock ReturnToRoot<RootBlock>()
            where RootBlock : WebBlock
            => Root as RootBlock;

        public virtual ParentBlock ReturnToParent<ParentBlock>()
            where ParentBlock : WebBlock
            => Parent as ParentBlock;
    }
}
