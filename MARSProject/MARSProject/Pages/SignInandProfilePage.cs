 

using NUnit.Framework;
using OpenQA.Selenium;
using MARSProject.Utilities;

namespace MARSProject.Pages
{
    public class SignInandProfilePage: CommonDriver
    {
        //Sigin and Profile page objects
        IWebElement signInButton => driver.FindElement(By.LinkText("Sign In"));
        IWebElement emailAddressTextBox => driver.FindElement(By.Name("email"));
        IWebElement passwordTextBox => driver.FindElement(By.Name("password"));
        IWebElement loginButton => driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));
        IWebElement profileTab => driver.FindElement(By.LinkText("Profile"));



        public void signInActions()
        {
            //Launch Mars portal
            driver.Navigate().GoToUrl("http://192.168.1.190:5000/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            try
            {

                //Identify sign in button and click on it
               
                signInButton.Click();

                //Identify email address textbox enter valid email
                emailAddressTextBox.SendKeys("deepthikanchenadam@gmail.com");

                //Identify password textbox enter valid password
                
                passwordTextBox.SendKeys("123123");

                WaitHelpers.WaitToBeClickable(driver, 5, "XPath", "//button[contains(text(),'Login')]");

                //Identify login button and click on it
                loginButton.Click();

            }

            catch (Exception ex)
            {
                Assert.Fail("Mars portal did not launch", ex.Message);
            }
        }
        public void goToProfilePage()
        {
            // Go to homepage click on profile tab 
            profileTab.Click();

        }
    }
}