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

        [Test, Category("Smoke")]
        public void TestWindowMax()
        {
            IWebElement element = driver.FindElement(By.XPath("//*[text()=' BOOK TICKET ']"));
            if(element.Enabled){
                Console.WriteLine("Page lOaded Succesfully");
            }else{
                WebDriverWait wait = new(driver, TimeSpan.FromSeconds(5));
                wait.Until(driver => element.Enabled && element.Displayed ? element  : null);
            }
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

        [Test, Category("Smoke")]
        public void DropdownMultiple()
        {

            IWebElement country_list = driver.FindElement(By.XPath("//*[@class='icp-nav-link-inner']"));

            Actions mouseOver = new(driver);
            mouseOver.MoveToElement(country_list).Perform();

            Thread.Sleep(2000);
            IWebElement element = driver.FindElement(By.XPath("//*[@lang='hi-IN']//i[@class='icp-radio']"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(driver => element.Enabled && element.Displayed ? element : null);

            element.Click();

            Thread.Sleep(4000);
        }
    }
}