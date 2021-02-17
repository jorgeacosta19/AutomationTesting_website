using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectSDET.Pages
{
    class PersonalInfoPage
    {
        public PersonalInfoPage(IWebDriver browserdriver)
        {
            Driver = browserdriver;
        }

        public IWebDriver Driver { get; }

       
        IWebElement FirstNameBox => Driver.FindElement(By.Id("first-name"));
        IWebElement LastNameBox => Driver.FindElement(By.Id("last-name"));
        IWebElement PostalCodeBox => Driver.FindElement(By.Id("postal-code"));
        IWebElement ContinueButton => Driver.FindElement(By.ClassName("cart_button"));
        public void Continue(string firstName, string lastName,string postalCode)
        {
            FirstNameBox.SendKeys(firstName);
            LastNameBox.SendKeys(lastName);
            PostalCodeBox.SendKeys(postalCode);
            ContinueButton.Submit();

        }
    }

}
