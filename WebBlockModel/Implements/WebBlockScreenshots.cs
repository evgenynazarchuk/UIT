using OpenQA.Selenium;
using System.Drawing;
using System.IO;

namespace WebComponentModel
{
    public partial class WebBlock
    {
        protected virtual Bitmap TakePageScreenshot()
        {
            Wait();
            var screenshotService = Browser.Driver as ITakesScreenshot;
            var screenshot = screenshotService.GetScreenshot();
            var image = Image.FromStream(new MemoryStream(screenshot.AsByteArray)) as Bitmap;
            return image;
        }

        protected virtual Bitmap TakeWebBlockScreenshot()
        {
            Wait();
            var screenshotService = Browser.Driver as ITakesScreenshot;
            var screenshot = screenshotService.GetScreenshot();
            var image = Image.FromStream(new MemoryStream(screenshot.AsByteArray)) as Bitmap;
            var imageBlock = image.Clone(new Rectangle(SourceElement.Location, SourceElement.Size), image.PixelFormat);
            return imageBlock;
        }

        public static byte[] ImageToByte(Bitmap image)
        {
            using var stream = new MemoryStream();
            image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            return stream.ToArray();
        }

        public virtual void SaveImageToDisk(string filepath, Bitmap image)
        {
            image.Save(filepath, System.Drawing.Imaging.ImageFormat.Png);
        }

        public virtual void SendImageToWeb(string url) { }
    }
}
