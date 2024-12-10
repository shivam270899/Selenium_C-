using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Safari;
using TestProject;

namespace Utilities{
    public class BrowserUtilies{
        IWebDriver driver;
        public IWebDriver Init(Browser browserName){
            
            switch (browserName)
            {
                case Browser.chrome: driver = new ChromeDriver(); break;
                
                case Browser.safari: driver = new ChromeDriver(); break;

                default: driver = new ChromeDriver(); break;
            }
            
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://practice.expandtesting.com/");
            return driver;
        }

        public void TearDown(IWebDriver driver){
            driver.Close();
        }
    }
}