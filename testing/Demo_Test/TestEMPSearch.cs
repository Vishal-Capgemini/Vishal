using System;
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
    class TestEMPSearch
    {
        private IWebDriver driver;
        public string homeURL;
        [SetUp]
        public void SetupTest()
        {
            homeURL = "http://localhost:52647/EMPSearch";
            driver = new ChromeDriver();
        }
        [Test]
        public void EmploySearchSuccess()
        {
            driver.Navigate().GoToUrl(homeURL);
            Thread.Sleep(3000);
            driver.FindElement(By.Name("txtEmpno")).SendKeys("1");
            driver.FindElement(By.Name("btnSearch")).Click();
            //Type LastName in the LastName text box
            string name = driver.FindElement(By.Name("txtName")).GetAttribute("value").ToString();
            StringAssert.AreEqualIgnoringCase("Vishal", name);
            string desig = driver.FindElement(By.Name("txtDesig")).GetAttribute("value").ToString();
            StringAssert.AreEqualIgnoringCase("ANALYST", desig);
            string dept = driver.FindElement(By.Name("txtDept")).GetAttribute("value").ToString();
            StringAssert.AreEqualIgnoringCase("DOTNET", dept);
            string basic = driver.FindElement(By.Name("txtBasic")).GetAttribute("value").ToString();
            StringAssert.AreEqualIgnoringCase("13001", basic);
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
