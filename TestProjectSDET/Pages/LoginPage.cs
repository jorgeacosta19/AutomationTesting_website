using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectSDET.Pages
{
    class LoginPage
    {
        public LoginPage(IWebDriver browserdriver)
        {
            Driver = browserdriver;
        }
        
        public IWebDriver Driver { get; }
        IWebElement InventoryContainer => Driver.FindElement(By.ClassName("inventory_container"));
        public bool InventoryContainerExist() => InventoryContainer.Displayed;

        IWebElement UserBox => Driver.FindElement(By.XPath("//input[@id='user-name']"));
        IWebElement PasswordBox=> Driver.FindElement(By.XPath("//input[@id='password']"));
        IWebElement LoginButton=> Driver.FindElement(By.XPath("//input[@id='login-button']"));

        public void Login(string userName,string password)
        {
            UserBox.SendKeys(userName);
            PasswordBox.SendKeys(password);
            LoginButton.Submit();

        }

    }
}
