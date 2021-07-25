using OpenQA.Selenium;
using System;

namespace UIT
{
    public partial class WebBlock<WebPageType>
        where WebPageType : WebPage
    {
        protected IClick Clickable;
        protected IClearText Сleanable;
        protected IAppendText Appendable;

        /// <summary>
        /// 
        /// </summary>
        protected virtual void UseDefaultAction()
        {
            UseSimpleAction();
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void UseSimpleAction()
        {
            UseSimpleClick();
            UseSimpleClearText();
            UseSimpleAppendText();
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void UseImplicitAction()
        {
            UseImplicitClick();
            UseImplicitClearText();
            UseImplicitAppendText();
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void UseSimpleClick()
        {
            Clickable = new SimpleClickAction(SourceElement);
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void UseImplicitClick()
        {
            Clickable = new ImplicitClickAction(BlockWaiter);
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void UseSimpleClearText()
        {
            Сleanable = new SimpleClearTextAction(SourceElement);
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void UseImplicitClearText()
        {
            Сleanable = new ImplicitClearTextAction(BlockWaiter);
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void UseSimpleAppendText()
        {
            Appendable = new SimpleAppendTextAction(SourceElement);
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void UseImplicitAppendText()
        {
            Appendable = new ImplicitAppendTextAction(BlockWaiter);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        protected virtual void Click(By selector)
        {
            Wait();
            BeforeTriggerAction();
            Clickable.Click(selector);
            AfterTriggerAction();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="ReturnPageType"></typeparam>
        /// <param name="selector"></param>
        /// <returns></returns>
        protected virtual ReturnPageType Click<ReturnPageType>(By selector)
            where ReturnPageType : WebPage
        {
            Click(selector);
            var page = new WebPage(Browser);
            return page as ReturnPageType;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        protected virtual void DoubleClick(By selector)
        {
            Wait();
            throw new ApplicationException("Double click is not implement");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        protected virtual void RightClick(By selector)
        {
            Wait();
            throw new ApplicationException("Right click is not implement");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        protected virtual void Hover(By selector)
        {
            Wait();
            throw new ApplicationException("Hover is not implement");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        protected virtual void ClearText(By selector)
        {
            Wait();
            BeforeTriggerAction();
            Сleanable.ClearText(selector);
            AfterTriggerAction();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="text"></param>
        protected virtual void AppendText(By selector, string text)
        {
            Wait();
            BeforeTriggerAction();
            Appendable.AppendText(selector, text);
            AfterTriggerAction();
        }
    }
}
