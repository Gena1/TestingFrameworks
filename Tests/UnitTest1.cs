using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Go_To_HomePage()
        {
            Pages.HomePage.Goto();
            Assert.IsTrue(Pages.HomePage.IsAt());
        }

        [TestMethod]
        public void Can_Go_To_FilmPage()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.SelectFilm("a.b-subsection-menu__item.m-films");
            Assert.IsTrue(Pages.HomePage.IsAtFilmPage("Фильмы"));
        }

        //[TestCleanup]
        //public void CleanUp()
        //{
        //    Browser.Close();
        //}
    }
}
