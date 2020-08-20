using System.Collections.Generic;
using NUnit.Framework;

namespace SeleniumTest
{
	public class VikramsTest : BaseTest
	{

		[Test]
		public void Test1()
		{
			driver.Navigate().GoToUrl("https://www.commbank.com.au/");

			var myCommbankPage = new CommbankPage(driver);

			var myTravelPage = myCommbankPage.ClickTravelProductsLink();

			Assert.IsTrue(myTravelPage.IsLoaded, "Travel page was not loaded. Page title: " + driver.Title);

			var myTravelMoneyCardPage = myTravelPage.ClickDiscoverMoreButtonUnderTravelMoneyCard_CardItem();

			Assert.AreEqual("Travel Money Card – CommBank", driver.Title, "Travel money card page was not loaded. Page title: " + driver.Title);

			string[] AllSubTopics = myTravelMoneyCardPage.GetAllSubTopics();

			//Assert number of subtopics are as expected and on
			Assert.AreEqual(6, AllSubTopics.Length, "Number of subtopics on the page are not as expected. Number of subtopics " + AllSubTopics.Length);

			//Assert each subtopic is as expected
			Assert.AreEqual("Features & benefits", AllSubTopics[0], "First subtopic is not as expected.");
			Assert.AreEqual("Currency converter", AllSubTopics[1], "Second subtopic is not as expected.");
			Assert.AreEqual("Reload now", AllSubTopics[2], "Third subtopic is not as expected.");
			Assert.AreEqual("Rates & fees", AllSubTopics[3], "Fourth subtopic is not as expected.");
			Assert.AreEqual("How it works", AllSubTopics[4], "Fifth subtopic is not as expected.");
			Assert.AreEqual("Manage your card", AllSubTopics[5], "Sixth subtopic is not as expected.");

			//Logon link only exists on top of the page - so clicking that
			var myTravelMoneyCardApplyPage = myTravelMoneyCardPage.ClickNetbankLink();

			//running short of time - could not complete the rest

		}
	}
}