using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlow_Nunit
{
    [Binding]
    public sealed class JoomlaArticleFeatureSteps:Common
    {
        LoginPage LoginPage = new LoginPage();
        HomePage HomePage = new HomePage();
        AddArticlePage AddArticle = new AddArticlePage();
        ArticleManagerPage ArticleManager = new ArticleManagerPage();
        
        [Given(@"I navigate to the page (.*)")]
        public void NavigateToThePage(string p0)
        {
            Common.NavigateToWebsite(p0);
        }

        [Given(@"I login in the page with username (.*) and password (.*)")]
        public void LoginInThePageWithUsernameAndPassword(string p0, string p1)
        {
            HomePage = LoginPage.LoginToJoomla(p0, p1);
        }

        [When(@"I click New Article button")]
        public void ClickButton()
        {
            HomePage.ClickButtonNewArticle();
        }


        [When(@"I add new article with (.*) (.*) (.*) (.*) (.*)")]
        public void EnterInto(string p0, string p1, string p2, string p3, string p4)
        {
            AddArticle.AddNewArticle(p0, p1, p2, p3, p4);
        }

        [Then(@"Successful message (.*) should display.")]
        public void ThenSuccessfulMessageShouldDisplay_(string p0)
        {
            ArticleManager.IsSuccessMessageDisplay(p0);
        }

        [Then(@"The Article's title (.*) should display in Article table\.")]
        public void ThenTheArticleSTitleShouldDisplayInArticleTable_(string articletitle)
        {
            ArticleManager.IsArticleDisplay(articletitle);
        }

    }
}

