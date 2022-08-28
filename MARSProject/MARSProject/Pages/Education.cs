using MARSProject.Utilities;
using OpenQA.Selenium.Support.UI;


namespace MARSProject.Pages
{
    public class Education : CommonDriver
    {

        //Education page objects
        IWebElement educationTab => driver.FindElement(By.LinkText("Education"));
        IWebElement addNewButton => driver.FindElement(By.XPath("//thead/tr[1]/th[6]/div[1]"));
        SelectElement countryDropDown => new SelectElement(driver.FindElement(By.Name("country")));
        SelectElement titleDropdown => new SelectElement(driver.FindElement(By.Name("title")));
        IWebElement degreeTextbox => driver.FindElement(By.Name("degree"));
        SelectElement yearDropdown => new SelectElement(driver.FindElement(By.Name("yearOfGraduation")));
        IWebElement addButton => driver.FindElement(By.XPath("//input[@value='Add']"));
        IWebElement newEducation => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]"));
        IWebElement editButton => driver.FindElement(By.XPath("//tbody/tr[1]/td[6]/span[1]/i[1]"));
        IWebElement collegeNameTextbox => driver.FindElement(By.Name("instituteName"));
        IWebElement updateButton => driver.FindElement(By.XPath("//input[@value='Update']"));
        IWebElement deleteButton => driver.FindElement(By.XPath("//tbody/tr[1]/td[6]/span[2]/i[1]"));
        IWebElement validatingEduErrorMessage =>driver.FindElement(By.XPath("//div[contains(text(),'Please enter all the fields')]"));
        
        private static string SUCCESSMESSAGE = "//div[@class='ns-box-inner']";
        public void addEducation(string CollegeName, string Country, string Title, string Degree, string Year)
        {
            //Identify education tab and click on it
            educationTab.Click();

            //Identify add new button and click on it
            addNewButton.Click();

            // Identify college name textbox and enter valid data
            collegeNameTextbox.SendKeys(CollegeName);

            // Identify country dropdown and send select valid country
            countryDropDown.SelectByValue(Country);

            // Identify title dropdown and select valid title
            titleDropdown.SelectByValue(Title);

            // Identify degree textbox and enter valid data
            degreeTextbox.SendKeys(Degree);

            // Identify year dropdown and select valid year
            yearDropdown.SelectByValue(Year);

            // Identify add button and click on it
            addButton.Click();
        }

        public string getEducationTableDetails()
        {
            WaitHelpers.WaitTobevisible(driver, 10, "XPath", SUCCESSMESSAGE);
            return newEducation.GetAttribute("outerText").ToString();
        }

        public void editEducation(string CollegeName, string Country, string Title, string Degree, string Year)
        {
            //click education tab
            educationTab.Click();

            //Identify edit button and click on it
            editButton.Click();

            // edit college name textbox
            collegeNameTextbox.Clear();
            collegeNameTextbox.SendKeys(CollegeName);

            // edit country dropdown
            countryDropDown.SelectByValue(Country);

            // edit title dropdown 
            titleDropdown.SelectByValue(Title);

            // edit degree textbox
            degreeTextbox.Clear();
            degreeTextbox.SendKeys(Degree);

            // edit year dropdown 
            yearDropdown.SelectByValue(Year);

            // Identify Update button and click on it
            updateButton.Click();
            //Thread.Sleep(4000);
            WaitHelpers.WaitTobevisible(driver, 10, "XPath", SUCCESSMESSAGE);
        }

        public void deleteEducation()
        {
            //click education tab
            educationTab.Click();

            // Identify delete button click on it
            deleteButton.Click();
            WaitHelpers.WaitTobevisible(driver, 10, "XPath", SUCCESSMESSAGE);

        }

        public void validatingEducation()
        {
            //Go to education tab and click on it
            educationTab.Click();

            //Identify add new button and click on it
            addNewButton.Click();

            //Identify college name by entering null values
            collegeNameTextbox.SendKeys(String.Empty);

            //Identify add button 
            addButton.Click();

        }
        public string getEduErrorMessage()
        {
            //verifying valid error message is displayed or not
            return validatingEduErrorMessage.Text;
        }

    }
}
