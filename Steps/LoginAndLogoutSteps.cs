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
    public class LoginAndLogoutSteps
    {
        //create PageObject for HomePage
        public HomePage homePage;
        //WebDriver driver = new ChromeDriver();

        //private DriverHelper _driverHelper;
       
        //HomePage homePage = new HomePage();
        //public LoginAndLogoutSteps(DriverHelper driverHelper)
        //{
        //    //_driverHelper = driverHelper;
        //    //homePage = new HomePage(_driverHelper.Driver);

        //    //HomePage homePage = new HomePage();

        //}

        [Given(@"enter username and password")]
        public void GivenEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            
            homePage.EnterLoginData(data.UserName, data.Password);
        }

        [Given(@"I click login button")]
        public void GivenIClickLoginButton()
        {
            homePage.ClickLogin();
        }

        [Then(@"I can see the Logout text on the page")]
        public void ThenICanSeeTheLogoutTextOnThePage()
        {
            homePage.validateLoginSuccess();
        }

    }
}
