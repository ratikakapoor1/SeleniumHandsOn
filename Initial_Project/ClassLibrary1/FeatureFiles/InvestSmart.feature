Feature: InvestSmart
	login with correct details


Scenario: Login to IS Website with valid details
	Given I invoke www.investsmart.com.au
	And then click on Log In
	When I put username cton0385@gmail.com and password password and click Log in
	Then the landing page is opened with Log off text

Scenario: Login to IS Website with in-valid details
	Given I invoke www.investsmart.com.au
	And then click on Log In
	When I put username incorrect and password password and click Log in
	Then the page is displayed with error message

Scenario: Login to IS Website with blank password
	Given I invoke www.investsmart.com.au
	And then click on Log In
	When I put username cton0385@gmail.com and blank password and click Log in
	Then the page is displayed with error message that password is mandatory