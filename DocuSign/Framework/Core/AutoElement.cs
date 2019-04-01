using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace DocuSign.Framework.Core
{
    class AutoElement
    {

        public  static IWebDriver driver;
        private By locator;


        //Finds location of the web Element
        private  IWebElement findWebElement(int time)
        {
            IWebElement foundElement = null;

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            try
            {
                foundElement = wait.Until(ExpectedConditions.ElementExists(this.locator));
            }
            catch (TimeoutException e)
            {


            }

            return foundElement;


        }


        //Finds location of the web Element
        private  IWebElement findWebElement()
        {
            IWebElement foundElement = null;

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            try
            {
                foundElement = wait.Until(ExpectedConditions.ElementIsVisible(this.locator));
            }
            catch (TimeoutException e)
            {


            }

            return foundElement;


        }


        public AutoElement(By locator)
        {
            this.locator = locator;

        }

        public void click(int time)
        {
            findWebElement(time).Click();

        }

        public void click()
        {
            findWebElement().Click();

        }


        public bool isDisplayed()
        {
            IWebElement element = findWebElement();
            if (element == null)
            {
                return false;
            }
            else
            {
                return element.Displayed;
            }

        }



        public bool isDisplayed(int time)
        {
            IWebElement element = findWebElement(time);
            if (element == null)
            {
                return false;
            }
            else
            {
                return element.Displayed;
            }

        }


        public void setText(string text)
        {
            IWebElement element = findWebElement(10);
            element.Clear();
            element.SendKeys(text);

        }


        public string getText()
        {
            return findWebElement().Text;
        }








    }
}
