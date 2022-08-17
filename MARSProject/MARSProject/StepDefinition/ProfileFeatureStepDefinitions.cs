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
        SignInPage signInPageObj = new SignInPage();
        ProfilePage profilePageObj = new ProfilePage();


        [Given(@"I logged in to Mars portal successfully")]
        public void GivenSellerLoggedInToMarsPortalSuccessfully()
        {
            driver = new ChromeDriver();
            signInPageObj.signInActions(driver);
           
        }
        [When(@"I navigate to Profile page")]
        public void WhenSellerNavigateToProfilePage()
        {
            signInPageObj.goToProfilePage(driver);
        }

        [Given(@"I add new '([^']*)' and '([^']*)' on profile")]
        public void GivenSellerAddNewAndOnProfile(string p0, string p1)
        {
            profilePageObj.addNewSkills(driver,p0,p1);
        }

        [Then(@"'([^']*)' and '([^']*)' should be added successfully")]
        public void ThenAndShouldBeAddedSuccessfully(string p0, string p1)
        {
            string newSkill = profilePageObj.getSkillsTableDetails(driver);
            string newLevel = profilePageObj.getSkillsTableDetails(driver);


            Assert.That(newSkill.Contains(p0), "Actual skill and Expected skill do not match");
            Assert.That(newLevel.Contains(p1), "Actual skill and Expected skill do not match");


            driver.Quit();
        }

        [Given(@"I edit existing '([^']*)' and '([^']*)' on profile")]
        public void GivenSellerEditsExistingAndOnProfile(string p0, string p1)
        {
            profilePageObj.editSkills(driver, p0, p1);
        }

        [Then(@"'([^']*)' and '([^']*)' should be updated successfully")]
        public void ThenAndShouldBeUpdatedSuccessfully(string p0, string p1)
        {
            string editSkill = profilePageObj.getSkillsTableDetails(driver);
            string editLevel = profilePageObj.getSkillsTableDetails(driver);


            Assert.That(editSkill.Contains(p0), "Edited skill and Expected skill do not match");
            Assert.That(editLevel.Contains(p1), "Edited skill and Expected skill do not match");


            driver.Quit();

        }
        [Given(@"I delete existing Skills")]
        public void GivenSellerDeletesExistingSkills()
        {
            profilePageObj.deleteSkills(driver);
        }

        [Then(@"Skills should be deleted successfully")]
        public void ThenSkillsShouldBeDeletedSuccessfully()
        {
            string deletedSkill = profilePageObj.getSkillsTableDetails(driver);

            Assert.That(deletedSkill != "p0", "Deleted skill and Expected skill do not match");

            driver.Quit();
        }

        [Given(@"I left Skills field as blank")]
        public void GivenSellerLeftSkillsFieldAsBlank()
        {
            profilePageObj.validatingSkills(driver);
        }

        [Then(@"error message should be displayed")]
        public void ThenErrorMessageShouldBeDisplayed()
        {
            string errorMessage = profilePageObj.getErrorMessage(driver);

            Assert.That(errorMessage == "Please enter skill and experience level", "Actual message and Expected message do not match");

            driver.Quit();


        }

        [Given(@"I add education as follows '([^']*)','([^']*)','([^']*)','([^']*)' and '([^']*)'")]
        public void GivenSellerAddEducationAsFollowsAnd(string p0, string p1, string p2, string p3, string p4)
        {
            profilePageObj.addEducation(driver, p0, p1, p2, p3, p4);

        }

        [Then(@"'([^']*)','([^']*)','([^']*)','([^']*)' and '([^']*)'  details should be added successfully")]
        public void ThenAndDetailsShouldBeAddedSuccessfully(string p0, string p1, string p2, string p3, string p4)
        {

            string addCollegeName = profilePageObj.getEducationTableDetails(driver);
            string addCountry = profilePageObj.getEducationTableDetails(driver);
            string addTitle = profilePageObj.getEducationTableDetails(driver);
            string addDegree = profilePageObj.getEducationTableDetails(driver);
            string addYear = profilePageObj.getEducationTableDetails(driver);

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
            profilePageObj.editEducation(driver,p0,p1,p2,p3,p4);
        }

        [Then(@"'([^']*)','([^']*)','([^']*)','([^']*)' and '([^']*)' details should be updated succesfully")]
        public void ThenAndDetailsShouldBeUpdatedSuccesfully(string p0, string p1, string p2, string p3, string p4)
        {
            string editCollegeName = profilePageObj.getEducationTableDetails(driver);
            string editCountry = profilePageObj.getEducationTableDetails(driver);
            string editTitle = profilePageObj.getEducationTableDetails(driver);
            string editDegree = profilePageObj.getEducationTableDetails(driver);
            string editYear = profilePageObj.getEducationTableDetails(driver);

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
            profilePageObj.deleteEducation(driver);
        }

        [Then(@"Education details should be deleted successfully")]
        public void ThenEducationDetailsShouldBeDeletedSuccessfully()
        {
            string deletedEducation = profilePageObj.getEducationTableDetails(driver);

            Assert.That(deletedEducation != "p0", "Deleted education and Expected education do not match");

            driver.Quit();

        }

        [Given(@"I left Education field as blank")]
        public void GivenILeftEducationFieldAsBlank()
        {
            profilePageObj.validatingEducation(driver);
        }

        [Then(@"Education error message should be displayed")]
        public void ThenEducationErrorMessageShouldBeDisplayed()
        {
            string eduErrorMessage = profilePageObj.getEduErrorMessage(driver);
            Assert.That(eduErrorMessage == "Please enter all the fields", "Actual Eduerror message and Expected eduerror message do not match");
            driver.Quit();

        }

    }

}
