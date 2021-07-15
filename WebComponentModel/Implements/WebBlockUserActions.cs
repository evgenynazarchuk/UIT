using OpenQA.Selenium;
using System;

namespace WebComponentModel
{
    public partial class WebBlock
    {
        protected IClick Clickable;
        protected IClearText Сleanable;
        protected IAppendText Appendable;

        protected virtual void UseDefaultAction()
        {
            UseImplicitAction();
        }

        protected virtual void UseSimpleAction()
        {
            UseSimpleClick();
            UseSimpleClearText();
            UseSimpleAppendText();
        }

        protected virtual void UseImplicitAction()
        {
            UseImplicitClick();
            UseImplicitClearText();
            UseImplicitAppendText();
        }

        protected virtual void UseSimpleClick()
        {
            Clickable = new SimpleClick(SourceElement);
        }

        protected virtual void UseImplicitClick()
        {
            Clickable = new ImplicitClick(Waiter);
        }

        protected virtual void UseSimpleClearText()
        {
            Сleanable = new SimpleClearText(SourceElement);
        }

        protected virtual void UseImplicitClearText()
        {
            Сleanable = new ImplicitClearText(Waiter);
        }

        protected virtual void UseSimpleAppendText()
        {
            Appendable = new SimpleAppendText(SourceElement);
        }

        protected virtual void UseImplicitAppendText()
        {
            Appendable = new ImplicitAppendText(Waiter);
        }

        protected virtual void Click(By selector)
        {
            Wait();
            BeforeTriggerAction();
            Clickable.Click(selector);
            AfterTriggerAction();
        }

        protected virtual void DoubleClick(By selector)
        {
            Wait();
            throw new ApplicationException("Double click is not implement");
        }

        protected virtual void RightClick(By selector)
        {
            Wait();
            throw new ApplicationException("Right click is not implement");
        }

        protected virtual void Hover(By selector)
        {
            Wait();
            throw new ApplicationException("Hover is not implement");
        }

        protected virtual void ClearText(By selector)
        {
            Wait();
            BeforeTriggerAction();
            Сleanable.ClearText(selector);
            AfterTriggerAction();
        }

        protected virtual void AppendText(By selector, string text)
        {
            Wait();
            BeforeTriggerAction();
            Appendable.AppendText(selector, text);
            AfterTriggerAction();
        }
    }
}
