using OpenQA.Selenium;

namespace WebComponentModel
{
    public interface IAppendText
    {
        void AppendText(By selector, string text);
    }
}
