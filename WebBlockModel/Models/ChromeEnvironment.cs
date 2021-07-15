using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebBlockModel.Models
{
    public class ChromeEnvironment : Environment
    {
        public override MainBlock Open()
        {
            var driver = new ChromeDriver();
            var browser = new Browser(driver);
            return new MainBlock(browser, By.XPath("//html"));
        }
    }
}
