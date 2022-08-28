using MARSProject.Utilities;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Xml.Linq;


namespace MARSProject.Pages
{
    public class Skills : CommonDriver
    {

        //Skills page objects
        IWebElement skillsTab => driver.FindElement(By.LinkText("Skills"));
        IWebElement addNewButton => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
        IWebElement addSkillButton => driver.FindElement(By.Name("name"));
        SelectElement levelDropDown => new SelectElement(driver.FindElement(By.Name("level")));
        IWebElement addButton => driver.FindElement(By.XPath("//input[@value='Add']"));
        IWebElement newSkills => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]"));
        IWebElement editButton => driver.FindElement(By.XPath("//tbody/tr[1]/td[3]/span[1]/i[1]"));
        IWebElement skillTextbox => driver.FindElement(By.Name("name"));
        IWebElement updateButton => driver.FindElement(By.XPath("//input[@value='Update']"));
        IWebElement deleteButton => driver.FindElement(By.XPath("//i[@class='remove icon']"));
        IWebElement validatingErrorMessage => driver.FindElement(By.XPath("//div[contains(text(),'Please enter skill and experience level')]"));
        IWebElement editSuccessMessage => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

        private static string SUCCESSMESSAGE = "//div[@class='ns-box-inner']";

        public void addNewSkills(string Skills, string Level)
        {
            //Identify skills tab and click on it
            skillsTab.Click();

            //Identify addnew button and click on it
            addNewButton.Click();

            //Identify addskill and enter valid data
            addSkillButton.SendKeys(Skills);

            //Choose skill level from dropdown
            levelDropDown.SelectByValue(Level);

            //click on add button
            addButton.Click();

        }
        public string getSkillsTableDetails()
        {
            WaitHelpers.WaitTobevisible(driver, 10, "XPath", SUCCESSMESSAGE);

            // Getting skill table details for assertion.
            return newSkills.GetAttribute("outerText").ToString();
        }

       
        public void editSkills(string Skills, string Level)
        {
            //Go to skills tab and click on it
            skillsTab.Click();

            //click on edit button
            editButton.Click();

            //edit skills textbox
            skillTextbox.Clear();
            skillTextbox.SendKeys(Skills);

            //Choose skill level from dropdown
            levelDropDown.SelectByValue(Level);

            //click on update button
            updateButton.Click();

        }


        public void deleteSkills()
        {
            //Go to skills tab and click on it
            skillsTab.Click();

            // Identify delete button click on it
            deleteButton.Click();

            WaitHelpers.WaitTobevisible(driver, 10, "XPath", SUCCESSMESSAGE);

        }


        public void validatingSkills()
        {
            //Go to skills tab and click on it
            skillsTab.Click();

            //Identify add new button and click on it
            addNewButton.Click();

            //Identify add skill button and input as empty
            addSkillButton.SendKeys(String.Empty);

            //click add button
            addButton.Click();

        }

        public string getErrorMessage()
        {
            //verifying error message is displayed or not
            return validatingErrorMessage.Text;
        }
    }

}   