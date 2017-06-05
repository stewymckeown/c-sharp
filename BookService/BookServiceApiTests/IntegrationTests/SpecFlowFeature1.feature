Feature: SpecFlowFeature1
	In order to manage books using the book service api
	As a book manager
	I want to see all the books available

@mytag
Scenario: See all books - success
	Given I have a Book Service REST endpoint
	#And I have entered 70 into the calculator
	When I browse to the get books endpoint
	Then the result should be a list of all books
