using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumTest
{
	internal class CommbankPage : BasePage
	{	
		public CommbankPage(IWebDriver driver) : base(driver) { }

		public IWebElement TravelProductsLink => FindElementByLinkText("Travel products");

		internal TravelPage ClickTravelProductsLink()
		{
			TravelProductsLink.Click();
			return new TravelPage(Driver);
		}
	}
}