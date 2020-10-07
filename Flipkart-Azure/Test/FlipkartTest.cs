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

        [Test, Order(2)]
        public void SearchProductTest()
        {
            HomePage page = new HomePage(driver);
            page.SearchProduct();
        }

        [Test, Order(3)]
        public void PlacOrderTest()
        {
            Cart cart = new Cart(driver);
            cart.Placeorder();
        }

        [Test, Order(4)]
        public void logoutTest()
        {
            Logout log = new Logout(driver);
            log.FlipkartLogout();
        }
    }
}
