using NUnit.Framework.Internal;
using OpenQA.Selenium;
using Utilities;

namespace TestProject
{

    [TestFixture]
    public class ParallelTest: BrowserUtilies
    {   
        
        [Test, Category("Smoke"), Category("Module 1"), Order(1)]
        public void parallelMethod3 ()
        {
            var Driver = new BrowserUtilies().Init(Browser.chrome);
            IWebElement element = Driver.FindElement(By.XPath("//ul/li/a[@class='nav-link p-2'][@href='/tips']"));
            string elementText = element.Text;

            Assert.That(elementText, Is.EqualTo("Automation Tips"));
            element.Click();

            new BrowserUtilies().TearDown(Driver);
        }

        [Test, Category("Smoke"), Category("Module 1"), Order(3)]
        public void parallelMethod1()
        {
            var Driver = new BrowserUtilies().Init(Browser.safari);
            IWebElement element = Driver.FindElement(By.XPath("//ul/li/a[@class='nav-link p-2'][@href='/tips']"));
            string elementText = element.Text;

            Assert.That(elementText, Is.EqualTo("Automation Tips"));
            element.Click();

            new BrowserUtilies().TearDown(Driver);
        }

        [Test, Category("Smoke"), Category("Module 1")]
        public void parallelMethod2()
        {
            var Driver = new BrowserUtilies().Init(Browser.chrome);
            IWebElement element = Driver.FindElement(By.XPath("//ul/li/a[@class='nav-link p-2'][@href='/tips']"));
            string elementText = element.Text;

            Assert.That(elementText, Is.EqualTo("Automation Tips"));
            element.Click();

            new BrowserUtilies().TearDown(Driver);
        }

        [Test, Category("Smoke"), Category("Module 1")]
        public void parallelMethod4()
        {
            var Driver = new BrowserUtilies().Init(Browser.safari);
            IWebElement element = Driver.FindElement(By.XPath("//ul/li/a[@class='nav-link p-2'][@href='/tips']"));
            string elementText = element.Text;

            Assert.That(elementText, Is.EqualTo("Automation Tips"));
            element.Click();

            new BrowserUtilies().TearDown(Driver);
        }

        [Test, Category("Smoke"), Category("Module 1")]
        public void parallelMethod5()
        {
            var Driver = new BrowserUtilies().Init(Browser.chrome);
            IWebElement element = Driver.FindElement(By.XPath("//ul/li/a[@class='nav-link p-2'][@href='/tips']"));
            string elementText = element.Text;

            Assert.That(elementText, Is.EqualTo("Automation Tips"));
            element.Click();

            new BrowserUtilies().TearDown(Driver);
        }

        [Test, Category("Smoke"), Category("Module 1")]
        public void parallelMethod6()
        {
            var Driver = new BrowserUtilies().Init(Browser.chrome);
            IWebElement element = Driver.FindElement(By.XPath("//ul/li/a[@class='nav-link p-2'][@href='/tips']"));
            string elementText = element.Text;

            Assert.That(elementText, Is.EqualTo("Automation Tips"));
            element.Click();

            new BrowserUtilies().TearDown(Driver);
        }
    }
}