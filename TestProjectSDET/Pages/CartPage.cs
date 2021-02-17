using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectSDET.Pages
{
    class CartPage
    {
        public CartPage(IWebDriver browserdriver)
        {
            Driver = browserdriver;
        }

        public IWebDriver Driver { get; }

        IWebElement CheckoutButton => Driver.FindElement(By.XPath("//a[@class='btn_action checkout_button']"));
        public bool CheckoutButtonExist() => CheckoutButton.Displayed;
        public void Checkout(){
         CheckoutButton.Click();
        }

    }
}
