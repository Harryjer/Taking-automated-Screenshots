using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace Screenshots
{
    class EntryPoint
    {
        static void Main()
        {
            IWebDriver chrome = new ChromeDriver();

            chrome.Navigate().GoToUrl("https://www.google.com/");

            Screenshot googleScreenshot = ((ITakesScreenshot)chrome).GetScreenshot();

            Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\screenshots");
            googleScreenshot.SaveAsFile(Directory.GetCurrentDirectory() + @"\screenshots\googlescreenshots.png", ScreenshotImageFormat.Png);

            chrome.Quit();
        }
    }
}
