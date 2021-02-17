using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
namespace TestProjectSDET.Pages
{
    class FinishedPage
    {
        public FinishedPage(IWebDriver browserdriver)
        {
            Driver = browserdriver;
        }
        public IWebDriver Driver { get; }

        IWebElement CheckoutCompleted => Driver.FindElement(By.Id("checkout_complete_container"));
        public bool CheckoutCompletedExist() => CheckoutCompleted.Displayed;

        IWebElement RestartCounter => Driver.FindElement(By.XPath("//a[@href='./cart.html']//span"));
        public bool RestartCounterExist()
        {
            return RestartCounter.Displayed;
        }
    }
}
