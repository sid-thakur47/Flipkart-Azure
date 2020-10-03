using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Flipkart_Azure.Pages
{
   public class Logout
    {
        
        private IWebDriver driver;

        public Logout(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='container']/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/a[1]/img[1]")]
        public IWebElement home;

        [FindsBy(How = How.XPath, Using = "//body/div[@id='container']/div[1]/div[1]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/div[1]")]
        public IWebElement profile;

        [FindsBy(How = How.XPath, Using = "//body//div[@id='container']//div//div//div//div//div//li[10]//a[1]")]
        public IWebElement logout;

        public void FlipkartLogout()
        {
            home.Click();
            Thread.Sleep(2000);
            Actions action = new Actions(driver);
            action.MoveToElement(profile).Build().Perform();
            Thread.Sleep(5000);
            logout.Click();
        }
    }
}
