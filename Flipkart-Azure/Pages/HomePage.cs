using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Flipkart_Azure.Pages
{
   public class HomePage
   {
      private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search for products, brands and more']")]
        public IWebElement search;
        [FindsBy(How = How.XPath, Using = "//button[@class='vh79eN']//*[local-name()='svg']")]
        public IWebElement searchButton;
        [FindsBy(How = How.XPath, Using = "//body/div[@id='container']/div[1]/div[3]/div[2]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]")]
        public IWebElement selectProduct;

        public void SearchProduct()
        {
            search.Click();
            Thread.Sleep(2000);
            search.SendKeys("iphone");
            Thread.Sleep(2000);
            searchButton.Click();
            Thread.Sleep(5000);
            selectProduct.Click();
            Thread.Sleep(2000);
        }
    }
}
