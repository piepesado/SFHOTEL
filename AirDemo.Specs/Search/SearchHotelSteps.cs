using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace HOTELpinSight.Pages
{
    [Binding]
    public class SearchHotelSteps: Steps
    {

        /// <summary>
        /// Web Driver
        /// </summary>
        private IWebDriver _driver;
        private LoginPage _loginPage;
        private HotelSearchPage _hotelSearchPage; //Check how to instanciate should be sth like new HotelSearchPage
        private SearchingPage _searchingPage;
        private ResultsPage _resultsPage;

        [Given(@"That Im logged in at pinSight")]
        public void GivenThatImLoggedInAtPinSight()
        {
            //Given("Given that I navigate to pinSight application");
            //Given("And I enter testuser@mailinator.com as the username");
            //Given("I enter the password");
            //When("I press login");
            //Then("I should land on the Hotel page");


            _driver = WebDriverFactory.Create();
            _loginPage = LoginPage.NavigateTo(_driver);
            _hotelSearchPage = _loginPage.Login("testuser@mailinator.com", "Test@123");
            Assert.IsTrue(_driver.Title.Equals("P UAT Agency(987654) :: Home"));
        }

        [Given(@"I have entered (.*) as the city")]
        public void GivenIHaveEnteredCity(string search)
        {
            _hotelSearchPage.Search(search);                      
        }
        
        [Given(@"I have entered checkin date")]
        public void GivenIHaveEnteredCheckinDate(string checkIn)
        {
            _hotelSearchPage.SelectCheckIn();
        }
        
        [Given(@"I have entered checkout date")]
        public void GivenIHaveEnteredCheckoutDate(string checkOut)
        {
            //_hotelSearchPage.EnterCheckOut = checkOut;
            
        }
        
        [When(@"I click on Search button")]
        public void WhenIClickOnSearchButton()
        {
            _hotelSearchPage.ClickSearchHotel();
        }
        
        [Then(@"Hotel search results should be displayed on screen")]
        public void ThenHotelSearchResultsShouldBeDisplayedOnScreen()
        {
            _searchingPage = new SearchingPage(_driver);
            _searchingPage.EnsurePageIsLoaded();            
        }
    }
}
