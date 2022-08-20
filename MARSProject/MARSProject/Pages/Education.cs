using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARSProject.Pages
{
    public class Education
    {
        public void addEducation(IWebDriver driver, string CollegeName, string Country, string Title, string Degree, string Year)
        {
            //Identify education tab and click on it
            IWebElement educationTab = driver.FindElement(By.LinkText("Education"));
            educationTab.Click();

            //Identify add new button and click on it
            IWebElement addNewButton = driver.FindElement(By.XPath("//thead/tr[1]/th[6]/div[1]"));
            addNewButton.Click();

            // Identify college name textbox and enter valid data
            IWebElement addCollegeName = driver.FindElement(By.Name("instituteName"));
            addCollegeName.SendKeys(CollegeName);

            // Identify country dropdown and send select valid country
            SelectElement countryDropDown = new SelectElement(driver.FindElement(By.Name("country")));
            countryDropDown.SelectByValue(Country);

            // Identify title dropdown and select valid title
            SelectElement titleDropdown = new SelectElement(driver.FindElement(By.Name("title")));
            titleDropdown.SelectByValue(Title);

            // Identify degree textbox and enter valid data
            IWebElement degreeTextbox = driver.FindElement(By.Name("degree"));
            degreeTextbox.SendKeys(Degree);

            // Identify year dropdown and select valid year
            SelectElement yearDropdown = new SelectElement(driver.FindElement(By.Name("yearOfGraduation")));
            yearDropdown.SelectByValue(Year);

            // Identify add button and click on it
            IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addButton.Click();
            Thread.Sleep(4000);
        }

        public string getEducationTableDetails(IWebDriver driver)
        {
            //Thread.Sleep(3000);
            //WaitHelpers.WaitToBeClickable(driver, 10, "Name", "name");
            IWebElement newEducation = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]"));
            return newEducation.GetAttribute("outerText").ToString();
        }

        public void editEducation(IWebDriver driver, string CollegeName, string Country, string Title, string Degree, string Year)
        {
            //click education tab
            IWebElement educationTab = driver.FindElement(By.LinkText("Education"));
            educationTab.Click();

            //Identify edit button and click on it
            IWebElement editButton = driver.FindElement(By.XPath("//tbody/tr[1]/td[6]/span[1]/i[1]"));
            editButton.Click();

            // edit college name textbox
            IWebElement collegeNameTextbox = driver.FindElement(By.Name("instituteName"));
            collegeNameTextbox.Clear();
            collegeNameTextbox.SendKeys(CollegeName);

            // edit country dropdown
            SelectElement countryDropDown = new SelectElement(driver.FindElement(By.Name("country")));
            countryDropDown.SelectByValue(Country);

            // edit title dropdown 
            SelectElement titleDropdown = new SelectElement(driver.FindElement(By.Name("title")));
            titleDropdown.SelectByValue(Title);

            // edit degree textbox
            IWebElement degreeTextbox = driver.FindElement(By.Name("degree"));
            degreeTextbox.Clear();
            degreeTextbox.SendKeys(Degree);

            // edit year dropdown 
            SelectElement yearDropdown = new SelectElement(driver.FindElement(By.Name("yearOfGraduation")));
            yearDropdown.SelectByValue(Year);

            // Identify Update button and click on it
            IWebElement updateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateButton.Click();
            Thread.Sleep(4000);
        }

        public void deleteEducation(IWebDriver driver)
        {
            //click education tab
            IWebElement educationTab = driver.FindElement(By.LinkText("Education"));
            educationTab.Click();

            // Identify delete button click on it
            IWebElement deleteEducation = driver.FindElement(By.XPath("//tbody/tr[1]/td[6]/span[2]/i[1]"));
            deleteEducation.Click();
            Thread.Sleep(3000);

        }

        public void validatingEducation(IWebDriver driver)
        {
            //Go to education tab and click on it
            IWebElement educationTab = driver.FindElement(By.LinkText("Education"));
            educationTab.Click();

            //Identify add new button and click on it
            IWebElement addNewButton = driver.FindElement(By.XPath("//thead/tr[1]/th[6]/div[1]"));
            addNewButton.Click();

            //Identify college name by entering null values
            IWebElement collegeTextbox = driver.FindElement(By.Name("instituteName"));
            collegeTextbox.SendKeys(String.Empty);

            //Identify add button 
            IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addButton.Click();

        }
        public string getEduErrorMessage(IWebDriver driver)
        {
            //verifying valid error message is displayed or not
            IWebElement validatingEduErrorMessage = driver.FindElement(By.XPath("//div[contains(text(),'Please enter all the fields')]"));
            return validatingEduErrorMessage.Text;
        }

    }
}
