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


        [Given(@"seller logged in to Mars portal successfully")]
        public void GivenSellerLoggedInToMarsPortalSuccessfully()
        {
            driver = new ChromeDriver();
            signInPageObj.signInActions(driver);
           
        }
        [When(@"seller navigate to Profile page")]
        public void WhenSellerNavigateToProfilePage()
        {
            signInPageObj.goToProfilePage(driver);
        }

        [Given(@"seller add new '([^']*)' and '([^']*)' on profile")]
        public void GivenSellerAddNewAndOnProfile(string p0, string p1)
        {
            profilePageObj.addNewSkills(driver,p0,p1);
        }

        [Then(@"'([^']*)' and '([^']*)' should be added successfully")]
        public void ThenAndShouldBeAddedSuccessfully(string p0, string p1)
        {
            string newSkill = profilePageObj.getSkillsDetails(driver);
            string newLevel = profilePageObj.getSkillsDetails(driver);


            Assert.That(newSkill.Contains(p0), "Actual skill and Expected skill do not match");
            Assert.That(newLevel.Contains(p1), "Actual skill and Expected skill do not match");


            driver.Quit();
        }

        //[Given(@"seller edits existing '([^']*)' and '([^']*)' on profile")]
        //public void GivenSellerEditsExistingAndOnProfile(string p0, string p1)
        //{
        //    profilePageObj.editSkills(driver, p0, p1);
        //}

        //[Then(@"'([^']*)' and '([^']*)' should be updated successfully")]
        //public void ThenAndShouldBeUpdatedSuccessfully(string p0, string p1)
        //{
        //    string editSkill = profilePageObj.geteditSkillsDetails(driver);
        //    string editLevel = profilePageObj.geteditSkillsDetails(driver);


        //    Assert.That(editSkill.Contains(p0), "Actual code and Expected code do not match");
        //    Assert.That(editLevel.Contains(p1), "Actual code and Expected code do not match");


        //    driver.Quit();

        //}




    }
}
