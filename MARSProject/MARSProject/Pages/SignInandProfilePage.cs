 

using NUnit.Framework;
using OpenQA.Selenium;
using MARSProject.Utilities;

namespace MARSProject.Pages
{
    public class SignInandProfilePage 
    {
        public void signInActions(IWebDriver driver)
        {
            //Launch Mars portal
            driver.Navigate().GoToUrl("http://192.168.1.190:5000/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            try
            {

                //Identify sign in button and click on it
                IWebElement signInButton = driver.FindElement(By.LinkText("Sign In"));
                signInButton.Click();

                //Identify email address textbox enter valid email
                IWebElement emailAddressTextBox = driver.FindElement(By.Name("email"));
                emailAddressTextBox.SendKeys("deepthikanchenadam@gmail.com");

                //Identify password textbox enter valid password
                IWebElement passwordTextBox = driver.FindElement(By.Name("password"));
                passwordTextBox.SendKeys("123123");

                WaitHelpers.WaitToBeClickable(driver, 5, "XPath", "//button[contains(text(),'Login')]");

                //Identify login button and click on it
                IWebElement loginButton = driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));
                loginButton.Click();

            }

            catch (Exception ex)
            {
                Assert.Fail("Mars portal did not launch", ex.Message);
            }
        }
        public void goToProfilePage(IWebDriver driver)
        {
            // Go to homepage click on profile tab 
            IWebElement ProfileTab = driver.FindElement(By.LinkText("Profile"));
            ProfileTab.Click();

        }

    }
    } 