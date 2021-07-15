using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace WebComponentModel
{
    public static class WaitCondition
    {
        public static Func<ISearchContext, bool> Click(By selector)
        {
            bool condition(ISearchContext context)
            {
                try
                {
                    context.FindElement(selector).Click();
                }
                catch
                {
                    return false;
                }
                return true;
            }

            return condition;
        }

        public static Func<ISearchContext, bool> ClearText(By selector)
        {
            bool condition(ISearchContext context)
            {
                try
                {
                    context.FindElement(selector).Clear();
                }
                catch
                {
                    return false;
                }
                return true;
            }

            return condition;
        }

        public static Func<ISearchContext, bool> AppendText(By selector, string text)
        {
            bool condition(ISearchContext context)
            {
                try
                {
                    context.FindElement(selector).SendKeys(text);
                }
                catch
                {
                    return false;
                }
                return true;
            }

            return condition;
        }

        public static Func<ISearchContext, bool> IsDisplayed(By selector)
        {
            bool condition(ISearchContext context)
            {
                IWebElement element;

                try
                {
                    element = context.FindElement(selector);
                }
                catch
                {
                    return false;
                }

                return element.Displayed && element.Enabled ? true : false;
            }

            return condition;
        }

        public static Func<ISearchContext, bool> IsNotDisplayed(By selector)
        {
            bool condition(ISearchContext context)
            {
                IWebElement element;

                try
                {
                    element = context.FindElement(selector);
                }
                catch
                {
                    return false;
                }

                return true;
            }

            return condition;
        }

        public static Func<ISearchContext, IWebElement> Find(By selector)
        {
            IWebElement condition(ISearchContext context)
            {
                IWebElement element;

                try
                {
                    element = context.FindElement(selector);
                }
                catch
                {
                    return null;
                }

                return element.Displayed && element.Enabled ? element : null;
            }

            return condition;
        }

        public static Func<ISearchContext, IReadOnlyCollection<IWebElement>> Finds(By selector)
        {
            IReadOnlyCollection<IWebElement> condition(ISearchContext context)
            {
                IReadOnlyCollection<IWebElement> elements;

                try
                {
                    elements = context.FindElements(selector);
                }
                catch
                {
                    return null;
                }

                return elements.Count > 0 ? elements : null;
            }

            return condition;
        }
    }
}
