using System;
using TechTalk.SpecFlow;

namespace HOTELpinSight.Pages
{
    [Binding]
    public class AddToCartSteps
    {
        [Given(@"That search resuts are displayed at pinSight")]
        public void GivenThatSearchResutsAreDisplayedAtPinSight()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on Show Rooms button for the first hotel")]
        public void WhenIClickOnShowRoomsButtonForTheFirstHotel()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on Add to Cart button for the first room")]
        public void WhenIClickOnAddToCartButtonForTheFirstRoom()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Hotel details pop up window is displayed")]
        public void ThenHotelDetailsPopUpWindowIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Confirmation pop up offering to Checkout should be displayed")]
        public void ThenConfirmationPopUpOfferingToCheckoutShouldBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
