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
                .SubA.ReturnToParent<MainBlock>()
                .SubA.SubB.ReturnToRoot<MainBlock>()
                .SubB.ReturnToRoot<MainBlock>()
                .SubB.StayHere()
                .Assert(x =>
                {
                    Assert.Equal("ExpectedName", x.Name);
                });
        }
    }
}
