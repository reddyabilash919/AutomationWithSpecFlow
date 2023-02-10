 ### Functional Case Study (Ted Cinemas)

## Assumptions 

* The program is a web application-based service

* Registration form contains mandatory fields such as email, password, username, phone number, terms and conditions

* Program of **Ted Lovers** and **Super Tuesdays** applies only to registered users

* 10 minutes is allocated to select seats and make payment successful

* User can select either **Ted Lovers** or **Super Tuesdays**, cannot use both programs together

* If it is a Tuesday then the **Ted Lovers** program doesn't apply.

* **Ted Lovers** is a promo program with code **TedCard**

## 1. Login Page

* Validate successful login for valid username and password
* Verify forgot password UI is displayed when "Forgot Password" is selected
* Validate valid error message is displayed for invalid login 
* Verify placeholder for username and password field are displayed
* Verify Create account button is displayed for users to register a new account
* Verify Password field data is hidden in form of an asterisk (*)
* Verify user can login with a new valid password
* Verify proceed as the guest option is allowed for the user to navigate to the movie info page without login
* Verify unsuccessful login for a valid username and invalid password
* Verify unsuccessful login for invalid username and invalid password
* Verify unsuccessful login for invalid username and valid password
* Verify unsuccessful login for a blank username and a blank password
* Verify the time taking to load the movie info page after successful login with a valid username and password
* Verify the login page compatibility for different browsers
* Verify multiple logins at the same time from different browsers 
* Verify login functionality timeout session
* Verify the response time of login page for different load conditions 
* Verify the compatibility of the login page for different browsers


## 2. Registration Page

* Verify error message is displayed for each mandatory field 
* Verify user cannot register without filling all the mandatory fields 
* Verify successful registration after filling all the fields
* Validate successful registration message is displayed and navigated to login page
* Verify user cannot enter numbers or special symbols in the username field 
* Verify register button is displayed and enabled
* Verify user cannot register new account with an already existing email 
* Verify error message is displayed when password and confirm password fields don't match
* Verify error message is displayed when clicking on submit button without selecting **terms and conditions** checkbox
* Verify email field displays valid error message for invalid email address format
* Verify the time taking to load login page after a successful registration
* Verify phone number field doesn't accept alphabets and special symbols 
* Verify the response time of registration page under different load conditions 
* Verify the compatibility of the registration page for different browsers

## 3. Movie Info Page 

* Verify successful display of movie info page for guest user
* Verify successful display of movie info page for registered login user
* Verify the successful display of "Ted Cinemas" logo and text
* Verify successful display of movie info for valid search 
* Verify successful display of movie title, info, image, category, duration
* Verify successful display of "Date & show selection" UI when clicking on any movie title
* Verify "Date & show selection" UI successfully display movie title and image
* Verify "About" section is displayed in "Date & show selction" UI
* Verify "About" section will display about movie info
* Verify "Date & show selection" UI successfully display watch movie trailer option
* Verify user can filter by dates in "Date & show selection" UI
* Verify user can filter by Shows in "Date & show selection" UI
* Verify "Date & show selection" UI displays movie available dates
* Verify "Date & show selection" UI displays show time for selected Dates
* Verify "Seat Selection" UI displayed when clicked on any available showtime
* Verify valid error message is displayed for the blank date filter field and valid show time
* Verify "Seat Selection" UI is not displayed when clicked on non-available/ booked show time
* Verify "No shows" valid message is displayed for non-availability of selected date and show time
* Verify show time filter is disabled for the invalid date filter
* Verify Date & show selection" UI displays current date show times for selected movie
* Verify all four shows times are displayed for the date successful
* Verify the response time of Movie Info page for guest users under different load conditions 
* Verify the response time of Movie Info page for registered users under different load conditions 
* Verify the compatibility of the Movie Info page for different browsers

## 4. Seat Selection Page

* Verify "Select your seat" message is displayed when navigated to "Seat Selection screen"
* Verify successful display of seating arrangement for screen is displayed for a user
* Verify available seats are enabled and displayed in green color 
* Verify booked seats are disabled and displayed in red color 
* Verify user can select on seat and proceed to payment 
* Verify Proceed to payment button is disabled if no seats are selected 
* Verify timer for 10 minutes is running for the selection of seat and payment 
* Verify user can select a maximum of 10 seats at once
* Verify successful user session timeout for exceeding 10 minutes
* Verify user is navigated to "Payment page" when clicked on proceed to payment
* Verify selected seats are blocked until the session timeout
* Verify the response time of Seat Selection page for guest users under different load conditions 
* Verify the response time of Seat Selection page for registered users under different load conditions 
* Verify the compatibility of the Seat Selection page for different browsers

## 5. Payment Page

* Verify movie details are displayed successfully
* Verify Date and time of the show are displayed successfully
* Verify total tickets purchases should be displayed in the payment page
* Verify the total cost of tickets should be displayed 
* Verify login user name, email and phone number is displayed 
* Verify user details form is displayed for guest without login 
* Verify user details form should have username, email, phonenumber mandatory fields
* Verify payment fields are displayed
* Verify payment fields should contain mandatory fields Card Type, Card Number, Name, Expiry and CVV 
* Verify Card Type should have a drop-down of various valid card provider's names
* Verify Card Number should accept only numbers 
* Verify Card Number field will accept only 12 digits min and max
* Verify Card CVV field accept only numbers
* Verify the user is navigated to Confirmation page after when clicked on **Pay now**
* Verify Terms and conditions field is selected for successful payment
* Verify **Pay now** button is disabled until all payment fields are filled 
* Verify promotions field is displayed 
* Verify **Ted Lovers** and **Super Tuesdays** promo should be available for registered users on Tuesdays
* Verify that **Ted Lovers** promo code **TedCard** is displayed successfully
* Verify **Ted Lovers** promo code is applied  successfully for registered users
* Verify **Ted Lovers** promo code is disabled on Tuesdays for all users
* Verify ticket prices are reduced to 50% when the regsitered user selects **Super TuesDays** promo code on Tuesdays
* Verify error message is displayed for guest user when selects **Super TuesDays** promo code
*  Verify error message is displayed for registered users when selecting **Super TuesDays** promo code for other days except for Tuesday
* Verify error message is displayed for the regsitered user when both promo codes are selected
* Verify 10 % discount on total purchase applied successfully when **Ted Lovers** promo is selected for registered users
* Verify 5th movie ticket is free of cost when **Ted Lovers** promo is selected for registered users
* Verify error message is displayed successfully for guest users when entering **Ted Lovers** promo code
* Verify the response time of Payment page for guest users under different load conditions 
* Verify the response time of Payment page for registered users under different load conditions 
* Verify the compatibility of the Payment page for different browsers


## 6. Confirmation and Print Ticket Page

* Verify user details are displayed successfully
* Verify total tickets purchased are displayed successfully
* Verify total cost of tickets are displayed successfully
* Verify total discount applied are displayed successfully for registered users
* Verify movie information is displayed successfully
* Verify show date and time are displayed successfully
* Verify **Ted Lovers** promo code is applied successfully for registered users
* Verify ticket prices are reduced to 50% on Tuesday successfully for registered users
* Verify payment successful message is displayed for all users
* Verify tickets can be printed in pdf format when clicked on print tickets button
* Verify the response time of Confirmation page for guest users under different load conditions 
* Verify the response time of Confirmation page for registered users under different load conditions 
* Verify the compatibility of the Confirmation page for different browsers

## Send SMS 

* Verify successful ticket confirmation details message is sent to guest user
* Verify successful ticket confirmation details message is sent to registered user 
* Verify response time for sending ticket confirmation details message to guest user under different load conditions
* Verify response time for sending ticket confirmation details message to registered under different load conditions


## We had a third-party payment service agreement with CBA but unfortunately they don't have a testing env for us to integrate with. What will be your approach to test it.

# We can achieve this through **Service Virtualisation** 

* First we will be identifying the requirements
* We will create virtual service that can simulate behavior of CBA payment system. 
* We will integrate the virtual service into our testing environment
* We will test integration with the virtual payment service 


