@sniff
Feature: SearchHotel
	In order to search for an hotel room
	As a pinSight user
	I want search hotel results to be displayed on screen

Background: Login
	Given That Im logged in at pinSight

@search
Scenario: Search Hotel main path
	And I have entered Barcelona, Spain - Barcelona  El Prat Arpt (BCN) as the city
	#And I have entered checkin date
	#And I have entered checkout date
	When I click on Search button
	Then Hotel search results should be displayed on screen
