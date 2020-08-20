using System.IO;
using System.Reflection;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumTest
{
	public class BaseTest
	{
		public IWebDriver driver { get; set; }

		[SetUp]
		public void RunBeforeEveryTest()
		{
			driver = GetChromeDriver();
		}
		

		[TearDown]
		public void RunAfterEveryTest()
		{
			driver.Quit();
		}

		public IWebDriver GetChromeDriver()
		{
			ChromeOptions myChromeOptions = new ChromeOptions();
			myChromeOptions.AddArguments("--start-maximized");		

			var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			
			return new ChromeDriver(outPutDirectory, myChromeOptions);
		}
	}
}
