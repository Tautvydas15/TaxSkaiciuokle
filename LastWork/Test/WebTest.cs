﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Webtest

{
    class TestWebDriver
    {
        [Test]
        public static void TestChromeDriver()
        {
            IWebDriver driver = new ChromeDriver
            {
                Url = "https://www.tax.lt/"
            };
            Thread.Sleep(2000);
            driver.Close();
        }

        [Test]
        public static void TestFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver
            {
                Url = "https://www.tax.lt/"
            };
            Thread.Sleep(2000);
            driver.Close();
        }


    }
}

