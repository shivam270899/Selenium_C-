using NUnit.Framework.Internal;
using OpenQA.Selenium;
using Utilities;

namespace TestProject
{

    [TestFixture]
    public class ParallelTest
    {
        IWebDriver driver;

        [Test, Category("Smoke"), Category("Module 1"), Order(1)]
        public void parallelMethod3 ()
        {
            var Driver = new BrowserUtilies().Init(driver, Browser.chrome);
            IWebElement element = Driver.FindElement(By.XPath("//ul/li/a[@class='nav-link p-2'][@href='/tips']"));
            string elementText = element.Text;

            Assert.AreEqual("Automation Tips", elementText);
            element.Click();

            new BrowserUtilies().TearDown(Driver);
        }

        [Test, Category("Smoke"), Category("Module 1"), Order(3)]
        public void parallelMethod1()
        {
            var Driver = new BrowserUtilies().Init(driver, Browser.safari);
            IWebElement element = Driver.FindElement(By.XPath("//ul/li/a[@class='nav-link p-2'][@href='/tips']"));
            string elementText = element.Text;

            Assert.AreEqual("Automation Tips", elementText);
            element.Click();

            new BrowserUtilies().TearDown(Driver);
        }

        [Test, Category("Smoke"), Category("Module 1")]
        public void parallelMethod2()
        {
            var Driver = new BrowserUtilies().Init(driver, Browser.chrome);
            IWebElement element = Driver.FindElement(By.XPath("//ul/li/a[@class='nav-link p-2'][@href='/tips']"));
            string elementText = element.Text;

            Assert.AreEqual("Automation Tips", elementText);
            element.Click();

            new BrowserUtilies().TearDown(Driver);
        }

        [Test, Category("Smoke"), Category("Module 1")]
        public void parallelMethod4()
        {
            var Driver = new BrowserUtilies().Init(driver, Browser.safari);
            IWebElement element = Driver.FindElement(By.XPath("//ul/li/a[@class='nav-link p-2'][@href='/tips']"));
            string elementText = element.Text;

            Assert.AreEqual("Automation Tips", elementText);
            element.Click();

            new BrowserUtilies().TearDown(Driver);
        }

        [Test, Category("Smoke"), Category("Module 1")]
        public void parallelMethod5()
        {
            var Driver = new BrowserUtilies().Init(driver, Browser.chrome);
            IWebElement element = Driver.FindElement(By.XPath("//ul/li/a[@class='nav-link p-2'][@href='/tips']"));
            string elementText = element.Text;

            Assert.AreEqual("Automation Tips", elementText);
            element.Click();

            new BrowserUtilies().TearDown(Driver);
        }

        [Test, Category("Smoke"), Category("Module 1")]
        public void parallelMethod6()
        {
            var Driver = new BrowserUtilies().Init(driver, Browser.chrome);
            IWebElement element = Driver.FindElement(By.XPath("//ul/li/a[@class='nav-link p-2'][@href='/tips']"));
            string elementText = element.Text;

            Assert.AreEqual("Automation Tips", elementText);
            element.Click();

            new BrowserUtilies().TearDown(Driver);
        }
    }
}