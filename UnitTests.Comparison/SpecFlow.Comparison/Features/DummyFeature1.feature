Feature: DummyFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
		And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen
	
Scenario Outline: Add two numbers 2
	Given I have entered <First> into the calculator
		And I have entered <Second> into the calculator
	When I press add
	Then the result should be <Result> on the screen

	Examples: 
		| First | Second | Result |
		| 10    | 20     | 30     |
		| 20    | 30     | 50     |