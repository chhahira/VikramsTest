using System;
using OpenQA.Selenium;

namespace SeleniumTest
{
	internal class TravelMoneyCardApplyPage : BasePage
	{
		public TravelMoneyCardApplyPage(IWebDriver driver) : base(driver) { }

		public IWebElement SelectOnline => FindElementByXpath("(//*[@class='selectContainer'])[1]//span");
		
	}
}