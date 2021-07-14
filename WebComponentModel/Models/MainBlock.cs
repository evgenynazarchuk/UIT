using OpenQA.Selenium;
using WebComponentModel.Implements;

namespace WebComponentModel.Models
{
    public class MainBlock : WebBlock
    {
        public MainBlock(Browser browser, By selector)
            : base(browser, selector) { }

        public SubBlockA SubA => new(this, By.CssSelector("//suba"));
        public SubBlockB SubB => new(this, By.CssSelector("//subb"));
    }
}
