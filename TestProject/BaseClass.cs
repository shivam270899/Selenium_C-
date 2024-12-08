using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject
{
    public class BaseTest{

        public required IWebDriver driver;

        [SetUp]
        public void Initialization(){
            driver = new ChromeDriver();

            driver.Url = "https://practice.expandtesting.com/";
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void Decompose(){
            driver.Close();
        }
    }
}