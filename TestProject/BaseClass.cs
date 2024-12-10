using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject
{
    public class BaseTest{

        public required IWebDriver driver;

        [SetUp]
        public void Initialization(){
            driver = new ChromeDriver();

            driver.Url = "https://www.automationexercise.com/";
            driver.Manage().Window.Maximize();

        }

        [TearDown]
        public void Decompose(){

            if(TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed){
                TakeScreenShot(TestContext.CurrentContext.Test.Name);
            }

            driver.Close();
        }

        public void TakeScreenShot(string name){
            ITakesScreenshot screenshot = (ITakesScreenshot)driver;
            Screenshot capture = screenshot.GetScreenshot();
            capture.SaveAsFile("/Users/shivam/Desktop/selenium/TestProject/Screenshot/a.jpeg");
            Console.WriteLine("ScreenShot Path:", name);
        }
    }
}