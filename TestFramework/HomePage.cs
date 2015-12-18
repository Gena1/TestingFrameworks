using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestFramework;

public class HomePage
{
    static string Url = "https://www.pluralsight.com/";
    private static string PageTitle = "With Pluralsight, I was able to learn at my own pace, on my own time. Pluralsight gave me the tools that I need to express myself creatively.";

    [FindsBy(How = How.LinkText, Using = "Authors")]
    private IWebElement authorLink;

    public void Goto()
    {
        Browser.Goto(Url);
    }

    public bool IsAt()
    {
        return Browser.Title == PageTitle;
    }

    public void SelectAuthor(string authorName)
    {
        authorLink.Click();
        var author = Browser.Driver.FindElement(By.LinkText(authorName));
        author.Click();
    }

    public bool IsAtAuthorPage(string authorName)
    {
        var authorPage = new AuthorPage();
        PageFactory.InitElements(Browser.Driver, authorPage);
        return authorPage.AuthorName == authorName;
    }
}