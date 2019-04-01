using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using DocuSign.Framework.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;

namespace DocuSign.DocuSign.Pages
{
    class ResultsPage
    {
        private AutoElement searchResultsNum = new AutoElement(By.Id("inbenta-total-results"));
        private AutoElement voteUpButton = new AutoElement(By.Id("vote-up"));
        private AutoElement moreButton = new AutoElement(By.Id("show-more-button"));
        private AutoElement cookieSettingsBannerCancel = new AutoElement(By.XPath("/html/body/div[2]/div[1]/div/a"));


        public string getSearchResultsTotal() {
            string text = searchResultsNum.getText();
            string[] resultsArray = text.Split(' ');
            string results = resultsArray[0];

            return results;
        }


        public void verifyResultsTotal() {
            string actualTotal = getSearchResultsTotal();
            int expectedTotal = countHyperLinks();
            bool answer = actualTotal.Equals(expectedTotal);
            Assert.IsTrue(answer);
        }


        public void clickLink(string link) {
            new AutoElement(By.XPath("//*[@id='results']/div[1]/div[1]//*[contains(text(),'" + link + "')]")).click();
        }                                                      

        public void verifyThumbsUpIsDisplayed() {
            bool answer = voteUpButton.isDisplayed();
            Assert.IsTrue(answer);
        }

        public int countHyperLinks() {
            if (cookieSettingsBannerCancel.isDisplayed()) {
                cookieSettingsBannerCancel.click();
            }

            
             while (moreButton.isDisplayed()) {
                    IWebElement button = AutoElement.driver.FindElement(By.Id("show-more-button"));
                    Actions actions = new Actions(AutoElement.driver);
                    actions.MoveToElement(button);
                    actions.Perform();
                    moreButton.click();
              } else { 

               }
        
            

            int count = 0;
            System.Collections.Generic.IList<IWebElement> link = AutoElement.driver.FindElements(By.XPath("//*[@id='results']//*[contains(@class,'faq')]/a")); ;
            count = link.Count();
            return count;
            
        }

            

        


    }
}
