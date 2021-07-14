using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace WebComponentModel.Implements
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
            SourceElement = Browser.Driver.FindElement(selector);
            Waiter = new DefaultWait<ISearchContext>(SourceElement)
            {
                Timeout = TimeSpan.FromSeconds(ExtImplicitWait)
            };
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
        }

        protected virtual void Click(By selector)
        {
            BeforeTriggerAction();

            AfterTriggerAction();
        }

        protected virtual void DoubleClick(By selector)
        {
            BeforeTriggerAction();

            AfterTriggerAction();
        }

        protected virtual void RightClick(By selector)
        {
            BeforeTriggerAction();

            AfterTriggerAction();
        }

        protected virtual void Hover(By selector)
        {
            BeforeTriggerAction();

            AfterTriggerAction();
        }

        protected virtual void ClearText(By selector)
        {
            BeforeTriggerAction();

            AfterTriggerAction();
        }

        protected virtual void AppendText(By selector, string text)
        {
            BeforeTriggerAction();

            AfterTriggerAction();
        }

        protected virtual IWebElement Find(By selector)
        {
            BeforeTriggerAction();

            return null;
        }

        protected virtual IReadOnlyCollection<IWebElement> Finds(By selector)
        {
            BeforeTriggerAction();

            return null;
        }

        protected virtual IWebElement FindOrNull(By selector)
        {
            Wait();
            BeforeTriggerAction();

            return null;
        }

        protected virtual IReadOnlyCollection<IWebElement> FindsOrEmpty(By selector)
        {
            Wait();
            BeforeTriggerAction();

            return null;
        }

        protected virtual void Wait() { }

        public virtual RootBlock ReturnToRoot<RootBlock>()
            where RootBlock : WebBlock
            => Root as RootBlock;

        public virtual ParentBlock ReturnToParent<ParentBlock>()
            where ParentBlock : WebBlock
            => Parent as ParentBlock;
    }
}
