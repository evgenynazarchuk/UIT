using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebBlockModel
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="browser"></param>
        /// <param name="selector"></param>
        public WebBlock(Browser browser)
        {
            Browser = browser;
            Selector = ByXPath("//html");
            ParentBlock = this;
            RootBlock = this;
            SourceElement = Browser.Waiter.Until(WaitCondition.Find(Selector));
            Waiter = new DefaultWait<ISearchContext>(SourceElement)
            {
                Timeout = TimeSpan.FromSeconds(ImplicitActionTime)
            };

            UseDefaultAction();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parentWebBlock"></param>
        /// <param name="selector"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="RootBlock"></typeparam>
        /// <returns></returns>
        public virtual RootBlock ReturnToRootBlock<RootBlock>()
            where RootBlock : WebBlock
            => this.RootBlock as RootBlock;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="ParentBlock"></typeparam>
        /// <returns></returns>
        public virtual ParentBlock ReturnToParentBlock<ParentBlock>()
            where ParentBlock : WebBlock
            => this.ParentBlock as ParentBlock;
    }
}
