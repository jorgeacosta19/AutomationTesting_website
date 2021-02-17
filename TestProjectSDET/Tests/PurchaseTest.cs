using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectSDET.Pages;

namespace TestProjectSDET.Tests
{
    class PurchaseTest
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

            //Adding six items to the cart
            InventoryPage inventoryPage = new InventoryPage(browserDriver);
            var i = 0;
            do
            {
                inventoryPage.ClickAddToCart();
                i++;
            } while (i < 6);


            //Verify cart button and click it
            Assert.That(inventoryPage.CartButtonExist, Is.True);
            inventoryPage.Cart();
            //Verify Checkout button and click it
            CartPage cartPage = new CartPage(browserDriver);
            
            Assert.That(cartPage.CheckoutButtonExist, Is.True);
            cartPage.Checkout();
            
            PersonalInfoPage personalInfoPage = new PersonalInfoPage(browserDriver);
            personalInfoPage.Continue("MyName", "MySurname", "SLM911");
       
            OverviewPage overviewPage = new OverviewPage(browserDriver);
            overviewPage.Finish();

        }
        [Test]
        public void Purchase()
        {

            
            FinishedPage finishedPage = new FinishedPage(browserDriver);
            Assert.That(finishedPage.CheckoutCompletedExist, Is.True);
        }

        [TearDown]
        public void CloseBrowser()
        {
            browserDriver.Close();
        }
    }
}
