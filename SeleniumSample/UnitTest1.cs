using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using Assert = NUnit.Framework.Assert;

namespace SeleniumSample
{
    [TestFixture]
    public class Tests
    {
        IWebDriver _webDriver;

        [SetUp]
        public void startBrowser()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");
            _webDriver = new ChromeDriver(chromeOptions);
        }

        [Test]
        [Category("smoke")]
        public void test1()
        {
            _webDriver.Navigate().GoToUrl("https://www.google.com");
            Assert.True(_webDriver.Title.Contains("Google"));
        }

        [Test]
        [Category("regression")]
        public void test2()
        {
            _webDriver.Navigate().GoToUrl("https://www.google.com");
            Assert.True(_webDriver.Title.Contains("Giri"));
        }

        [Test]
        [Category("regression")]
        public void test3()
        {
            _webDriver.Navigate().GoToUrl("https://www.google.com");
            Assert.True(_webDriver.Title.Contains("Google"));
        }
        [Test]
        [Category("regression")]
        public void test4()
        {
            _webDriver.Navigate().GoToUrl("https://www.google.com");
            Assert.True(_webDriver.Title.Contains("Google"));
        }

        [Test]
        [Category("regression")]
        public void tes5()
        {
            _webDriver.Navigate().GoToUrl("https://www.google.com");
            Assert.True(_webDriver.Title.Contains("Giri"));
        }

        [TearDown]
        public void closeBrowser()
        {
            _webDriver.Close();
        }

    }
}
