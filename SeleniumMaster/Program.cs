using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace SeleniumMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "213548897";
            string pass = "************";

            var driver = new EdgeDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://www.acesso.gov.pt/v2/loginForm?partID=PFAP&path=/geral/dashboard");

            var label = driver.FindElement(By.CssSelector("label[for='tab2']"));
            label.Click();

            var usernameField = driver.FindElement(By.Name("username"));
            usernameField.SendKeys(username);

            var passwordField = driver.FindElement(By.Name("password"));
            passwordField.SendKeys(pass);

            var login = driver.FindElement(By.Name("sbmtLogin"));
            login.Click();
        }
    }
}
