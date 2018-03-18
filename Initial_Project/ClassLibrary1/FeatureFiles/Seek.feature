Feature: Seek
	login with correct details

@mytag
Scenario: Login to Website
	Given I open www.seek.com.au
	And click on Sign In
	When I enter email ratikakapoor1@gmail.com and password zaq1!QAZ and click Sign in
	Then the home page is opened with name Ratika
