﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectSDET.Pages;

namespace TestProjectSDET.Tests
{
    class ImageDisplayedTest
    {

        IWebDriver browserDriver;

        [SetUp]
        public void Setup()
        {
            //To open the browser
            browserDriver = new ChromeDriver();
            //Go to the website
            browserDriver.Navigate().GoToUrl("https://www.saucedemo.com/");
            //Maximize the navigator
            browserDriver.Manage().Window.Maximize();
            
            //Login first
            LoginPage loginPage = new LoginPage(browserDriver);

            //**Test cases for every user with correct password
            //loginPage.Login("standard_user", "secret_sauce");
            //loginPage.Login("locked_out_user", "secret_sauce");
            loginPage.Login("problem_user", "secret_sauce");
            //loginPage.Login("performance_glitch_user", "secret_sauce");
            //loginPage.Login(" ", "secret_sauce");
            //**Test cases for any user with a wrong password
            //loginPage.Login("standard_user", "secret_password");
            //loginPage.Login("standard_user", " ");
            
        }

        [Test]
        public void ImageDisplayed()
        {
            InventoryPage inventoryPage = new InventoryPage(browserDriver);
            Assert.That(inventoryPage.AllImagesExist, Is.True);

        }

        [TearDown]
        public void CloseBrowser()
        {
            browserDriver.Close();
        }
    }

}
