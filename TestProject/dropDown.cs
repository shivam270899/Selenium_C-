using System.Collections.ObjectModel;
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
    public class Tests : BaseTest

    {

        [Test, Category("Smoke"), Category("Module 1")]
        public void TestWindowMax_MultipleWindow()
        {
            IWebElement element = driver.FindElement(By.XPath("//ul/li/a[@class='nav-link p-2'][@href='/tips']"));
            string elementText = element.Text;

            Assert.AreEqual("Automation Tips", elementText);
            element.Click();

        }

        [Test, Category("Regresion")]
        public void WebLoginTest()
        {

            IWebElement loginLink = driver.FindElement(By.Id("loginLink"));
            loginLink.Click();

            IWebElement userName = driver.FindElement(By.Name("UserName"));
            userName.SendKeys("Alpha");

            IWebElement password = driver.FindElement(By.XPath("//*[@type='password']"));
            password.SendKeys(Keys.Return);
            password.SendKeys("1212@qw132wse");

            IWebElement loginBtn = driver.FindElement(By.XPath("//*[@type='submit']"));
            loginBtn.Submit();
        }

        [Test]
        public void DropDownSingleSelect()
        {
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
        }
    }
}