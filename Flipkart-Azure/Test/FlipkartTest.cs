using Flipkart_Azure.Base;
using Flipkart_Azure.Pages;
using NUnit.Framework;

namespace Flipkart_Azure.Test
{
    public class FlipkartTest : FlipkartBase
    {
        [Test, Order(1)]
        public void LoginTest()
        {
            Login login = new Login(driver);
            login.FlipkartLogin();
            Assert.AreEqual(driver.Title, title);
        }
    }
}
