@sniff
Feature: Add to Cart
	In order to add to cart an hotel room
	As a pinSight user
	I want to be able to add hotel reservation to cart

Background: SearchHotel
	Given That search results are displayed at pinSight

@addToCart
Scenario: Add to Cart Room	
	When I click on Show Rooms button for the first hotel	
	And I click on Add to Cart button for the first room
	Then Confirmation pop up offering to Checkout should be displayed
