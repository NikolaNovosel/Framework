﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace FrameworkTests
{
    internal class DriverSingleton
    {
        private static IWebDriver driver;
        private DriverSingleton() { }
        internal static IWebDriver GetDriver(string browser = "chrome")
        {
            switch (browser.ToLower())
            {
                case "chrome":
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;
                case "firefox":
                    new DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;
                case "edge":
                    new DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    break;
                default:
                    throw new ArgumentException($"Browser '{browser}' is not supported.");
            }
            driver.Manage().Window.Maximize();

            return driver;
        }
    }
}

