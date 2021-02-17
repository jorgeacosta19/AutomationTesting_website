@web @demo
Feature: Purchase Test
	

Background: 
	Given the Login page of SWAGLABS
	And an username
	And a password

Scenario: Complete successfully a purchase
	
	When valids username and password are typed in their fields
		| Username      | Password     |
		| standard_user | secret_sauce |
	Then the user could log in and get to the Inventory Page
	When The user click on every ADD TO CART button once 
	Then the six items are added to the cart
	When The user click on the cart icon
	Then we can see the list of item within the cart
	When we press click on the checkout button
	Then we fill the personal information form
		| First Name   | Last Name | Zip/ PostalCode |
		| MyName	   | MySurname | SLM911          |	
	And we press click on the continue button
	Then we can see the overview of the item tu purchase
	When you press click on the button finish
	Then The purchase is completed
	And we can see a message that our order is ready to be dispatched



	


	
