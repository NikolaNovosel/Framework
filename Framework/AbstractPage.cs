using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Framework
{
    public abstract class AbstractPage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;
        protected Actions actions;
        public abstract AbstractPage OpenPage();
        protected AbstractPage(IWebDriver driver)
        {
            this.driver = driver;
            actions = new Actions(driver);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }
    }
}
