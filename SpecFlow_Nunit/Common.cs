using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SpecFlow_Nunit
{
    public class Common
    {
        public static IWebDriver driver;

        public IWebElement FindElementByXpath(string element)
        {
            return driver.FindElement(By.XPath(element));

        }
        public void EnterText(string selector, string content)
        {
            FindElementByXpath(selector).Clear();
            FindElementByXpath(selector).SendKeys(content);
        }

        public void ClickButton(string button)
        {
            WaitForPage(button);
            driver.FindElement(By.XPath(button)).Click();
        }

        public void SelectDropdownList(string field, string selectvalue)
        {
            //ClickButton(field);
            //driver.FindElement(By.XPath(field));
            new SelectElement(FindElementByXpath(field)).SelectByText(selectvalue);
        }

       
        public static LoginPage NavigateToWebsite(string URL)
        {
            driver.Navigate().GoToUrl(URL);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            return new LoginPage();
        }

        public static void WaitForPage(string element)
        {
            //WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementExists(By.XPath(element)));
        }

        [Before]
        public void OpenChrome()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [After]
        public void QuitChrome()
        {
            driver.Quit();
        }

    }
}
