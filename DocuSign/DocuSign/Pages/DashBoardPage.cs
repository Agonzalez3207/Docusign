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
    class DashBoardPage
    {

       private AutoElement myDocsButton = new AutoElement(By.Id("My Docs"));


        public void clickMyDocsTab()
        {
            myDocsButton.click();
        }

        public void clickMyDocsTab(int time)
        {
            myDocsButton.click(time);
        }

    }
}
