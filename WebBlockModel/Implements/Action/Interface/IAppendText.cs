using OpenQA.Selenium;

namespace WebBlockModel
{
    public interface IAppendText
    {
        void AppendText(By selector, string text);
    }
}
