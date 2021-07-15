﻿using OpenQA.Selenium;

namespace WebComponentModel
{
    public class SimpleAppendText : IAppendText
    {
        protected IWebElement Element;

        public SimpleAppendText(IWebElement element)
        {
            Element = element;
        }

        public void AppendText(By selector, string text)
        {
            Element.FindElement(selector).SendKeys(text);
        }
    }
}