using MARSProject.Pages;
using MARSProject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MARSProject.StepDefinition
{
    [Binding]
    public class ProfileFeatureStepDefinitions : CommonDriver
    {
        SignInandProfilePage SignInandProfilePageObj = new SignInandProfilePage();
        Skills skillsObj = new Skills();
        Education educationObj = new Education();
        Certifications certificationsObj = new Certifications();

        [Given(@"I logged in to Mars portal successfully")]
        public void GivenSellerLoggedInToMarsPortalSuccessfully()
        {
            driver = new ChromeDriver();
            SignInandProfilePageObj.signInActions();

        }
        [When(@"I navigate to Profile page")]
        public void WhenSellerNavigateToProfilePage()
        {
            SignInandProfilePageObj.goToProfilePage();
        }

        [Given(@"I add new '([^']*)' and '([^']*)' on profile")]
        public void GivenSellerAddNewAndOnProfile(string p0, string p1)
        {
            skillsObj.addNewSkills(p0, p1);
        }

        [Then(@"'([^']*)' and '([^']*)' should be added successfully")]
        public void ThenAndShouldBeAddedSuccessfully(string p0, string p1)
        {
            string newSkill = skillsObj.getSkillsTableDetails();
            string newLevel = skillsObj.getSkillsTableDetails();


            Assert.That(newSkill.Contains(p0), "Actual skill and Expected skill do not match");
            Assert.That(newLevel.Contains(p1), "Actual skill and Expected skill do not match");


            driver.Quit();
        }

        [Given(@"I edit existing '([^']*)' and '([^']*)' on profile")]
        public void GivenSellerEditsExistingAndOnProfile(string p0, string p1)
        {
            skillsObj.editSkills( p0, p1);
        }

        [Then(@"'([^']*)' and '([^']*)' should be updated successfully")]
        public void ThenAndShouldBeUpdatedSuccessfully(string p0, string p1)
        {
            string editSkill = skillsObj.getSkillsTableDetails();
            string editLevel = skillsObj.getSkillsTableDetails();


            Assert.That(editSkill.Contains(p0), "Edited skill and Expected skill do not match");
            Assert.That(editLevel.Contains(p1), "Edited skill and Expected skill do not match");
            driver.Quit();

        }
        [Given(@"I delete existing Skills")]
        public void GivenSellerDeletesExistingSkills()
        {
            skillsObj.deleteSkills();
        }

        [Then(@"Skills should be deleted successfully")]
        public void ThenSkillsShouldBeDeletedSuccessfully()
        {
            string deletedSkill = skillsObj.getSkillsTableDetails();

            Assert.That(deletedSkill != "p0", "Deleted skill and Expected skill do not match");

            driver.Quit();
        }

        [Given(@"I left Skills field as blank")]
        public void GivenSellerLeftSkillsFieldAsBlank()
        {
            skillsObj.validatingSkills();
        }

        [Then(@"error message should be displayed")]
        public void ThenErrorMessageShouldBeDisplayed()
        {
            string errorMessage = skillsObj.getErrorMessage();

            Assert.That(errorMessage == "Please enter skill and experience level", "Actual message and Expected message do not match");

            driver.Quit();


        }

        [Given(@"I add education as follows '([^']*)','([^']*)','([^']*)','([^']*)' and '([^']*)'")]
        public void GivenSellerAddEducationAsFollowsAnd(string p0, string p1, string p2, string p3, string p4)
        {
            educationObj.addEducation(p0, p1, p2, p3, p4);

        }

        [Then(@"'([^']*)','([^']*)','([^']*)','([^']*)' and '([^']*)'  details should be added successfully")]
        public void ThenAndDetailsShouldBeAddedSuccessfully(string p0, string p1, string p2, string p3, string p4)
        {

            string addCollegeName = educationObj.getEducationTableDetails();
            string addCountry = educationObj.getEducationTableDetails();
            string addTitle = educationObj.getEducationTableDetails();
            string addDegree = educationObj.getEducationTableDetails();
            string addYear = educationObj.getEducationTableDetails();

            Assert.That(addCollegeName.Contains(p0), "Actual college name expected college name do not match");
            Assert.That(addCountry.Contains(p1), "Actual country expected country do not match");
            Assert.That(addTitle.Contains(p2), "Actual title expected title do not match");
            Assert.That(addDegree.Contains(p3), "Actual degree expected degree do not match");
            Assert.That(addYear.Contains(p4), "Actual year expected year do not match");

            driver.Quit();
        }

        [Given(@"I edit existing education as follows '([^']*)','([^']*)','([^']*)','([^']*)' and '([^']*)'")]
        public void GivenIEditExistingEducationAsFollowsAnd(string p0, string p1, string p2, string p3, string p4)
        {
            educationObj.editEducation(p0, p1, p2, p3, p4);
        }

        [Then(@"'([^']*)','([^']*)','([^']*)','([^']*)' and '([^']*)' details should be updated succesfully")]
        public void ThenAndDetailsShouldBeUpdatedSuccesfully(string p0, string p1, string p2, string p3, string p4)
        {
            string editCollegeName = educationObj.getEducationTableDetails();
            string editCountry = educationObj.getEducationTableDetails();
            string editTitle = educationObj.getEducationTableDetails();
            string editDegree = educationObj.getEducationTableDetails();
            string editYear = educationObj.getEducationTableDetails();

            Assert.That(editCollegeName.Contains(p0), "Edited college name expected college name do not match");
            Assert.That(editCountry.Contains(p1), "Edited country expected country do not match");
            Assert.That(editTitle.Contains(p2), "Edited title expected title do not match");
            Assert.That(editDegree.Contains(p3), "Edited degree expected degree do not match");
            Assert.That(editYear.Contains(p4), "Edited year expected year do not match");

            driver.Quit();

        }

        [Given(@"I delete existing education details")]
        public void GivenIDeleteExistingEducationDetails()
        {
            educationObj.deleteEducation();
        }

        [Then(@"Education details should be deleted successfully")]
        public void ThenEducationDetailsShouldBeDeletedSuccessfully()
        {
            string deletedEducation = educationObj.getEducationTableDetails();

            Assert.That(deletedEducation != "p0", "Deleted education and Expected education do not match");

            driver.Quit();

        }

        [Given(@"I left Education field as blank")]
        public void GivenILeftEducationFieldAsBlank()
        {
            educationObj.validatingEducation();
        }

        [Then(@"Education error message should be displayed")]
        public void ThenEducationErrorMessageShouldBeDisplayed()
        {
            string eduErrorMessage = educationObj.getEduErrorMessage();
            Assert.That(eduErrorMessage == "Please enter all the fields", "Actual Eduerror message and Expected eduerror message do not match");
            driver.Quit();

        }

        [Given(@"I add new '([^']*)','([^']*)' and '([^']*)' to profile")]
        public void GivenIAddNewAndToProfile(string p0, string p1, string p2)
        {
            certificationsObj.addCertifications(p0, p1, p2);
        }

        [Then(@"The '([^']*)','([^']*)' and '([^']*)'details should be added successfully")]
        public void ThenTheAndDetailsShouldBeAddedSuccessfully(string p0, string p1, string p2)
        {

            string addCertifications = certificationsObj.getCertificationsTableDetails();
            string addCertificationFrom = certificationsObj.getCertificationsTableDetails();
            string addYear = certificationsObj.getCertificationsTableDetails();


            Assert.That(addCertifications.Contains(p0), "Actual Certifications and Expected Certifications do not match");
            Assert.That(addCertificationFrom.Contains(p1), "Actual Certificationsfrom and Expected Certifications do not match");
            Assert.That(addYear.Contains(p2), "Actual Year and Expected year do not match");
            driver.Quit();
        }

        [Given(@"I edit existing '([^']*)','([^']*)' and '([^']*)' to profile")]
        public void GivenIEditExistingAndToProfile(string p0, string p1, string p2)
        {
            certificationsObj.editCertifications(p0, p1, p2);
        }

        [Then(@"'([^']*)','([^']*)' and '([^']*)' details should be updated successfully")]
        public void ThenAndDetailsShouldBeUpdatedSuccessfully(string p0, string p1, string p2)
        {
            string editCertifications = certificationsObj.getCertificationsTableDetails();
            string editCertificationFrom = certificationsObj.getCertificationsTableDetails();
            string editYear = certificationsObj.getCertificationsTableDetails();


            Assert.That(editCertifications.Contains(p0), "Edited Certifications and Expected Certifications do not match");
            Assert.That(editCertificationFrom.Contains(p1), "Edited Certificationsfrom and Expected Certifications do not match");
            Assert.That(editYear.Contains(p2), "Edited Year and Expected year do not match");
            driver.Quit();

        }

        [Given(@"I delete Certifications details")]
        public void GivenIDeleteCertificationsDetails()
        {
            certificationsObj.deleteCertifications();
        }

        [Then(@"Certifications details should be deleted successfully")]
        public void ThenCertificationsDetailsShouldBeDeletedSuccessfully()
        {
            string deleteCertifications = certificationsObj.getCertificationsTableDetails();

            Assert.That(deleteCertifications != "p0", "Deleted certifications and Expected certifications do not match");

            driver.Quit();
        }

        [Given(@"I left Certifications field as blank")]
        public void GivenILeftCertificationsFieldAsBlank()
        {
            certificationsObj.validatingCertifications();
        }

        [Then(@"Following error message should be displayed")]
        public void ThenFollowingErrorMessageShouldBeDisplayed()
        {
            string errorMessage = certificationsObj.getCertErrorMessage();

            Assert.That(errorMessage == "Please enter Certification Name, Certification From and Certification Year", "Actual message and Expected message do not match");

            driver.Quit();
        }

    }

}   