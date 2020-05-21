Feature: TestVerification
	This feature is selenium test 
	It covers the validating and verification of user details
	To ensure all user details are correctly saved

@smakeTest
Scenario: Validating of user details
	Given I am on the homepage of azurewebsites
	When I click on view details button
	Then I should be able to validate user details on the grid
