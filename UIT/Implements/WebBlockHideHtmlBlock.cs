using System.Collections.Generic;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;

namespace UIT
{
    public partial class WebBlock<WebPageType>
        where WebPageType : WebPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        public virtual void HideHtmlBlock(By selector)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectors"></param>
        public virtual void HideHtmlBlocks(List<By> selectors)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        public virtual void HidePaageHtmlBlock(By selector)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectors"></param>
        public virtual void HidePageHtmlBlocks(List<By> selectors)
        {
        }
    }
}
