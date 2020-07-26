Feature: QAEngineerTest
	I want to login to given url
	

@mytag
Scenario: Login with Valid Data
	Given I navigate to url "https://login.dev.qa-experience.com"
	When I enter username "test@qa.exprience.com"
	And I enter password "Password1"
	And I click on login
	Then Successful login message should display "Successfully logged in!"

	@mytag
Scenario: Login with Invalid Username
	Given I navigate to url "https://login.dev.qa-experience.com"
	When I enter username "mytest@gmail.com"
	And I enter password "Password1"
	And I click on login
	Then The message "Successfully logged in!" Should not display

	@mytag
Scenario: Login with Invalid Password
	Given I navigate to url "https://login.dev.qa-experience.com"
	When I enter username "mytest@gmail.com"
	And I enter password "12345678password"
	And I click on login
	Then The message "Successfully logged in!" Should not display
