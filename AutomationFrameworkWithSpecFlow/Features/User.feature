Feature: Users

@users_test
Scenario: Verify new user is created successfully
	When I create a new user with following information
	| Field | Value    |
	| Name  | morpheus |
	| Job   | leader   |
	Then the response status code should be "Created"
	And new user information should be displayed successfully
	


@users_test
Scenario: Verify that user is deleted successfully
	When I delete user with id "2"
	Then the response status code should be "NoContent"


@users_test
Scenario: Validate successful display of existing users
    Given I am in user's page number "2"
	When I send request to get list of existing users
	Then the response status code should be "OK"
	And The overall total number of existing users should be "12"
	And the existing users list should contain following user information
	| Field     | Value    |
	| FirstName | Lindsay  |
	| LastName  | Ferguson |
	


@users_test
Scenario: Validate user information is displayed successfully for valid user's id
	When I send a request with user's id "2"
	Then the response status code should be "OK"
	And existing user information should be displayed
	| Field     | Value                                   |
	| Id        | 2                                       |
	| Email     | janet.weaver@reqres.in                  |
	| FirstName | Janet                                   |
	| LastName  | Weaver                                  |
	| Avatar    | https://reqres.in/img/faces/2-image.jpg |


@users_test
Scenario: Validate user information is not displayed for invalid user's id
	When I send a request with user's id "26"
	Then the response status code should be "NotFound"
	
