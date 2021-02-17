using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectSDET.Pages;

namespace TestProjectSDET.Tests
{
    class PersonalInfoTest
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
            loginPage.Login("standard_user", "secret_sauce");
            //loginPage.Login("locked_out_user", "secret_sauce");
            //loginPage.Login("problem_user", "secret_sauce");
            //loginPage.Login("performance_glitch_user", "secret_sauce");
            //loginPage.Login(" ", "secret_sauce");
            //**Test cases for any user with a wrong password
            //loginPage.Login("standard_user", "secret_password");
            //loginPage.Login("standard_user", " ");

            //Adding 5 items to the cart
            InventoryPage inventoryPage = new InventoryPage(browserDriver);
            var i = 0;
            do
            {
                inventoryPage.ClickAddToCart();
                i++;
            } while (i < 5);

            //Verify cart button and click it
            Assert.That(inventoryPage.CartButtonExist, Is.True);
            inventoryPage.Cart();
           
            //Verify Checkout button and click it
            CartPage cartPage = new CartPage(browserDriver);
            Assert.That(cartPage.CheckoutButtonExist, Is.True);
            cartPage.Checkout();

        }
        [Test]
        public void PersonalInfo()
        {
           
            PersonalInfoPage personalInfoPage = new PersonalInfoPage(browserDriver);
            //Positive Case
            personalInfoPage.Continue("Jorge", "Acosta", "SLM911");
            //Negative Cases  
            //personalInfoPage.Continue("", "MySurname", "SLM911");
            //personalInfoPage.Continue("MyName", "", "SLM911");
            //personalInfoPage.Continue("MyName", "MySurname", "");
            
            OverviewPage overviewPage = new OverviewPage(browserDriver);
            Assert.That(overviewPage.CheckoutSummaryExist, Is.True);
        
        }

        [TearDown]
        public void CloseBrowser()
        {
            browserDriver.Close();
        }
    }
}
