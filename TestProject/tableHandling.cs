using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TestProject
{

    [TestFixture]
    public class HandlingTable : BaseTest
    {

        [Test]
        public void HandleTable()
        {
            IWebElement element = driver.FindElement(By.XPath("//a[@href='/dynamic-table']"));

            Actions actions = new Actions(driver);
            actions.MoveToElement(element).Click().Build().Perform();
            //element.Click();

            Thread.Sleep(3000);

            IWebElement tableHeader = driver.FindElement(By.XPath("//*[text()='Playground']"));

            Assert.That(tableHeader.Text, Is.EqualTo("Playground"));

            int columnIndex = -1;

            ReadOnlyCollection<IWebElement> webHeader = driver.FindElements(By.XPath("//thead/tr/th"));

            
            Thread.Sleep(3000);
            Console.WriteLine("Total Column: "+webHeader.Count);


            for (int i = 0; i < webHeader.Count; i++)
            {
                Console.WriteLine("Column Name: " +webHeader[i].Text);
                if (webHeader[i].Text == "Network")
                {
                    columnIndex = i + 1;
                    break;
                }
            }

            if (columnIndex == -1)
            {
                throw new Exception("Column 'Network' Not Found");
            }
            Console.WriteLine("Column Found AT: " +columnIndex);

            bool dataFound = false;
            ReadOnlyCollection<IWebElement> tableRows = driver.FindElements(By.XPath("//tbody/tr"));

            Console.WriteLine("Row count:" +tableRows.Count);

            for (int i = 1; i <= tableRows.Count; i++)
            {
                IWebElement rowCell = driver.FindElement(By.XPath($"//tbody/tr[{i}]/td[{columnIndex}]"));
                Console.WriteLine("Cell value:", rowCell.Text);
                if (rowCell.Text.Contains("Mbps"))
                {
                    dataFound = true;
                    rowCell.Click();
                    break;
                };
                if (!dataFound)
                {
                    throw new Exception("Data not found");
                }
            }
        }
    }
}