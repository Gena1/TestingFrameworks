using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

public class FilmPage
{
    [FindsBy(How = How.CssSelector, Using = "html body div.l-body-inner.m-theme-video div.l-body-inner-inner div.l-content-wrap div.l-content.m-content_state_without-gradient div.b-section-menu.m-themed p.b-section-menu__title")]
    private IWebElement categotyFilm;
    public string CategotyFilm
    {
        get { return categotyFilm.Text; }
    }

    public string categotyName { get; set; }
}