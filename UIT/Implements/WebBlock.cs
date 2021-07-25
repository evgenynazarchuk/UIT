using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace UIT
{
    public partial class WebBlock<WebPageType>
        where WebPageType : WebPage
    {
        protected readonly Browser Browser;
        protected readonly WebPageType Page;
        protected readonly WebBlock<WebPageType> ParentBlock;
        protected readonly IWebElement SourceElement;
        protected readonly DefaultWait<ISearchContext> BlockWaiter;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="selector"></param>
        public WebBlock(WebPageType page, By selector)
        {
            Page = page;
            Browser = Page.Browser;
            ParentBlock = this;

            SourceElement = Page.PageWaiter.Until(ExtCondition.Find(selector));
            BlockWaiter = new DefaultWait<ISearchContext>(SourceElement)
            {
                Timeout = TimeSpan.FromSeconds(Page.DefaultWaiterTimeout)
            };

            UseDefaultAction();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parentWebBlock"></param>
        /// <param name="selector"></param>
        public WebBlock(WebBlock<WebPageType> parentWebBlock, By selector)
        {
            Browser = parentWebBlock.Browser;
            ParentBlock = parentWebBlock;
            Page = parentWebBlock.Page;

            SourceElement = ParentBlock.Find(selector);
            BlockWaiter = new DefaultWait<ISearchContext>(SourceElement)
            {
                Timeout = TimeSpan.FromSeconds(Page.DefaultWaiterTimeout)
            };

            UseDefaultAction();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="WebBlockType"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        public WebPageType VerifyThat<WebBlockType>(Action<WebBlockType> action)
            where WebBlockType : WebBlock<WebPageType>
        {
            action(this as WebBlockType);
            return Page;
        }
    }
}
