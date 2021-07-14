using OpenQA.Selenium;
using WebComponentModel.Implements;

namespace WebComponentModel.Models
{
    public class BlockA : WebBlock
    {
        public BlockA(WebBlock webBlockParent, By selector)
            : base(webBlockParent, selector) { }

        public BlockB BlockB => new(this, ByCss("//subb"));
    }
}
