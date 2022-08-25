using BuggyCars1.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BuggyCars1.Steps
{
    [Binding]
    public class RegistrationSteps
    {
        private DriverHelper _driverHelper;
        //HomePage homePage;
        RegistrationPage registrationPage;
        // RegistrationPage registrationPage;
        //RegistrationPage registrationPage = new RegistrationPage();

        public RegistrationSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            //homePage = new HomePage(_driverHelper.Driver);
            registrationPage = new RegistrationPage(_driverHelper.Driver);
            //RegistrationPage registrationPage = new RegistrationPage();
        }

        [Given(@"I navigate to BuggyCars website")]
        public void GivenINavigateToBuggyCarsWebsite()
        {
            //initialize chrome webDriver
            _driverHelper.Driver = new ChromeDriver();
            _driverHelper.Driver.Navigate().GoToUrl("https://buggy.justtestit.org");
            _driverHelper.Driver.Manage().Window.Maximize();
        }

        [Given(@"click the Register button")]
        public void GivenClickTheRegisterButton()
        {
            //registrationPage.ClickRegistrationLink();
            //Driver = new ChromeDriver();
            _driverHelper.Driver.Navigate().GoToUrl("https://buggy.justtestit.org/register");
            
        }

        [Given(@"I enter registration details")]
        public void GivenIEnterRegistrationDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            registrationPage.EnterRegistrationData((string)data.Login, (string)data.FirstName, (string)data.LastName, (string)data.Password, (string)data.ConfirmPassword);
            //var regTable = table.CreateInstance<(string userName, string firstName, string lastName, string password, string confirmPassword)>();
            //registrationPage.EnterRegistrationData(regTable.userName,regTable.firstName,regTable.lastName,regTable.password,regTable.confirmPassword);

        }

        [Given(@"I click Register button")]
        public void GivenIClickRegisterButton()
        {
            registrationPage.ClickRegisterBtn();

            _driverHelper.Driver.Quit();
        }

        [Then(@"I see the Success message")]
        public void ThenISeeTheSuccessMessage()
        {
            //registrationPage.validateMessage();
        }

        [Then(@"I see the Unsuccess message")]
        public void ThenISeeTheUnsuccessMessage()
        {
            
        }

    }
}
