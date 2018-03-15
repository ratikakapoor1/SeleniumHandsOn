Feature: InitialDemo
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

#Scenario: Add two numbers
#	Given I have entered 50 into the calculator
#	And I have entered 70 into the calculator
#	When I press add
#	Then the result should be 120 on the screen
#
#	Scenario: Add two different numbers
#	Given I have entered 30 into the calculator
#	And I have entered -20 into the calculator
#	When I press add
#	Then the result should be 10 on the screen
@parametrize
Scenario Outline: Number addition demo
Given I have entered <num1> into the calculator
	And I have entered <num2> into the calculator
	When I press add
	Then the result should be <result> on the screen
	Examples: 
	| num1 | num2 | result |
	| 40   | 30   | 70     |
	| 10   | 30   | 40     |
	| 80   | -30  | 50     |