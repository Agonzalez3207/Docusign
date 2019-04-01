using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using DocuSign.Framework.Core;
using DocuSign.DocuSign.Pages;

namespace DocuSign
{
    [TestClass]
    public class UnitTest1
    {

        SupportPage SupportPage = new SupportPage();
        ResultsPage ResultsPage = new ResultsPage();
        LoginPage loginPage = new LoginPage();
        DashBoardPage dashBoardPage = new DashBoardPage();
        MyDocsPage myDocs = new MyDocsPage();

        [TestInitialize]
        public void TestSetup()
        {
           IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://support.docusign.com/");
            driver.Manage().Window.Maximize();
            AutoElement.driver = driver;


        }


        [TestMethod]
        public void VerifyNumberofResults()
        {
            SupportPage.enterSearchText("Rooms for Real Estate");
            ResultsPage.verifyResultsTotal();
        }

        [TestMethod]
        public void verifyThumbsUpButton() {
            SupportPage.enterSearchText("Rooms for Real Estate");
            ResultsPage.clickLink("Rooms for Real Estate Quick Start");
            ResultsPage.verifyThumbsUpIsDisplayed();

        }


        [TestCleanup]
        public void testCleanUp() {
            AutoElement.driver.Close();
        }

    

    }
}
