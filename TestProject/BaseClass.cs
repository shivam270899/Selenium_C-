using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject
{
    public class BaseTest{

        public required IWebDriver driver;

        [SetUp]
        public void Initialization(){
            driver = new ChromeDriver();

            driver.Url = "https://www.irctc.co.in/nget/train-search";
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void Decompose(){
            driver.Close();
        }
    }
}