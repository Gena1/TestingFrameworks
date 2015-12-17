using System;

namespace TestFramework
{
    public static class Pages
    {
        public static class HomePage
        {
            static string Url = "https://www.pluralsight.com/";
            private static string PageTitle = "With Pluralsight, I was able to learn at my own pace, on my own time. Pluralsight gave me the tools that I need to express myself creatively.";

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
