using GoogleSearchTests.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GoogleSearchTests.Tests
{
    [TestFixture]
    public class LoginTests
    {
        private IWebDriver? driver;
        private LoginPage loginPage = null!;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            loginPage = new LoginPage(driver);
        }

        [Test]
        public void Login_ValidCredentials_Successful()
        {
            loginPage.EnterUsername("standard_user");
            loginPage.EnterPassword("secret_sauce");
            loginPage.ClickLoginButton();
            Thread.Sleep(5000);

            // Add assertions to verify the expected behavior
            Assert.IsTrue(driver!.Url.Contains("inventory"));
        }

        [TearDown]
        public void Cleanup()
        {
            driver?.Quit();
            driver?.Dispose();
        }
    }
}
