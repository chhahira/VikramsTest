using System;
using System.Collections.Generic;
using OpenQA.Selenium;


namespace SeleniumTest
{
	internal class TravelMoneyCardPage : BasePage
	{
		public TravelMoneyCardPage(IWebDriver driver) : base(driver) { }

		public IWebElement NetbankLink => FindElementByXpath("(//*[@class='large-disc']//a[contains(text(),'NetBank')])[1]");

		public string[] GetAllSubTopics()
		{
			IList<IWebElement> allTopicsOnPage = Driver.FindElements(By.XPath("//*[@class='anchor']//ul//li//a"));

			var numberOfSubTopicsOnPage = allTopicsOnPage.Count;

			string[] AllSubTopics = new string[numberOfSubTopicsOnPage];

			for(int i=0; i< numberOfSubTopicsOnPage; i++)
			{
				AllSubTopics[i] = allTopicsOnPage[i].Text;
			}

			return AllSubTopics;
		}

		internal void ClickLogonLink()
		{
			throw new NotImplementedException();
		}

		internal TravelMoneyCardApplyPage ClickNetbankLink()
		{
			NetbankLink.Click();
			return new TravelMoneyCardApplyPage(Driver);
		}
	}
}