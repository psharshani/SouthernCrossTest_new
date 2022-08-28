Feature: LoginAndLogout

@mytag
Scenario: Login as a visitor with valid username and password
	Given I navigate to BuggyCars website 
	And enter username and password
	| UserName  | Password   |
	| tester123 | Tester@123 |
	And I click login button
	Then I can see the Logout text on the page