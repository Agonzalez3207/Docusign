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
    class MyDocsPage
    {
        private AutoElement myDocumentsButton = new AutoElement(By.XPath("//*[contains(@class, 'status-tag icof icof-folder')]"));
        private AutoElement documentPdf;

        public void clickMyDocumentsButton()
        {
            myDocumentsButton.click();
        }

        public void openPdf(string pdfTitle)
        {
            documentPdf = new AutoElement(By.XPath("//*[contains(@data-doc-name, '" + pdfTitle + "')]"));
            documentPdf.click();
        }

    }
}
