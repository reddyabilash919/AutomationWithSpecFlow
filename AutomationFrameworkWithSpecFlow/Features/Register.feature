Feature: Register a new user 


@register_test
Scenario: Verify successful register of new user
	When I register as a user
	| Field    | Value              |
	| Email    | eve.holt@reqres.in |
	| Password | pistol             |
	Then the response status code should be "OK"
	And Id should be generated successfully
	And token should be generated successfully


@register_test
Scenario: Verify unsucessful register of new user
	When I register as a user
	| Field    | Value              |
	| Email    | eve.holt@reqres.in |
	Then the response status code should be "BadRequest"
	And "Missing password" error message should be displayed
	