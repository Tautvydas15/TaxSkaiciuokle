using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastWork.Test
{
    internal class TestFullName
    {
        [Test]
        public static void TestName()
        {
            string name = "Tautvydas";

            IWebDriver driver = new ChromeDriver
            {
                Url = "https://www.tax.lt/login"
            };

            IWebElement fullNameInputField = driver.FindElement(By.Id("user_login"));
            fullNameInputField.SendKeys(name);

            IWebElement submitButton = driver.FindElement(By.CssSelector("#submit"));
            submitButton.Click();

            IWebElement result = driver.FindElement(By.Id("name"));
            Assert.AreEqual($"Name:{name}", result.Text, "Name is wrong!");

            driver.Close();
        }

    }
}


