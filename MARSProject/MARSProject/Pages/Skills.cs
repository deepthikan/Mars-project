using MARSProject.Utilities;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Xml.Linq;


namespace MARSProject.Pages
{
    public class Skills
    {

        public void addNewSkills(IWebDriver driver, string Skills, string Level)
        {
            //Identify skills tab and click on it
            IWebElement skillsTab = driver.FindElement(By.LinkText("Skills"));
            skillsTab.Click();

            //Identify addnew button and click on it
            IWebElement addNewButton = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
            addNewButton.Click();

            //Identify addskill and enter valid data
            IWebElement addSkillButton = driver.FindElement(By.Name("name"));
            addSkillButton.SendKeys(Skills);

            //Choose skill level from dropdown
            SelectElement levelDropDown = new SelectElement(driver.FindElement(By.Name("level")));
            levelDropDown.SelectByValue(Level);

            //click on add button
            IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addButton.Click();

        }
        public string getSkillsTableDetails(IWebDriver driver)
        {
            Thread.Sleep(1500);
            //WaitHelpers.WaitTobevisible(driver, 5, "XPath", "//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]");
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
            IWebElement SkillTextbox = driver.FindElement(By.Name("name"));
            SkillTextbox.Clear();
            SkillTextbox.SendKeys(Skills);

            //Choose skill level from dropdown
            SelectElement levelDropDown = new SelectElement(driver.FindElement(By.Name("level")));
            levelDropDown.SelectByValue(Level);

            //click on update button
            IWebElement updateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateButton.Click();

            Thread.Sleep(3000);
            //WaitHelpers.WaitToBeClickable(driver, 5, "XPath", "//input[@value='Update']");

        }


        public void deleteSkills(IWebDriver driver)
        {
            //Go to skills tab and click on it
            IWebElement skillsTab = driver.FindElement(By.LinkText("Skills"));
            skillsTab.Click();

            // Identify delete button click on it
            IWebElement deleteButton = driver.FindElement(By.XPath("//i[@class='remove icon']"));
            deleteButton.Click();

            Thread.Sleep(3000);


        }


        public void validatingSkills(IWebDriver driver)
        {
            //Go to skills tab and click on it
            IWebElement skillsTab = driver.FindElement(By.LinkText("Skills"));
            skillsTab.Click();

            //Identify add new button and click on it
            IWebElement addNewButton = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
            addNewButton.Click();

            //Identify add skill button and input null values
            IWebElement addSkillButton = driver.FindElement(By.Name("name"));
            addSkillButton.SendKeys(String.Empty);

            //click add button
            IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addButton.Click();

        }

        public string getErrorMessage(IWebDriver driver)
        {
            //verifying error message is displayed or not
            IWebElement validatingErrorMessage = driver.FindElement(By.XPath("//div[contains(text(),'Please enter skill and experience level')]"));
            return validatingErrorMessage.Text;
        }
    }

}   