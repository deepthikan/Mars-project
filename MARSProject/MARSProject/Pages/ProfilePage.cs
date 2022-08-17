using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MARSProject.Utilities;
using System.Reflection.Emit;
using System.Diagnostics.Metrics;

namespace MARSProject.Pages
{
    public class ProfilePage
    {

        public void addNewSkills(IWebDriver driver, string Skills, string Level)
        {
            //Identify skills tab and click on it
            IWebElement skillsTab = driver.FindElement(By.LinkText("Skills"));
            skillsTab.Click();

            //Identify add new button and click on it
            IWebElement addNewButton = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
            addNewButton.Click();

            //Identify add skill and enter valid data
            IWebElement addSkillButton = driver.FindElement(By.Name("name"));
            addSkillButton.SendKeys(Skills);

            //Choose skill level from dropdown
            SelectElement levelDropDown = new SelectElement(driver.FindElement(By.Name("level")));
            levelDropDown.SelectByValue(Level);

            //click on add button
            IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addButton.Click();

            //WaitHelpers.WaitToBeClickable(driver, 10, "Xpath", "//tbody/tr[1]/td[3]/span[1]/i[1]");
            //WaitHelpers.WaitToBeClickable(driver, 10, "Name", "name");
        }
        public string getSkillsTableDetails(IWebDriver driver)
        {
            Thread.Sleep(3000);
            //WaitHelpers.WaitToBeClickable(driver, 10, "Name", "name");
            IWebElement newSkills = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]"));
            return newSkills.GetAttribute("outerText").ToString();
        }

        public void editSkills(IWebDriver driver, string Skills, string Level)
        {
            //Go to skills tab and click on it
            IWebElement skillsTab = driver.FindElement(By.LinkText("Skills"));
            skillsTab.Click();

            //click on edit button
            IWebElement editButton = driver.FindElement(By.XPath("//tbody/tr[1]/td[3]/span[1]/i[1]"));
            editButton.Click();

            //edit skills textbox
            IWebElement editSkillTextbox = driver.FindElement(By.Name("name"));
            editSkillTextbox.Clear();
            editSkillTextbox.SendKeys(Skills);

            //Choose skill level from dropdown
            SelectElement levelDropDown = new SelectElement(driver.FindElement(By.Name("level")));
            levelDropDown.SelectByValue(Level);

            //click on update button
            IWebElement updateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateButton.Click();

            Thread.Sleep(3000);
        }


        public void deleteSkills(IWebDriver driver)
        {
            //Go to skills tab and click on it
            IWebElement skillsTab = driver.FindElement(By.LinkText("Skills"));
            skillsTab.Click();

            // Identify delete button click on it
            IWebElement deleteSkillButton = driver.FindElement(By.XPath("//i[@class='remove icon']"));
            deleteSkillButton.Click();

            Thread.Sleep(3000);


        }


        public void validatingSkills(IWebDriver driver)
        {
            //Go to skills tab and click on it
            IWebElement ValidatingSkillsTab = driver.FindElement(By.LinkText("Skills"));
            ValidatingSkillsTab.Click();

            //verifying add new button and click on it
            IWebElement validatingAddNewButton = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
            validatingAddNewButton.Click();

            //verifying add skill button
            IWebElement validatingAddSkillButton = driver.FindElement(By.Name("name"));
            validatingAddSkillButton.SendKeys(String.Empty);

            //verifying add button
            IWebElement validatingAddButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            validatingAddButton.Click();

        }

        public string getErrorMessage(IWebDriver driver)
        {
            //verifying error message is displayed or not
            IWebElement validatingErrorMessage = driver.FindElement(By.XPath("//div[contains(text(),'Please enter skill and experience level')]"));
            return validatingErrorMessage.Text;
        }

        public void addEducation(IWebDriver driver, string CollegeName, string Country, string Title, string Degree, string Year)
        {
            //Identify education tab and click on it
            IWebElement addEducation = driver.FindElement(By.LinkText("Education"));
            addEducation.Click();

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
            IWebElement addDegree = driver.FindElement(By.Name("degree"));
            addDegree.SendKeys(Degree);

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
            IWebElement editCollegeNameTextbox = driver.FindElement(By.Name("instituteName"));
            editCollegeNameTextbox.Clear();
            editCollegeNameTextbox.SendKeys(CollegeName);

            // edit country dropdown
            SelectElement editCountryDropDown = new SelectElement(driver.FindElement(By.Name("country")));
            editCountryDropDown.SelectByValue(Country);

            // edit title dropdown 
            SelectElement editTitleDropdown = new SelectElement(driver.FindElement(By.Name("title")));
            editTitleDropdown.SelectByValue(Title);

            // edit degree textbox
            IWebElement editDegreeTextbox = driver.FindElement(By.Name("degree"));
            editDegreeTextbox.Clear();
            editDegreeTextbox.SendKeys(Degree);

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

            //verifying add new button and click on it
            IWebElement validatingAddNewButton = driver.FindElement(By.XPath("//thead/tr[1]/th[6]/div[1]"));
            validatingAddNewButton.Click();

            //verifying college name by entering null values
            IWebElement validatingCollegeTextbox = driver.FindElement(By.Name("instituteName"));
            validatingCollegeTextbox.SendKeys(String.Empty);

            //verifying add button 
            IWebElement validatingAddButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            validatingAddButton.Click();
           
        }
        public string getEduErrorMessage(IWebDriver driver)
        {
            //verifying valid error message is displayed or not
            IWebElement validatingEduErrorMessage = driver.FindElement(By.XPath("//div[contains(text(),'Please enter all the fields')]"));
            return validatingEduErrorMessage.Text;
        }

    }
}




