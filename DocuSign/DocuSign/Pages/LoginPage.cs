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
    class LoginPage
    {

       private AutoElement loginTextBox = new AutoElement(By.Id("Email"));
       private AutoElement continueButton = new AutoElement(By.Id("continue"));
       private AutoElement passwordTextBox = new AutoElement(By.Id("Password"));
       private AutoElement loginButton = new AutoElement(By.Id("loginToDtr"));


        //inputs selected userEmail, clicks continue, inputs selected password, and logs on to site
        public void login(string userEmail, string password)
        {
            loginTextBox.setText(userEmail);
            continueButton.click();
            passwordTextBox.setText(password);
            loginButton.click();

        }






    }
}
