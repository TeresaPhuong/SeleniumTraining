using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace SpecFlow_Nunit
{
    public class LoginPage:Common
    {
        #region Interface
        private string Username_TBX = ".//input[@id='mod-login-username']";
        private string Password_TBX = ".//input[@id='mod-login-password']";
        private string Login_BTN = ".//button[@class='btn btn-primary btn-block btn-large']";
        #endregion

        #region Method
        public HomePage LoginToJoomla(string username, string password)
        {
            EnterText(Username_TBX,username);
            EnterText(Password_TBX, password);
            ClickButton(Login_BTN);
            return new HomePage();
        }
        #endregion
    }
}
