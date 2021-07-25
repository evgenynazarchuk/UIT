using OpenQA.Selenium;
using System.Collections.Generic;

namespace UIT
{
    public partial class WebBlock<WebPageType>
        where WebPageType : WebPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        protected virtual IWebElement Find(By selector)
        {
            Wait();
            return BlockWaiter.Until(ExtCondition.Find(selector));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        protected virtual IReadOnlyCollection<IWebElement> Finds(By selector)
        {
            Wait();
            return BlockWaiter.Until(ExtCondition.Finds(selector));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
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
