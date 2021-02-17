using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectSDET.Pages
{
    class OverviewPage
    {
        public OverviewPage(IWebDriver browserdriver)
        {
            Driver = browserdriver;
        }
        public IWebDriver Driver { get; }
        IWebElement CheckoutSummary => Driver.FindElement(By.Id("checkout_summary_container"));
        public bool CheckoutSummaryExist() => CheckoutSummary.Displayed;

        public IWebElement FinishButton => Driver.FindElement(By.XPath("//a[@class='btn_action cart_button']"));
        public bool FinishButtonExist() => FinishButton.Displayed;

        public void Finish()
        {
            FinishButton.Click();
        }


    }
}
