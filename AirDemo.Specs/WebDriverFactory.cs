﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;

namespace HOTELpinSight
{
    static class WebDriverFactory
    {
        /// <summary>
        /// Create an instance of a web driver.
        /// </summary>
        /// <returns></returns>
        internal static IWebDriver Create()
        {
            IWebDriver driver = CreateChromeDriver();
            // IWebDriver driver = CreateIEDriver();
            // IWebDriver driver = CreateFirefoxDriver();
            return driver;
        }

        private static IWebDriver CreateChromeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--window-size=1280,720");
            // options.AddArgument("--start-maximized");
            // options.AddArgument("headless"); // This would be added if running on a server through Jenkins.

            IWebDriver driver = new ChromeDriver(options);
            return driver;
        }

        private static IWebDriver CreateIEDriver()
        {
            IWebDriver driver = new InternetExplorerDriver();
            return driver;
        }

        private static IWebDriver CreateFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }
    }
}
