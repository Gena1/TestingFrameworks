using System;
using System.Security.Policy;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace TestFramework
{
    public static class Browser
    {
        static IWebDriver webDriver = new RemoteWebDriver(new Uri("http://192.168.1.4:4444/wd/hub") ,
           new DesiredCapabilities("firefox", "", new Platform(PlatformType.XP)));

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static ISearchContext Driver
        {
            get { return webDriver; }            
        }

        public static void Goto(string url)
        {
            webDriver.Url = url;
        }

        public static void Close()
        {
            webDriver.Close();
        }

        
    }
}
