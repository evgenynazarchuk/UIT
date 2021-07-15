using OpenQA.Selenium;

namespace WebComponentModel
{
    public partial class WebBlock
    {
        protected virtual void Wait() { }

        protected virtual void WaitNg2()
        {
            IJavaScriptExecutor js = Browser.Driver as IJavaScriptExecutor;

            Root.Waiter.Until(driver =>
            {
                return (bool)js.ExecuteScript("return getAllAngularTestabilities().findIndex(x=>!x.isStable()) === -1");
            });
        }
    }
}