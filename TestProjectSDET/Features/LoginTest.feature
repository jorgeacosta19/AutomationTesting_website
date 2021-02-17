@web @demo
Feature: LoginTest
	
Background: 
	Given the Login page of SWAGLABS
	And an username
	And a password

Scenario: Log in into the System
	
	When valids username and password are typed in their fields
		| Username        | Password     |
		| locked_out_user | secret_sauce |
	Then the user can not log in into the system
	And the user get an error message
	 