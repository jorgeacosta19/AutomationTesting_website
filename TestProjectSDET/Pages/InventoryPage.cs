using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectSDET.Pages
{

    //Inventory Page
   public class InventoryPage
    {


        public InventoryPage(IWebDriver browserDriver)
        {
            Driver = browserDriver;
        }

        public IWebDriver Driver { get; }

        //verifying the images
        IWebElement FirstImage => Driver.FindElement(By.XPath("//a[@id='item_0_img_link']//img[@src='./img/bike-light-1200x1500.jpg']"));
        public bool FirstImageExist() => FirstImage.Displayed;
        IWebElement SecondImage => Driver.FindElement(By.XPath("//a[@id='item_1_img_link']//img[@src='./img/bolt-shirt-1200x1500.jpg']"));
        public bool SecondImageExist() => SecondImage.Displayed;
        IWebElement ThirdImage => Driver.FindElement(By.XPath("//a[@id='item_2_img_link']//img[@src='./img/red-onesie-1200x1500.jpg']"));
        public bool ThirdImageExist() => ThirdImage.Displayed;
        IWebElement FourthImage => Driver.FindElement(By.XPath("//a[@id='item_3_img_link']//img[@src='./img/red-tatt-1200x1500.jpg']"));
        public bool FourthImageExist() => FourthImage.Displayed;
        IWebElement FifthImage => Driver.FindElement(By.XPath("//a[@id='item_4_img_link']//img[@src='./img/sauce-backpack-1200x1500.jpg']"));
        public bool FifthImageExist() => FifthImage.Displayed;
        IWebElement SixthImage => Driver.FindElement(By.XPath("//a[@id='item_5_img_link']//img[@src='./img/sauce-pullover-1200x1500.jpg']"));
        public bool SixthImageExist() => SixthImage.Displayed;

       public bool AllImagesExist() =>(FirstImageExist() && SecondImageExist() && 
            ThirdImageExist() && FourthImageExist() && FifthImageExist() && SixthImageExist());

        //Vrifying Cart Button 

        IWebElement CartButton => Driver.FindElement(By.XPath("//a[@href='./cart.html']"));
        public bool CartButtonExist() => CartButton.Displayed;
        public void Cart() => CartButton.Click();

        //Verifying the ADD TO CART button
        public IWebElement AddToCart => Driver.FindElement(By.XPath("//button[@class='btn_primary btn_inventory']"));
        public void ClickAddToCart() => AddToCart.Click();

        //Verifying the Toggle (ADD TO CART / REMOVE)
        /*     public IWebElement PrimaryBtn => Driver.FindElement(By.Id("btn_primary"));
             public bool PrimaryButtonExist() => PrimaryBtn.Displayed;
             public IWebElement SecondaryBtn => Driver.FindElement(By.Id("btn_secondary"));
             public bool SecondaryButtonExist() => SecondaryBtn.Displayed;

             public void AddRemove()
             {
                 PrimaryBtn.Submit();
                 SecondaryBtn.FindElement(By.Id("btn_secondary"));
                 SecondaryBtn.Submit();

             }*/
        /*
                //
                public IWebElement AddToCart => Driver.FindElement(By.XPath("//button[@class='btn_primary btn_inventory']"));
                public void ClickAddToCart() => AddToCart.Click();
        */
    }
}
