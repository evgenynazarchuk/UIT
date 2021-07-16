using OpenQA.Selenium;

namespace WebBlockModel
{
    public partial class WebBlock
    {
        /// <summary>
        /// 
        /// </summary>
        protected virtual void Wait() { }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void WaitNg2()
        {
            IJavaScriptExecutor js = Browser.Driver as IJavaScriptExecutor;

            Browser.Waiter.Until(driver =>
            {
                return (bool)js.ExecuteScript("return getAllAngularTestabilities().findIndex(x => !x.isStable()) === -1");
            });
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void WaitJQuery()
        {
            IJavaScriptExecutor js = Browser.Driver as IJavaScriptExecutor;

            Browser.Waiter.Until(driver =>
            {
                return (bool)js.ExecuteScript("return jQuery.active === 0");
            });
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void WaitAnimation()
        {
            IJavaScriptExecutor js = Browser.Driver as IJavaScriptExecutor;

            Browser.Waiter.Until(driver =>
            {
                return (bool)js.ExecuteScript("return document.getAnimations().length === 0");
            });
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void WaitDocumentComplete()
        {
            IJavaScriptExecutor js = Browser.Driver as IJavaScriptExecutor;

            Browser.Waiter.Until(driver =>
            {
                return (bool)js.ExecuteScript("return document.readyState === \"complete\"");
            });
        }
    }
}