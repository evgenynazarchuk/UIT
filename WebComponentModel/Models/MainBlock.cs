using OpenQA.Selenium;
using WebComponentModel.Implements;

namespace WebComponentModel.Models
{
    public class MainBlock : WebBlock
    {
        public MainBlock(Browser browser, By selector)
            : base(browser, selector) { }

        public BlockA BlockA => new(this, ByCss("//blockA"));
        public BlockB BlockB => new(this, ByCss("//blockB"));
    }
}