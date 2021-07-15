using WebBlockModel.Models;
using Xunit;

namespace WebBlockModel
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var env = new ChromeEnvironment();
            var MainBlock = env.Open();

            MainBlock
                .BlockA.ReturnToParentBlock<MainBlock>()
                .BlockA.BlockB.ReturnToRootBlock<MainBlock>()
                .BlockB.ReturnToRootBlock<MainBlock>()
                .BlockB.SetCurrentBlock()
                .Assert(x =>
                {
                    Assert.Equal("ExpectedName", x.Name);
                });
        }
    }
}
