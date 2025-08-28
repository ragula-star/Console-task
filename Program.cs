using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


using Console_task.Pages;

public class Program
{
    private static void Main(string[] args)
    {
        //open chrome browser
        IWebDriver driver = new ChromeDriver();

        //maximize the browser window
        driver.Manage().Window.Maximize();

        LoginPage loginPageobj = new LoginPage();
        loginPageobj.LoginActions(driver);

        HomePage homepageobj = new HomePage();
        homepageobj.HomePageActions(driver);

        TMPage tmPageobj = new TMPage();
        tmPageobj.CreateTMPage(driver);



        
    }
}