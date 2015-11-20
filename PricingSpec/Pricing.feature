Feature: Product Price
	In order to avoid silly mistakes
	As a user
	I want to make sure the correct price for a product is displayed 

Scenario: Display Suit Price
	Given I have selected "Black Short Jacket"
	When I request the Product Price
	Then The returned price should be 120

Scenario: Display Waistcoat Price
	Given I have selected "Black Waistcoat"
	When I request the Product Price
	Then The returned price should be 40

Scenario: Display Neckwear Price
	Given I have selected "Black Tie"
	When I request the Product Price
	Then The returned price should be 20

Scenario: Display Accessories Price
	Given I have selected "Black Matte Shoes"
	When I request the Product Price
	Then The returned price should be 20

Scenario: Display Outfit Price
	Given I have selected "Black Short Jacket" 
	And I have selected "Black Waistcoat" 
	And I have selected "Black Tie"
	And I have selected "Black Matte Shoes"
	When I request the Total Price
	Then The returned price should be 200