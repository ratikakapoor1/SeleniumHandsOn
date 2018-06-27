Feature: IS Share Page
	Verify the shares page for IS website

Scenario: Check Shares page for Invest Smart website
Given I invoke Invest Smart application
And click on Shares link
When I enter sector as Energy and click Find Shares
Then search results should have Sector as energy
