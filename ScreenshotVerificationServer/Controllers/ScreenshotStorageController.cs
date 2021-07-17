using Microsoft.AspNetCore.Mvc;
using ScreenshotVerificationServer.Models;

namespace ScreenshotVerificationServer.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ScreenshotStorageController : ControllerBase
    {
        [HttpGet]
        public void UploadScreenshot([FromBody] ScreenshotInfo screenshotInfo)
        {
        }
    }
}
