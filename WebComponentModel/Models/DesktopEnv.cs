using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebComponentModel.Implements;

namespace WebComponentModel.Models
{
    public class DesktopEnv : Env
    {
        public override MainBlock Open()
        {
            var driver = new ChromeDriver();
            var browser = new Browser(driver);
            return new MainBlock(browser, By.XPath("//html"));
        }
    }
}
