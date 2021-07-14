using OpenQA.Selenium;
using WebComponentModel.Implements;

namespace WebComponentModel.Models
{
    public class SubBlockA : WebBlock
    {
        public SubBlockA(WebBlock webBlockParent, By selector)
            : base(webBlockParent, selector) { }

        public SubBlockB SubB => new(this, By.CssSelector("//subb"));
    }
}
