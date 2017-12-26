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
        //private ResultsPage _resultsPage;

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
            _hotelSearchPage = _loginPage.Login("hnorte@travelleaders.com", "zaq1ZAQ!");
            Assert.IsTrue(_driver.Title.Equals("Login"));            
            Assert.IsTrue(_driver.Url.Equals("http://qa-managetlg.travelnxt.com/login?returnUrl=/"));
        }

        [Given(@"I have entered (.*) as the city")]
        public void GivenIHaveEnteredCity(string search)
        {
            
            //Assert.IsTrue(_driver.Title.Equals("TLGAgencyTest :: Home"));
            //Assert.IsTrue(_driver.Url.Equals("http://qa-tlg.travelnxt.com/Main"));
            _hotelSearchPage.Search(search);                      
        }

        /*
        [Given(@"I have entered checkin date")]
        public void GivenIHaveEnteredCheckinDate()
        {
            _hotelSearchPage.SelectCheckIn();
        }
        
        [Given(@"I have entered checkout date")]
        public void GivenIHaveEnteredCheckoutDate()
        {
            _hotelSearchPage.SelectCheckOut();            
        }
        */
        
        [When(@"I click on Search button")]
        public void WhenIClickOnSearchButton()
        {
            _hotelSearchPage.ClickSearch();
        }
        
        [Then(@"Hotel search results should be displayed on screen")]
        public void ThenHotelSearchResultsShouldBeDisplayedOnScreen()
        {
            _searchingPage = new SearchingPage(_driver);
            _searchingPage.EnsurePageIsLoaded();            
        }
    }
}
