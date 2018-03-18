Feature: Jabong
	test jabong home page


Scenario: Click the 1st linkto check images appear
	Given I have opened www.jabong.com home page
	When I click on link New in Clothing under Women
    Then a new page should be opened with title  New Collection in Clothing for Women - Buy Latest Design Women Clothing Online | Jabong.com and have images
