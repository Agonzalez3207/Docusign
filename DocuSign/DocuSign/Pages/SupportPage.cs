using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using DocuSign.Framework.Core;

namespace DocuSign.DocuSign.Pages
{
    class SupportPage
    {

        private AutoElement searchBar = new AutoElement(By.Id("home-search-input"));
        private AutoElement submitButton = new AutoElement(By.Id("home-search-submit"));


        public void enterSearchText(string test) {
            searchBar.setText(test);
            clickSubmitButton();
        }

        public void clickSubmitButton() {
            submitButton.click();
        }

    }
}
