@web @demo
Feature: Images Display Test
	

Background: 
	Given the Login page of SWAGLABS
	And an username
	And a password

Scenario: Correctly display of the product images
	
	When valids username and password are typed in their fields
		| Username      | Password     |
		| problem_user  | secret_sauce |
	Then the user could log in and get to the Inventory Page
	But the website does not display the image of the products.