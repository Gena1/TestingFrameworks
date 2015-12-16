using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public static class Pages
    {
        public static class HomePage
        {
            public static void Goto()
            {
                Browser.Goto(Url)
            }

            protected static string Url = "http://pluralsight.com";

            public static bool IsAt()
            {
                throw new NotImplementedException();
            }
        }
    }
           
}
