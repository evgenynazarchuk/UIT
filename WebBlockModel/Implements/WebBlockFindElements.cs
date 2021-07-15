using OpenQA.Selenium;
using System.Collections.Generic;

namespace WebComponentModel
{
    public partial class WebBlock
    {
        protected virtual IWebElement Find(By selector)
        {
            Wait();
            return Waiter.Until(WaitCondition.Find(selector));
        }

        protected virtual IReadOnlyCollection<IWebElement> Finds(By selector)
        {
            Wait();
            return Waiter.Until(WaitCondition.Finds(selector));
        }

        protected virtual IWebElement FindOrNull(By selector)
        {
            Wait();

            IWebElement element;
            try
            {
                element = SourceElement.FindElement(selector);
            }
            catch
            {
                element = null;
            }

            return element;
        }

        protected virtual IReadOnlyCollection<IWebElement> FindsOrEmpty(By selector)
        {
            Wait();

            IReadOnlyCollection<IWebElement> elements;
            try
            {
                elements = SourceElement.FindElements(selector);
            }
            catch
            {
                elements = new List<IWebElement>();
            }

            return elements;
        }
    }
}
