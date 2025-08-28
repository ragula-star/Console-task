using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_task.Pages
{
    public class TMPage
    {
        public void CreateTMPage(IWebDriver driver)
        {
            //click on the create new button
            IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createButton.Click();

            
            //Navigate to the typecode dropdown and select time
            IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typecodeDropdown.Click();
            

            IWebElement timeOption = driver.FindElement(By.ClassName("k-item"));
            

            //identify the code textbox and enter the code
            IWebElement codetextbox = driver.FindElement(By.Id("Code"));
            codetextbox.SendKeys("Test Programmer");
            Thread.Sleep(3000);
            

            //identify the description textbox and enter the description
            IWebElement descriptiontextbox = driver.FindElement(By.Id("Description"));
            descriptiontextbox.SendKeys("tester");
            Thread.Sleep(3000);
            

            //identify the price per unit textbox and enter the price per' unit
            IWebElement pricetextbox = driver.FindElement(By.Id("Price"));
            pricetextbox.SendKeys("12");
            Thread.Sleep(3000);

            //locate the choose file button
            IWebElement choosefilebutton = driver.FindElement(By.Id("files"));
            choosefilebutton.Click();

            //upload a file
            choosefilebutton.SendKeys("\"C:\\Users\\muthu\\OneDrive\\Documents\\_Ragula-CV.docx\"");
            choosefilebutton.Click();

            try

            {
                IWebElement checkfileuploaded = driver.FindElement(By.XPath("//span[contains(text(),'_Ragula-CV.docx')]"));
                Console.WriteLine("File uploaded successfully");
            }
            catch
            {
                Console.WriteLine("File not uploaded");
            }


            //Click on the save button
            IWebElement savebutton = driver.FindElement(By.Id("SaveButton"));
            savebutton. Click();




        }
    }
}
