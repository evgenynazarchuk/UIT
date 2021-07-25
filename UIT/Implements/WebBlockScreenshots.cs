using OpenQA.Selenium;
using System.Drawing;
using System.IO;

namespace UIT
{
    public partial class WebBlock<WebPageType>
        where WebPageType : WebPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected virtual Bitmap TakePageScreenshot()
        {
            Wait();
            var screenshotService = Browser.Driver as ITakesScreenshot;
            var screenshot = screenshotService.GetScreenshot();
            var image = Image.FromStream(new MemoryStream(screenshot.AsByteArray)) as Bitmap;
            return image;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected virtual Bitmap TakeWebBlockScreenshot()
        {
            Wait();
            var screenshotService = Browser.Driver as ITakesScreenshot;
            var screenshot = screenshotService.GetScreenshot();
            var image = Image.FromStream(new MemoryStream(screenshot.AsByteArray)) as Bitmap;
            var imageBlock = image.Clone(new Rectangle(SourceElement.Location, SourceElement.Size), image.PixelFormat);
            return imageBlock;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static byte[] ImageToByte(Bitmap image)
        {
            using var stream = new MemoryStream();
            image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            return stream.ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="image"></param>
        public virtual void SaveImageToDisk(string filepath, Bitmap image)
        {
            image.Save(filepath, System.Drawing.Imaging.ImageFormat.Png);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        public virtual void SendImageToWeb(string url) { }
    }
}
