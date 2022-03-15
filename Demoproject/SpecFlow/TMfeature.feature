Feature: TMfeature

A short summary of the feature

As a turnup portal admin
I would like to create, edit and delete Time and  Material record
so that I can manage Time and Materials successfully


Scenario: create time and material record with valid data
	Given I logged into the Turnup portal successfully
	And I navigate to time and material page
	When I create time and material record
	Then the record should be created successfully

Scenario Outline: edit time and material record with valid data
	Given I logged into the Turnup portal successfully
	And I navigate to time and material page
	When I update '<Description>','<code>','<price>' on existing Time and material record
	Then the record should have the updated '<Description>','<code>','<price>'

	Examples: 
	| Description | code   | price |
	| Demo        | asd    | 45    |
	| Sam         | change | 33    |
	| code        | Page   | 99    |




