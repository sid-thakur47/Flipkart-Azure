using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace Flipkart_Azure.Pages
{
    public class Cart
    {
        private IWebDriver driver;

        public Cart(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[2]/div[1]/ul[1]/li[1]/button[1]")]
        public IWebElement goToCart;

        [FindsBy(How = How.XPath, Using = "//body/div[@id='container']/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/form[1]/button[1]")]
        public IWebElement placeOrder;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Deliver Here')]")]
        public IWebElement deliiverHere;

        public void Placeorder()
        {
            goToCart.Click();
            Thread.Sleep(2000);
            placeOrder.Click();
            Thread.Sleep(2000);
            deliiverHere.Click();
            Thread.Sleep(2000);
        }
    }
}
