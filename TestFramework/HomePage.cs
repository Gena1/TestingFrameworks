using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestFramework;

public class HomePage
{

    static string Url = "http://fs.to/";
    private static string PageTitle = "Рекомендательная сеть FS.to - онлайн фильмы, сериалы, музыка, игры, книги с возможностью скачивания";

    [FindsBy(How = How.CssSelector, Using = "a.b-main__sections-item-title")]
    private IWebElement filmLink;

    public void Goto()
    {
        Browser.Goto(Url);
    }

    public bool IsAt()
    {
        return Browser.Title == PageTitle;
    }

    public void SelectFilm(string film)
    {
        filmLink.Click();
        var filmcategory = Browser.Driver.FindElement(By.LinkText(film));
        filmcategory.Click();
    }

    public bool IsAtFilmPage(string category)
    {
        var filmPage = new FilmPage();
        PageFactory.InitElements(Browser.Driver, filmPage);
        return filmPage.CategoryFilm == category;
    }
}