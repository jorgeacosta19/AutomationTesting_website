@web @demo
Feature: Fill the personal details and proceed to the checkout
	

Background: 
	Given the Login page of SWAGLABS
	And an username
	And a password

Scenario: Complete successfully a purchase
	
	When valids username and password are typed in their fields
		| Username      | Password     |
		| standard_user | secret_sauce |
	Then the user could log in and get to the Inventory Page
	When The user click  on five items ADD TO CART 
	Then the five items are added to the cart succesfully
	When The user click on the cart icon
	Then we can see the list of item within the cart
	When we press click on the checkout button
	Then we fill the personal information form
		| First Name   | Last Name | Zip/ PostalCode |
		| Jorge	       | Acosta    | SLM911          |	
	And we press click on the continue button
	Then we can see the overview of the item tu purchase