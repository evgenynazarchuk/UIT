namespace ScreenshotVerificationServer.Models
{
    public class ScreenshotInfo
    {
        public string ProjectName { get; set; }
        public string LaunchNumber { get; set; }
        public string ProjectVersion { get; set; }
        public string ScreenshotName { get; set; }
        public byte[] Screenshot { get; set; }
    }
}
