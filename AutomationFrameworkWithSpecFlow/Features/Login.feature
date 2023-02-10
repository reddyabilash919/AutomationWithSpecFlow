Feature: Login


@login_test
Scenario: Verify successful login with valid email and password
	When I login with user credentials
	| Field    | Value              |
	| Email    | eve.holt@reqres.in |
	| Password | pistol             |
	Then the response status code should be "OK"
	And token should be generated successfully
