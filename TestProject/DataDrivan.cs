using System.Collections;
using OpenQA.Selenium;

namespace TestProject
{

    [TestFixture]
    public class DataDriven : BaseTest
    {
        [Test]
        [TestCaseSource(nameof(UserDetail))]
        public void DataDrivenMethod(User user)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@href='/login']"));
            element.Click();

            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//*[@name='username']")).SendKeys(user.Username);
            driver.FindElement(By.XPath("//*[@name='password']")).SendKeys(user.Password);
        }

        [Test]
        [TestCaseSource(nameof(UserDetail))]
        public void DataDrivenByExcel(User user)
        {

        }
        public static IList<User> UserDetail()
        {

            IList<User> users = new List<User>{
                new User{Username = "12", Password= "21"},
             };
            return users;
        }

        public static IEnumerable<User> Login()
        {
            yield return new User()
            {
                Username = "123",
                Password = "qwa12"
            };
            yield return new User()
            {
                Username = "123",
                Password = "shajoq"
            };
            yield return new User()
            {
                Username = "123",
                Password = "qiodjlas"
            };
            yield return new User()
            {
                Username = "123",
                Password = "172190j"
            };

        }
    }

    public class User
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
    }
}