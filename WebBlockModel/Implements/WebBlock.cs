using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebComponentModel
{
    public partial class WebBlock
    {
        protected readonly Browser Browser;
        protected readonly By Selector;
        protected readonly WebBlock ParentBlock;
        protected readonly WebBlock RootBlock;
        protected readonly IWebElement SourceElement;
        protected readonly DefaultWait<ISearchContext> Waiter;
        protected readonly int ImplicitActionTime = 60;

        public WebBlock(Browser browser, By selector)
        {
            Browser = browser;
            Selector = selector;
            ParentBlock = this;
            RootBlock = this;
            SourceElement = Browser.Waiter.Until(WaitCondition.Find(selector));
            Waiter = new DefaultWait<ISearchContext>(SourceElement)
            {
                Timeout = TimeSpan.FromSeconds(ImplicitActionTime)
            };

            UseDefaultAction();
        }

        public WebBlock(WebBlock parentWebBlock, By selector)
        {
            Browser = parentWebBlock.Browser;
            Selector = selector;
            ParentBlock = parentWebBlock;
            RootBlock = ParentBlock.RootBlock;
            SourceElement = ParentBlock.Find(selector);
            Waiter = new DefaultWait<ISearchContext>(SourceElement)
            {
                Timeout = TimeSpan.FromSeconds(ImplicitActionTime)
            };

            UseDefaultAction();
        }

        public virtual RootBlock ReturnToRootBlock<RootBlock>()
            where RootBlock : WebBlock
            => this.RootBlock as RootBlock;

        public virtual ParentBlock ReturnToParentBlock<ParentBlock>()
            where ParentBlock : WebBlock
            => this.ParentBlock as ParentBlock;
    }
}
