using OpenQA.Selenium;

namespace WebBlockModel.Models
{
    public class MainBlock : WebBlock
    {
        public MainBlock(Browser browser, By selector)
            : base(browser, selector) { }

        /// <summary>
        /// parameterless constructor is required
        /// </summary>
        public MainBlock() { }

        public BlockA BlockA => new(this, ByCss("//blockA"));
        public BlockB BlockB => new(this, ByCss("//blockB"));
    }
}