Feature: Book

@tag1
Scenario: Searching for a book Harry Potter
	Given there is a book called Harry Potter
	When I search for a book called Harry Potter
	Then the name of the book returned should be Harry Potter
