Feature: Registration

@mytag
Scenario: Register page as a visitor successfully
	Given I navigate to BuggyCars website
	And click the Register button
	And I enter registration details
	| Login    | FirstName | LastName | Password  | ConfirmPassword |
	| Kaesy123 | Kaesy     | Hannan   | Kaesy@123 | Kaesy@123       |
	And I click Register button
	Then I see the Success message
	#And I enter <Login>,<FirstName>,<LastName>,<Password> and <ConfirmPassword>

#Scenario: Register page as a visitor when login name already exist
#Given I navigate to BuggyCars website
#	And click the Register button
#	And I enter registration details
#	| Login    | FirstName | LastName | Password  | ConfirmPAssword |
#	| Kaesy123 | Kaesy     | Smith   | Kaesy@333 | Kaesy@333       |
#	And I click Register button
#	Then I see the Unuccess message
#	
#Scenario: Register page as a visitor when password and confirmpassword missmatched
#Given I navigate to BuggyCars website
#	And click the Register button
#	And I enter registration details
#	| Login    | FirstName | LastName | Password  | ConfirmPAssword |
#	| Kaesy123 | Kaesy     | Smith   | Kaesy@333 | Kaesy@333       |
#	And I click Register button
#	Then I see the Validation message