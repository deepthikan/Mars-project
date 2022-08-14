using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;




namespace MARSProject.Utilities
{
    public class WaitHelpers
    {

        public static void WaitToBeClickable(IWebDriver driver, int seconds, string locator, string locatorvalue)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            if (locatorvalue == "XPath")
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorvalue)));
            }

            if (locatorvalue == "Id")
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorvalue)));
            }

            if (locatorvalue == "CssSelector")
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorvalue)));
            }


        }
        public static void WaitToExists(IWebDriver driver, int seconds, string locator, string locatorvalue)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            if (locatorvalue == "XPath")
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locatorvalue)));
            }

            if (locatorvalue == "Id")
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locatorvalue)));
            }

            if (locatorvalue == "CssSelector")
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(locatorvalue)));
            }

        }
    }
}
