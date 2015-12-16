using System;

namespace TestFramework
{
    public static class Pages
    {
        public static class HomePage
        {
            static string Url = "http://google.com/";
            private static string PageTitle = "Google";

            public static void Goto()
            {
                Browser.Goto(Url);
            }

            public static bool IsAt()
            {
               return Browser.Title == PageTitle;
            }
        }
    }
           
}
