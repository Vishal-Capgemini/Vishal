﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace Test2
{
    [TestFixture]
    class TestEMPUpdate
    {
        private IWebDriver driver;
        public string homeURL;
        [SetUp]
        public void SetupTest()
        {
            homeURL = "http://localhost:52647/EMPUpdate";
            driver = new ChromeDriver();
        }
        [Test]
        public void EmployUpdateSuccess()
        {
            driver.Navigate().GoToUrl(homeURL);
            Thread.Sleep(3000);
            driver.FindElement(By.Name("txtEmpno")).SendKeys("1");
            driver.FindElement(By.Name("txtEmpno")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Name("txtName")).Clear();
            Thread.Sleep(3000);
            driver.FindElement(By.Name("txtName")).SendKeys("Arun J");
            Thread.Sleep(3000);
            driver.FindElement(By.Name("txtDept")).Clear();
            Thread.Sleep(3000);
            driver.FindElement(By.Name("txtDept")).SendKeys("WCF");
            Thread.Sleep(3000);
            driver.FindElement(By.Name("txtDesig")).Clear();
            driver.FindElement(By.Name("txtDesig")).SendKeys("Manager");
            Thread.Sleep(3000);
            driver.FindElement(By.Name("txtBasic")).Clear();
            driver.FindElement(By.Name("txtBasic")).SendKeys("88999");
            Thread.Sleep(7000);
            driver.FindElement(By.Name("btnUpdate")).Click();
            //Type LastName in the LastName text box
            //string result = driver.FindElement(By.CssSelector("span")).Text;
            //StringAssert.AreEqualIgnoringCase("Record Updated...", result);
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
