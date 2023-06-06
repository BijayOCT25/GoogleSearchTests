using OpenQA.Selenium;

namespace GoogleSearchTests.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            NavigateToLoginPage();
        }

        public void NavigateToLoginPage()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/"); // Replace "/login" with the actual login page URL
        }

        public void EnterUsername(string username)
        {
            usernameInput.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            passwordInput.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            loginButton.Click();
        }

        private IWebElement usernameInput => driver.FindElement(By.Id("user-name"));
        private IWebElement passwordInput => driver.FindElement(By.Id("password"));
        private IWebElement loginButton => driver.FindElement(By.Id("login-button"));
    }
}
