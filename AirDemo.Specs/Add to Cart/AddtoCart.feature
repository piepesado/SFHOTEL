@sniff
Feature: Add to Cart
	In order to add to cart an hotel room
	As a pinSight user
	I want search hotel results to be displayed on screen

Background: SearchHotel
	Given That search resuts are displayed at pinSight

@select
Scenario: Add to Cart Room	
	When I click on Show Rooms button for the first hotel
	Then Hotel details pop up window is displayed
	When I click on Add to Cart button for the first room
	Then Confirmation pop up offering to Checkout should be displayed
