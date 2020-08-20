using System;
using OpenQA.Selenium;

namespace SeleniumTest
{
	internal class TravelPage : BasePage
	{
		public TravelPage(IWebDriver driver) : base(driver) { }

		public bool? IsLoaded
		{
			get
			{
				try
				{
					return Driver.Title.Equals("Travel - CommBank");
				}
				catch
				{
					return false;
				}
			}
		}

		public IWebElement DiscoverMoreButton => FindElementByCssSelector("[href='/travel/travel-money-card.html?ei=prod_TMC']");

		internal TravelMoneyCardPage ClickDiscoverMoreButtonUnderTravelMoneyCard_CardItem()
		{
			DiscoverMoreButton.Click();
			return new TravelMoneyCardPage(Driver);
		}
	}
}