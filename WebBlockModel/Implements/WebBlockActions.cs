using OpenQA.Selenium;
using System;

namespace WebBlockModel
{
    public partial class WebBlock
    {
        protected IClick Clickable;
        protected IClearText Сleanable;
        protected IAppendText Appendable;

        /// <summary>
        /// 
        /// </summary>
        protected virtual void UseDefaultAction()
        {
            UseImplicitAction();
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
            Clickable = new SimpleClick(SourceElement);
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void UseImplicitClick()
        {
            Clickable = new ImplicitClick(Waiter);
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void UseSimpleClearText()
        {
            Сleanable = new SimpleClearText(SourceElement);
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void UseImplicitClearText()
        {
            Сleanable = new ImplicitClearText(Waiter);
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void UseSimpleAppendText()
        {
            Appendable = new SimpleAppendText(SourceElement);
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void UseImplicitAppendText()
        {
            Appendable = new ImplicitAppendText(Waiter);
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
        /// <typeparam name="WebBlockType"></typeparam>
        /// <param name="selector"></param>
        /// <returns></returns>
        protected virtual WebBlockType Click<WebBlockType>(By selector)
            where WebBlockType : WebBlock, new()
        {
            Click(selector);
            var webBlock = new WebBlock(Browser);
            return webBlock as WebBlockType;
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
