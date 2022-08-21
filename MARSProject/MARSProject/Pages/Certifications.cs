using MARSProject.Utilities;
using OpenQA.Selenium.Support.UI;

namespace MARSProject.Pages
{
    public class Certifications : CommonDriver
    {

        public void addCertifications(string Certifications, string CertificateFrom, string Year)
        {
            //Identify Certifications tab and click on it
            IWebElement certificationsTab = driver.FindElement(By.LinkText("Certifications"));
            certificationsTab.Click();

            //Identify add new button and click on it
            IWebElement addNewButton = driver.FindElement(By.XPath("//thead/tr[1]/th[4]/div[1]"));
            addNewButton.Click();

            //Identify certifications textbox and enter valid data
            IWebElement certificationTextbox = driver.FindElement(By.Name("certificationName"));
            certificationTextbox.SendKeys(Certifications);

            //Identify CertificateFrom textbox and enter valid data
            IWebElement certificateFromTextbox = driver.FindElement(By.Name("certificationFrom"));
            certificateFromTextbox.SendKeys(CertificateFrom);

            //Choose skill level from dropdown
            SelectElement yearDropDown = new SelectElement(driver.FindElement(By.Name("certificationYear")));
            yearDropDown.SelectByValue(Year);

            //click on add button
            IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addButton.Click();

            Thread.Sleep(3000);

        }
        public string getCertificationsTableDetails()
        {
            Thread.Sleep(1500);
            IWebElement newCertifications = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/table[1]"));
            return newCertifications.GetAttribute("outerText").ToString();
        }

        public void editCertifications(string Certifications, string CertificateFrom, string Year)
        {
            //Identify Certifications tab and click on it
            IWebElement certificationsTab = driver.FindElement(By.LinkText("Certifications"));
            certificationsTab.Click();

            //Identify edit button and click on it
            IWebElement editButton = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[4]/span[1]/i[1]"));
            editButton.Click();

            //edit certifications textbox 
            IWebElement certificationTextbox = driver.FindElement(By.Name("certificationName"));
            certificationTextbox.Clear();
            certificationTextbox.SendKeys(Certifications);

            //edit CertificateFrom textbox 
            IWebElement certificateFromTextbox = driver.FindElement(By.Name("certificationFrom"));
            certificateFromTextbox.Clear();
            certificateFromTextbox.SendKeys(CertificateFrom);

            //Choose skill level from dropdown
            SelectElement yearDropDown = new SelectElement(driver.FindElement(By.Name("certificationYear")));
            yearDropDown.SelectByValue(Year);

            //click on update button
            IWebElement updateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateButton.Click();

            Thread.Sleep(3000);

        }

        public void deleteCertifications()
        {
            //Identify Certifications tab and click on it
            IWebElement certificationsTab = driver.FindElement(By.LinkText("Certifications"));
            certificationsTab.Click();

            // Identify delete button click on it
            IWebElement deleteCertifications = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[4]/span[2]/i[1]"));
            deleteCertifications.Click();
            Thread.Sleep(3000);

        }

        public void validatingCertifications()
        {
            //Identify Certifications tab and click on it
            IWebElement certificationsTab = driver.FindElement(By.LinkText("Certifications"));
            certificationsTab.Click();

            //verifying add new button and click on it
            IWebElement addNewButton = driver.FindElement(By.XPath("//thead/tr[1]/th[4]/div[1]"));
            addNewButton.Click();

            //verifying certifications tab by entering null values
            IWebElement certificationNameTextbox = driver.FindElement(By.Name("certificationName"));
            certificationNameTextbox.SendKeys(String.Empty);

            //verifying add button 
            IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addButton.Click();

        }
        public string getCertErrorMessage()
        {
            //verifying valid error message is displayed or not
            IWebElement certErrorMessage = driver.FindElement(By.XPath("//div[contains(text(),'Please enter Certification Name, Certification From and Certification Year')]"));
            return certErrorMessage.Text;
        }
    }
}





    