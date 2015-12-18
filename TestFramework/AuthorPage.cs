using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

public class AuthorPage
{
    [FindsBy(How = How.CssSelector, Using = "")]
    private IWebElement authorName;
    public string AuthorName
    {
        get { return authorName.Text; }
    }
}