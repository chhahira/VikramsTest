using OpenQA.Selenium;

namespace SeleniumTest
{
	internal class BasePage
	{
		public IWebDriver Driver { get; set; }

		public BasePage(IWebDriver driver)
		{
			Driver = driver;
		}

		public IWebElement FindElementById(string ElementId)
		{
			var element = Driver.FindElementWithWait(By.Id(ElementId), 30);
			return element;				
		}

		public IWebElement FindElementByXpath(string ElementXpath)
		{
			var element = Driver.FindElementWithWait(By.XPath(ElementXpath), 30);
			return element;
		}

		public IWebElement FindElementByLinkText(string ElementLinkText)
		{
			var element = Driver.FindElementWithWait(By.LinkText(ElementLinkText), 30);
			return element;
		}

		public IWebElement FindElementByCssSelector(string ElementCssSelector)
		{
			var element = Driver.FindElementWithWait(By.CssSelector(ElementCssSelector), 30);
			return element;
		}
	}
}
