using OpenQA.Selenium;

namespace WebComponentModel.Implements
{
    public class Browser
    {
        public readonly IWebDriver Driver;
        public Browser(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
