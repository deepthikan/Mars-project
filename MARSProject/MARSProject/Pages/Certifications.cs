using MARSProject.Utilities;
using OpenQA.Selenium.Support.UI;

namespace MARSProject.Pages
{
    public class Certifications : CommonDriver
    {

        //Certifications page objects
        IWebElement certificationsTab => driver.FindElement(By.LinkText("Certifications"));
        IWebElement addNewButton => driver.FindElement(By.XPath("//thead/tr[1]/th[4]/div[1]"));
        IWebElement certificationTextbox => driver.FindElement(By.Name("certificationName"));
        IWebElement certificateFromTextbox => driver.FindElement(By.Name("certificationFrom"));
        SelectElement yearDropDown => new SelectElement(driver.FindElement(By.Name("certificationYear")));
        IWebElement addButton => driver.FindElement(By.XPath("//input[@value='Add']"));
        IWebElement newCertifications => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/table[1]"));
        IWebElement editButton => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[4]/span[1]/i[1]"));
        IWebElement updateButton => driver.FindElement(By.XPath("//input[@value='Update']"));
        IWebElement deleteButton => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[4]/span[2]/i[1]"));
        IWebElement certErrorMessage => driver.FindElement(By.XPath("//div[contains(text(),'Please enter Certification Name, Certification From and Certification Year')]"));

        private static string SUCCESSMESSAGE = "//div[@class='ns-box-inner']";
        public void addCertifications(string Certifications, string CertificateFrom, string Year)
        {
            //Identify Certifications tab and click on it
            certificationsTab.Click();

            //Identify add new button and click on it
            addNewButton.Click();

            //Identify certifications textbox and enter valid data
            certificationTextbox.SendKeys(Certifications);

            //Identify CertificateFrom textbox and enter valid data
            certificateFromTextbox.SendKeys(CertificateFrom);

            //Choose skill level from dropdown
            yearDropDown.SelectByValue(Year);

            //click on add button
            addButton.Click();

        }
        public string getCertificationsTableDetails()
        {
            WaitHelpers.WaitTobevisible(driver, 10, "XPath", SUCCESSMESSAGE);
            return newCertifications.GetAttribute("outerText").ToString();
        }

        public void editCertifications(string Certifications, string CertificateFrom, string Year)
        {
            //Identify Certifications tab and click on it
            certificationsTab.Click();

            //Identify edit button and click on it
            editButton.Click();

            //edit certifications textbox 
            certificationTextbox.Clear();
            certificationTextbox.SendKeys(Certifications);

            //edit CertificateFrom textbox 
            certificateFromTextbox.Clear();
            certificateFromTextbox.SendKeys(CertificateFrom);

            //Choose skill level from dropdown
            yearDropDown.SelectByValue(Year);

            //click on update button
            updateButton.Click();

            WaitHelpers.WaitTobevisible(driver, 10, "XPath", SUCCESSMESSAGE);

        }

        public void deleteCertifications()
        {
            //Identify Certifications tab and click on it
            certificationsTab.Click();

            // Identify delete button click on it
            deleteButton.Click();
            WaitHelpers.WaitTobevisible(driver, 10, "XPath", SUCCESSMESSAGE);

        }

        public void validatingCertifications()
        {
            //Identify Certifications tab and click on it
            certificationsTab.Click();

            //verifying add new button and click on it
            addNewButton.Click();

            //verifying certifications tab by entering null values
            certificationTextbox.SendKeys(String.Empty);

            //verifying add button 
            addButton.Click();

        }
        public string getCertErrorMessage()
        {
            //verifying valid error message is displayed or not
            return certErrorMessage.Text;
        }
    }
}





    