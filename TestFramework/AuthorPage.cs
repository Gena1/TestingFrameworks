using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestFramework
{
    public class FilmPage
    {
        [FindsBy(How = How.CssSelector, Using = "p.b-section-menu__title")]
        private IWebElement categoryFilm;
        public string CategoryFilm
        {
            get { return categoryFilm.Text; }
        }
    }
}