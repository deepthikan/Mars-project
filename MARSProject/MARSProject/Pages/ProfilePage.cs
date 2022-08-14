using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MARSProject.Utilities;

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
            SelectElement dropDown = new SelectElement(driver.FindElement(By.Name("level")));
            dropDown.SelectByValue(Level);

            //click on add button
            IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addButton.Click();

            //WaitHelpers.WaitToBeClickable(driver, 10, "Xpath", "//tbody/tr[1]/td[3]/span[1]/i[1]");
            //WaitHelpers.WaitToBeClickable(driver, 10, "Name", "name");
        }
        public string getSkillsDetails(IWebDriver driver)
        {
                 Thread.Sleep(3000);
            //WaitHelpers.WaitToBeClickable(driver, 10, "Name", "name");
            IWebElement newSkills = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]"));
                return newSkills.GetAttribute("outerText").ToString();
        }

        //public void editSkills(IWebDriver driver, string Skills, string Level)
        //{
        //    //Go to skills tab and click on it
        //    IWebElement skillsTab = driver.FindElement(By.LinkText("Skills"));
        //    skillsTab.Click();

        //    //click on edit button
        //    IWebElement editButton = driver.FindElement(By.XPath("//tbody/tr[1]/td[3]/span[1]/i[1]"));
        //    editButton.Click();

        //    //edit skills button
        //    IWebElement editSkillButton = driver.FindElement(By.Name("name"));
        //    editSkillButton.Clear();
        //    editSkillButton.SendKeys(Skills);

        //    //Choose skill level from dropdown
        //    SelectElement dropDown = new SelectElement(driver.FindElement(By.Name("level")));
        //    dropDown.SelectByValue(Level);

        //    //click on update button
        //    IWebElement updateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
        //    updateButton.Click();
        //}
        //public string geteditSkillsDetails(IWebDriver driver)
        //{
        //    IWebElement editedSkills = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]"));
        //    return editedSkills.GetAttribute("outerText").ToString();
        //}



    }
}