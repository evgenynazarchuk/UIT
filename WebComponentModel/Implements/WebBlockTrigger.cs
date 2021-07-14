namespace WebComponentModel.Implements
{
    public partial class WebBlock
    {
        protected virtual void BeforeTriggerAction() { }
        protected virtual void AfterTriggerAction() { }

        protected virtual void BeforeClickAction() { }
        protected virtual void AfterClickAction() { }

        protected virtual void BeforeRightClickAction() { }
        protected virtual void AfterRightClickAction() { }

        protected virtual void BeforeHoverAction() { }
        protected virtual void AfterHoverAction() { }

        protected virtual void BeforeDoubleClickAction() { }
        protected virtual void AfterDoubleClickAction() { }

        protected virtual void BeforeAppendTextAction() { }
        protected virtual void AfterAppendTextAction() { }

        protected virtual void BeforeClearTextAction() { }
        protected virtual void AfterClearTextAction() { }
    }
}
