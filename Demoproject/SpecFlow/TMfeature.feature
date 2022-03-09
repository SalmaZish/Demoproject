Feature: TMfeature

A short summary of the feature

As a turnup portal admin
I would like to create, edit and delete Time and  Material record
so that I can manage Time and Materials successfully


Scenario: create time and material record with valid date
	Given I logged into the Turnup portal successfully
	And I navigate to time and material page
	When I create time and material record
	Then the record should be created successfully
