Feature: Google Search
	1st code selenium specflow


Scenario: Perform Google Search
    Given I navigate to www.google.com
	When I search for kitten
	Then Google should return valid search results
