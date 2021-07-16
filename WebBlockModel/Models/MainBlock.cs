namespace WebBlockModel.Models
{
    public class MainBlock : WebBlock
    {
        public MainBlock(Browser browser)
            : base(browser) { }

        public BlockA BlockA => new(this, ByCss("//blockA"));
        public BlockB BlockB => new(this, ByCss("//blockB"));
    }
}