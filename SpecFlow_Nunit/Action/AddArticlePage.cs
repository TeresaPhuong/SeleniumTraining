using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecFlow_Nunit
{
    class AddArticlePage : Common
    {
        #region Interface
        private string ArticleTitle_TBX = ".//input[@id='jform_title']";
        private string ArticleAlias_TBX = ".//input[@id='jform_alias']";
        private string ArticleContent_TBX = ".//body[@id='tinymce']";
        private string ArticleStatus_Field = ".//select[@name='jform[state]']";
        private string ArticleCategory_Fied = ".//div[@id='jform_catid_chzn']/a";
        private string Save_BTN = ".//div[@id='toolbar-apply']/button";
        private string SaveClose_BTN = ".//div[@id='toolbar-save']/button";
        private string SaveNew_BTN = ".//div[@id='toolbar-save-new']/button";
        private string Cancel_BTN = ".//div[@id='toolbar-cancel']/button";
        private string ContentFrame_Xpath = ".//iframe[@id='jform_articletext_ifr']";

        #endregion

        #region Method
        private void EnterArticleTitle(string articletitle)
        {
            EnterText(ArticleTitle_TBX, articletitle);
        }

        private void EnterArticleAlias(string articlealias)
        {
            EnterText(ArticleAlias_TBX, articlealias);
        }

        private void EnterArticleContent(string articlecontent)
        {
            IWebElement contentFrame = driver.FindElement(By.XPath(ContentFrame_Xpath));
            driver.SwitchTo().Frame(contentFrame);
            IWebElement Content_TBX = driver.FindElement(By.XPath(ArticleContent_TBX));
            Content_TBX.SendKeys(articlecontent);
            driver.SwitchTo().DefaultContent();
        }
        
        private void SelectStatus(string status)
        {
            SelectDropdownList(ArticleStatus_Field,status);
            //ClickButton(ArticleStatus_Field);
            //new SelectElement(driver.FindElement(By.XPath(ArticleStatus_Field))).SelectByText(status);
        }

        private void SelectCategory(string category)
        {
            try
            {
                //string categoryvalue = "*" + category;
                SelectDropdownList(ArticleCategory_Fied, category);
            }
            catch
            {Console.WriteLine("Category is not existed.");}
        }

        private void ClickSaveBTN()
        {
            ClickButton(Save_BTN);
        }

        private void ClickSaveCloseBTN()
        {
            ClickButton(SaveClose_BTN);
        }

        private void ClickSaveNewBTN()
        {
            ClickButton(SaveNew_BTN);
        }

        //private void ClickCancelBTN()
        //{
        //    ClickButton(Cancel_BTN);
        //}

        public ArticleManagerPage AddNewArticle(string title, string alias, string content, string status, string category)
        {
            WaitForPage(ArticleTitle_TBX);
            EnterArticleTitle(title);
            EnterArticleAlias(alias);
            EnterArticleContent(content);
            SelectStatus(status);
            SelectCategory(category);
            ClickSaveCloseBTN();
            Thread.Sleep(3000);
            return new ArticleManagerPage();
        }
        #endregion
    }
}
