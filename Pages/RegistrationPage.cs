using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BuggyCars1.Pages
{
    public class RegistrationPage
    {

        
        private IWebDriver Driver;
        //IWebDriver Driver;
        //private DriverHelper _driverHelper;

        public RegistrationPage(IWebDriver driver)
        {
            Driver = driver;
        }


        //Initialize webElements
        // IWebElement lnkRegistration => Driver.FindElement(By.XPath("//a[@class='btn btn-success-outline' and text()='Register'] "));
        private IWebElement txtUserName => Driver.FindElement(By.XPath("//input[@id='username' and @name='username']"));

        private IWebElement txtFirstName => Driver.FindElement(By.XPath("//input[@id='firstName' and @name='firstName']"));
        private  IWebElement txtLastName => Driver.FindElement(By.XPath("//input[@id='lastName' and @name='lastName']"));
        private IWebElement txtPassword => Driver.FindElement(By.XPath("//input[@id='password' and @name='password']"));
        private IWebElement txtConfirmPassword => Driver.FindElement(By.XPath("//input[@id='confirmPassword' and @name='confirmPassword']"));
        private IWebElement registerBtn => Driver.FindElement(By.XPath("//button[@type='submit' and text()='Register']"));
        private IWebElement successMsg => Driver.FindElement(By.XPath("//div[@class='result alert alert-success']"));
        private IWebElement unsuccessMsg => Driver.FindElement(By.XPath("//div[@class='result alert alert-danger']"));
        private IWebElement pwDonotMatchMsg => Driver.FindElement(By.XPath("(//div[@class='alert alert-danger'])[6]"));
        
        //public void ClickRegistrationLink()
        //{
        //    lnkRegistration.Click();
        //}

        public void EnterRegistrationData(string userName,string firstName,string lastName,string password,string confirmPassword)
        {
            Thread.Sleep(1000);
            txtUserName.SendKeys(userName);
            txtFirstName.SendKeys(firstName);
            txtLastName.SendKeys(lastName);
            txtPassword.SendKeys(password);
            txtConfirmPassword.SendKeys(confirmPassword);
        }
        public void ClickRegisterBtn()
        {
            registerBtn.Click();
        }
        //string Message = successMsg();
        public  void validateSuccessMessage()
        {

            Assert.AreEqual("Registration is successful", successMsg.Text);
        }
        public void validateUnsuccessMessage()
        {
            Assert.AreEqual("UsernameExistsException: User already exists", unsuccessMsg.Text);
        }
        public void alertPWDonotMatchMessage()
        {
            Assert.AreEqual("Passwords do not match", pwDonotMatchMsg.Text);
        }
    }

}