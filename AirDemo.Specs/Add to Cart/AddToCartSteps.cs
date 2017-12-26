using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using HOTELpinSight.Pages;

namespace HOTELpinSight.Add_to_Cart
{
    [Binding]
    public class AddToCartSteps
    {

        const string DESTINATION = "Barcelona, Spain - Barcelona  El Prat Arpt (BCN)";

        private IWebDriver _driver;
        private LoginPage _loginPage;
        private HotelSearchPage _hotelSearchPage;
        private ResultsPage _resultsPage;
        private CheckOutPage _checkOutPage;

        [Given(@"That search results are displayed at pinSight")]
        public void GivenThatSearchResultsAreDisplayedAtPinSight()
        {
            _driver = WebDriverFactory.Create();
            _loginPage = LoginPage.NavigateTo(_driver);
            _hotelSearchPage = _loginPage.Login("hnorte@travelleaders.com", "zaq1ZAQ!");
            _hotelSearchPage.Search(DESTINATION);
            _hotelSearchPage.ClickSearch();
        }
        
        [When(@"I click on Show Rooms button for the first hotel")]
        public void WhenIClickOnShowRoomsButtonForTheFirstHotel()
        {
            _resultsPage.ClickShowRooms();
        }
        
        [When(@"I click on Add to Cart button for the first room")]
        public void WhenIClickOnAddToCartButtonForTheFirstRoom()
        {
            _resultsPage.ClickAddToCart();
            _resultsPage.ClickCheckOutButton();
        }
        
        [Then(@"Confirmation pop up offering to Checkout should be displayed")]
        public void ThenConfirmationPopUpOfferingToCheckoutShouldBeDisplayed()
        {
            Assert.IsTrue(_driver.FindElement(By.Id("btnCheckOutCart")).Displayed);
        }
    }
}
