using Grpc.Core;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace ScreenshotVerificationServer
{
    public class ScreenshotService : Screenshot.ScreenshotBase
    {
        public ScreenshotService()
        {
        }

        public override Task<ScreenshotResponse> Upload(ScreenshotRequest request, ServerCallContext context)
        {
            return Task.FromResult(new ScreenshotResponse
            {
                Status = true
            });
        }
    }
}
