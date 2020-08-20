using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest
{
	public static class WebDriverExtention
	{
		public static IWebElement FindElementWithWait(this IWebDriver driver, By by, int timeoutInSeconds)
		{
			if(timeoutInSeconds > 0)
			{
				var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
				wait.Until(drv =>
				{
					try
					{
						return drv.FindElement(by);
					}
					catch (NoSuchElementException)
					{
						return null;
					}
				});
			}
			return driver.FindElement(by);
		}
	}
}
