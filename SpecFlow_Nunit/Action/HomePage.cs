using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SpecFlow_Nunit
{
    public class HomePage : Common
    {
        #region Interface
        private string NewArticle_BTN = ".//*[@class='j-links-groups']//span[contains(text(),'New Article')]";
        private string ArticleManager_BTN = "";
        #endregion

        #region Method
        public void ClickButtonNewArticle()
        {
            IdentifyButton(NewArticle_BTN);
            ClickButton(NewArticle_BTN);
        }

        private string IdentifyButton(string buttonname)
        {
            switch(buttonname)
            {
                case "New Article":
                    return buttonname = ".//*[@class='j-links-groups']//span[contains(text(),'New Article')]";
                case "Article":
                    return buttonname = ArticleManager_BTN;
                default:
                    //Console.WriteLine("Button name does not exist.");
                    return "Button name does not exist.";
            }
        }
        #endregion

    }
}
