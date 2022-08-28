//using BuggyCars1.Pages;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using System;

//namespace BuggyCars1
//{
//    public class Tests
//    {
//        public IWebDriver Driver;
//        //IWebDriver= private WebDriver Driver;

//        [SetUp]
//    public void Setup()
//    {
//        Driver = new ChromeDriver();
//    }

//    [Test]
//        public void Test1()
//        {
//            Driver.Navigate().GoToUrl("https://buggy.justtestit.org/register");

//            Driver.Manage().Window.Maximize();
//            RegistrationPage BuggyUrl = new RegistrationPage();
//            BuggyUrl.NavigateURL();



//            Assert.Pass();
//        }
//    }
//}