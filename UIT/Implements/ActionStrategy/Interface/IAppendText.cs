using OpenQA.Selenium;

namespace UIT
{
    public interface IAppendText
    {
        void AppendText(By selector, string text);
    }
}
