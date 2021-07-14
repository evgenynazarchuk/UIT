using OpenQA.Selenium;
using WebComponentModel.Implements;

namespace WebComponentModel.Models
{
    public class SubBlockB : WebBlock
    {
        public SubBlockB(WebBlock webBlockParent, By selector)
            : base(webBlockParent, selector) { }
    }
}
