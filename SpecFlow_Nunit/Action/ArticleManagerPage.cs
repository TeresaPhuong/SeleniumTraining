using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SpecFlow_Nunit
{
    public class ArticleManagerPage:Common
    {
        #region Interface
        private string verifytext = ".//*[contains(text(),'{0}')]";
        #endregion
        #region Method
        public bool IsSuccessMessageDisplay(string messagecontent)
        {
            if (FindElementByXpath(string.Format(verifytext, messagecontent)).Displayed == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsArticleDisplay(string title)
        {
            if (FindElementByXpath(string.Format(verifytext,title)).Displayed==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
