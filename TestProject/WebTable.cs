using System.Collections;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.Input;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace TestProject
{

    [TestFixture]
    public class Tests

    {

        [Test, Category("Smoke"), Category("Module 1")]
        public void Homepage()
        {   
            IWebDriver driver;
            driver = new ChromeDriver();
            driver.Url = "https://practice.expandtesting.com/";
            driver.Manage().Window.Maximize();

            IWebElement element = driver.FindElement(By.XPath("//ul/li/a[@class='nav-link p-2'][@href='/tips']"));
            string elementText = element.Text;

            Assert.That(elementText, Is.EqualTo("Automation Tips"));
            element.Click();
            
            driver.Close();
        }

        public static IList DataInput()
        {
            List<string> user = new List<string>
            {
                "Hello",
                "Hi,",
                "we"
            };
            return user;
        }

        [Test]
        [TestCaseSource(nameof(DataInput))]
        public void search(string input)
        {   
            IWebDriver driver;
            driver = new ChromeDriver();
            driver.Url = "";
            driver.Manage().Window.Maximize();

            try
            {
                IWebElement element = driver.FindElement(By.XPath("//*[@id='search-inputas2']"));
                element.Click();
                element.SendKeys(input);
            }
            catch (ElementClickInterceptedException e)
            {
                Console.WriteLine(e.Message);
                Assert.Pass("Handle the Click Intercept");
            }
            catch (NoSuchElementException f)
            {
                Console.WriteLine(f.Message);
                //Assert.Pass("Handle the Click Intercept");
                throw;
            }
            catch (Exception e)
            {
                throw new Exception($"exception:, {e.Message}");
            }
            driver.Close();
        }

        [Test]
        [Order(1)]
        [Author("Shivam", "shivam.shah")]
        [Description("Test for dropdown")]
        public void DropDown()
        {   
            IWebDriver driver;
            driver = new ChromeDriver();
            driver.Url = "";
            driver.Manage().Window.Maximize();

            IWebElement element_drop = driver.FindElement(By.XPath("//*[@class='ui-dropdown-label-container ng-tns-c65-11']"));
            element_drop.Click();

            string value = "Sleeper (SL)";

            // Locate all the <li> elements inside the dropdown
            IReadOnlyCollection<IWebElement> dropdownOptions = driver.FindElements(By.XPath("//*[@class='ui-dropdown-items ui-dropdown-list ui-widget-content ui-widget ui-corner-all ui-helper-reset ng-tns-c65-11']//child::li"));

            // Iterate through each option and print its text
            foreach (IWebElement option in dropdownOptions)
            {
                string optionText = option.Text;
                if (optionText == value)
                {
                    option.Click();
                }
            }

            IWebElement element_category = driver.FindElement(By.XPath("//*[@class='ui-dropdown-label-container ng-tns-c65-12']"));
            element_category.Click();

            IReadOnlyCollection<IWebElement> dropdownOptions_category = driver.FindElements(By.XPath("//*[@class='ui-dropdown-items ui-dropdown-list ui-widget-content ui-widget ui-corner-all ui-helper-reset ng-tns-c65-12']//child::li"));
            foreach (IWebElement option in dropdownOptions_category)
            {
                string optionText = option.Text;
                Console.WriteLine(optionText);
                if (optionText == "TATKAL")
                {
                    option.Click();
                    return;
                }
            }

            driver.Close();
        }
    }
}