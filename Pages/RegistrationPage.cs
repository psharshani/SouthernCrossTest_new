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
        
        public RegistrationPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public RegistrationPage()
        {
        }

        //Initialize webElements
        // IWebElement lnkRegistration => Driver.FindElement(By.XPath("//a[@class='btn btn-success-outline' and text()='Register'] "));
        IWebElement txtUserName => Driver.FindElement(By.XPath("//input[@id='username' and @name='username']"));

        IWebElement txtFirstName => Driver.FindElement(By.XPath("//input[@id='firstName' and @name='firstName']"));
        IWebElement txtLastName => Driver.FindElement(By.XPath("//input[@id='lastName' and @name='lastName']"));
        IWebElement txtPassword => Driver.FindElement(By.XPath("//input[@id='password' and @name='password']"));
        IWebElement txtConfirmPassword => Driver.FindElement(By.XPath("//input[@id='confirmPassword' and @name='confirmPassword']"));
        IWebElement registerBtn => Driver.FindElement(By.XPath("//button[@type='submit' and text()='Register']"));
        IWebElement successMsg => Driver.FindElement(By.XPath("//div[@class='result alert alert-success']"));


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
        public  void validateMessage(string Message)
        {

           string verifyMessage = successMsg.Text;
        }

    }

}
    
