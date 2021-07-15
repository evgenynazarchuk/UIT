using OpenQA.Selenium;

namespace WebBlockModel.Models
{
    public class BlockB : WebBlock
    {
        public BlockB(WebBlock webBlockParent, By selector)
            : base(webBlockParent, selector) { }

        public string Name => Find(ByCss("//name")).Text.Trim();
    }
}
