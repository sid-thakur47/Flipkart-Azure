using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Configuration;
using System.Threading;

namespace Flipkart_Azure.Pages
{
    public class Login
    {
         string phoneNumber = ConfigurationManager.AppSettings["number"];
         string pass = ConfigurationManager.AppSettings["password"];

        private  IWebDriver driver;
        public Login(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@class='_2zrpKA _1dBPDZ']")]
        public IWebElement phoneNum;

        [FindsBy(How = How.XPath, Using = "//input[@class='_2zrpKA _3v41xv _1dBPDZ']")]
        public IWebElement password;

        [FindsBy(How = How.XPath, Using = "//button[@class='_2AkmmA _1LctnI _7UHT_c']//span[contains(text(),'Login')]")]
        public IWebElement loginButton;

        public void FlipkartLogin()
        {
            phoneNum.SendKeys(phoneNumber);
            Thread.Sleep(2000);
            password.SendKeys(pass);
            Thread.Sleep(2000);
            loginButton.Click();
            Thread.Sleep(3000);
        }
    }
}
