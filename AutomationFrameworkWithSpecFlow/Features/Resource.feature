Feature: Resource


@resource_test
Scenario: Validate resource is not found for invalid resource id
	When I send a request with resource's id "26"
	Then the response status code should be "NotFound"
	