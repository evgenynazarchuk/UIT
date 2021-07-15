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

            RootBlock.Waiter.Until(driver =>
            {
                return (bool)js.ExecuteScript("return getAllAngularTestabilities().findIndex(x => !x.isStable()) === -1");
            });
        }
    }
}