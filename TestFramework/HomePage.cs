using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestFramework;

public class HomePage
{
    static string Url = "http://fs.to/";
    private static string PageTitle = "Рекомендательная сеть FS.to - онлайн фильмы, сериалы, музыка, игры, книги с возможностью скачивания";

    [FindsBy(How = How.LinkText, Using = "Фильмы")]
    private IWebElement filmLink;

    public void Goto()
    {
        Browser.Goto(Url);
    }

    public bool IsAt()
    {
        return Browser.Title == PageTitle;
    }

    public void SelectFilmPage(string authorName)
    {
        filmLink.Click();
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