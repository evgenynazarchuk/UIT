using WebComponentModel.Implements;
using WebComponentModel.Models;
using Xunit;

namespace WebComponentModel
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var env = new DesktopEnv();
            var MainBlock = env.Open();

            MainBlock
                .BlockA.ReturnToParent<MainBlock>()
                .BlockA.BlockB.ReturnToRoot<MainBlock>()
                .BlockB.ReturnToRoot<MainBlock>()
                .BlockB.StayHere()
                .Assert(x =>
                {
                    Assert.Equal("ExpectedName", x.Name);
                });
        }
    }
}
