using OpenQA.Selenium;

namespace FrameworkTests
{
    public class CommonConditions
    {
        protected static IWebDriver driver;

        [SetUp]
        protected void SetUp()
        {
            driver = DriverSingleton.GetDriver();
        }

        [TearDown]
        protected void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                TakeScreenshot();
            }
            driver.Dispose();
        }

        private static void TakeScreenshot()
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            var screenshotPath = Path.Combine("screenshots", $"screenshot_{DateTime.Now:yyyyMMdd_HHmmss}.png");
            screenshot.SaveAsFile(screenshotPath);
        }
    }
}
