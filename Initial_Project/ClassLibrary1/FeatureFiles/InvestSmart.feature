Feature: InvestSmart
	login with correct details

@login
Scenario: Login to IS Website with valid details
	Given I invoke www.investsmart.com.au
	And then click on Log In
	When I put username cton0385@gmail.com and password password and click Log in
	Then the landing page is opened with Log off text
@login
Scenario: Login to IS Website with in-valid details
	Given I invoke www.investsmart.com.au
	And then click on Log In
	When I put username incorrect and password password and click Log in
	Then the page is displayed with error message
@login
Scenario: Login to IS Website with blank password
	Given I invoke www.investsmart.com.au
	And then click on Log In
	When I put username cton0385@gmail.com and blank password and click Log in
	Then the page is displayed with error message that password is mandatory


#@ignore("failing")
#Scenario: Enter filter criteria at Invest with us page to find results
#Given I invoke www.investsmart.com.au
#And I click Invest With Us link
#When I select Strategy as Diversified , Type as SMA , Management Style as Active Stock Selection
#Then No products found should be displayed

Scenario: CheckShares page for Invest Smart website
Given I invoke www.investsmart.com.au
And click on Shares link
When I enter sector as Energy and click Find Shares
Then search results should have Sector as energy

