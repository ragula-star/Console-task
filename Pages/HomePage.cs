using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_task.Pages
{
    public class HomePage
    {
        public void HomePageActions(IWebDriver driver)
        {
            //click on the admin tab
            IWebElement AdministrationTab =driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            AdministrationTab.Click();

            //navigate to the Time and Material page
            IWebElement tmTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmTab.Click();


        }
    }
}
