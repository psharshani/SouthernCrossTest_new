using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BuggyCars1.Pages
{
    public class HomePage
    {
       private IWebDriver Driver;

        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        private IWebElement txtLogin => Driver.FindElement(By.XPath("//input[@class='form-control form-control-sm input-sm ng-pristine ng-invalid ng-touched']"));
        private IWebElement txtPassword => Driver.FindElement(By.XPath("//input[@class='form-control form-control-sm ng-pristine ng-invalid ng-touched']"));

        private IWebElement loginBtn => Driver.FindElement(By.XPath("//button[@class='btn btn-success']"));
        private IWebElement logoutLink => Driver.FindElement(By.XPath("//a[@class='nav-link' and text()='Logout']"));
        private IWebElement logoutText => Driver.FindElement(By.XPath("(//a[@class='nav-link'])[2]"));
        public void EnterLoginData(string login,string password)
        {
            Thread.Sleep(1000);
            txtLogin.SendKeys(login);
            Thread.Sleep(1000);
            txtPassword.SendKeys(password);
        }
        public void ClickLogin() => loginBtn.Click();

        public void ClickLogout() => logoutLink.Click();
        public void validateLoginSuccess()
        {
            Assert.AreEqual("Logout", logoutText.Text);
        }
    }
}
