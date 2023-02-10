 ### Functional Case Study (Ted Cinemas)

## Assumptions 

* The program is a web application-based service

* Registration form contains mandatory fields such as email, password, username, phone number, terms and conditions

* Program of **Ted Lovers** and **Super Tuesdays** applies only to registered users

* 10 minutes is allocated to select seats and make payment successful

* User can select either **Ted Lovers** or **Super Tuesdays**, cannot use both programs together

* If it is a Tuesday then **Ted Lovers** program doesn't apply.

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


## 2. Registration Page

* Verify error message is displayed for each mandatory fields 
* Verify user cannot register without filling all the mandatory fields 
* Verify successful registration after filling all the fields
* Validate successful registration message is displayed and navigated to login page
* Verify user cannot enter numbers or special symbols in username field 
* Verify register button is displayed and enabled
* Verify user cannot register new account with already existing email 
* Verify error message is displayed when password and confirm password fields doesn't match
* Verify error message is displayed when clicking on submit button without selecting **terms and conditions** checkbox
* Verify email field displays valid error message for invalid email address format
* Verify the time taking to load login page after successful registration
* Verify the registration page compatability for different browsers
* Verify phone number field doesn't accept alphabets and special symbols 


## 3. Movie Info Page 

* Verify successful display of movie info page for guest user
* Verify successful display of movie info page for registered login user
* Verify successful display of "Ted Cinemas" logo and text
* Verify successful display of movie info for valid search 
* Verify successful display of movie title, info, image, category, duration
* Verify successful display of "Date & show selection" UI when clicked on any movie title
* Verify "Date & show selection" UI successful display movie title and image
* Verify "About" section is displayed in "Date & show selction" UI
* Verify "About" section will display about mopvie info
* Verify "Date & show selection" UI succesful display watch movie trail option
* Verify user can filter by dates in "Date & show selection" UI
* Verify user can filter by Shows in "Date & show selection" UI
* Verify "Date & show selection" UI displays movie available dates
* Verify "Date & show selection" UI displays show time for selected Dates
* Verify "Seat Selection" UI displayed when clicked on any available show time
* Verify valid error message is displayed for blank date filter field and valid show time
* Verify "Seat Selection" UI is not displayed when clicked on non-available/ booked show time
* Verify "No shows" valid message is displayed for non availability of selected date and show time
* Verify show time filter is disabled for invalid date filter
* Verify Date & show selection" UI displays current date show times for selected movie
* Verify all four shows times are displayed for the date successful

## 4. Seat Selection Page

* Verify "Select your seat" message is displayed when navigated to "Seat Selection screen"
* Verify successful display of seating arrangement for screen is displayed for user
* Verify available seats are enabled and displayed in green color 
* Verify booked seats are disabled and displayed in red color 
* Verify user can select on seat and proceed to payment 
* Verify Proceed to payment button is disabled if no seats are selected 
* Verify timer for 10 minutes is running for selection of seat and payment 
* Verify user can select maximum of 10 seats at once
* Verify successful user session timeout for exceeeding 10 minutes
* Verify user is navigated to "Payment page" whne clicked on proceed to payment
* Verify selected seats are blocked until session timeout

## 5. Payment Page

* Verify movie details are displayed successfully
* Verify Date and time of the show are displayed succcessfully
* Verify total tickets purchases should be displayed in payment page
* Verify total cost of tickets should be displayed 
* Verify login user name, email and phone number is displayed 
* Verify user details form is displayed for guest without login 
* Verify user details form should have username, email, phonenumber mandatory fields
* Verify payment fields are displayed
* Verify payment fields should contain mandatory fields Card Type, Card Number, Name, Expiry and CVV 
* Verify Card Type should have a drop down of various valid card providers names
* Verify Card Number should accept only numbers 
* Verify Card Number field will accept only 12 digits min and max
* Verify Card CVV field accept only numbers
* Verify user is navigated to Confirmation page after when clicked on **Pay now**
* Verify Terms and conditions field is selected for successful payment
* Verify **Pay now** button is disabled until all payment fields are filled 
* Verify promotions field is displayed 
* Verify **Ted Lovers** and **Super Tuesdays** promo should be avaiable for registered users on Tuesdays
* Verify that **Ted Lovers** promo code **TedCard** is displayed successfully
* Verify **Ted Lovers** promo code is applied  successfully for registered users
* Verify **Ted Lovers** promo code is disabled on Tuesdays for all users
* Verify ticket prices are reduced to 50% when regsitered user selects **Super TuesDays** promo code on Tuesdays
* Verify error message is displayed for guest user when selects **Super TuesDays** promo code
*  Verify error message is displayed for registered users when selects **Super TuesDays** promo code for other days except Tuesday
* Verify error message is displayed for regsitered user when both promo codes are selected
* Verify 10 % discount on total purchase applied successfully when **Ted Lovers** promo is selected for registered users
* Verify 5th movie ticket is free of cost when **Ted Lovers** promo is selected for regsitered users
* Verify error message is displayed successfully for guest users when entered **Ted Lovers** promo code


## 6. Confirmation and Print Ticket Page

* Verify user details are displayed successfully
* Verify total tickets purchased are displayed successfully
* Verify total cost of tickets are displayed successfully
* Verify total discount applied are displayed successfully for registered users
* Verify movie information is displayed successfully
* Verify show date and time are displayed successfully
* Verify **Ted Lovers** promo code is applied successfully for registered users
* Verify ticket prices are reduced to 50% on Tuesday successfully for registered users
* Verify payment successfull message is displayed for all users
* Verify tickets can be printed in pdf format when clicked on print tickets button

## Send SMS 

* Verify successful ticket confirmation details message is sent to guest user
* Verify successful ticket confirmation details message is sent to registered user 


## We had a third party payment service agreement with CBA but unfortunatley they don't have a testing env for us to integrate with. What will be your approach to test it.

# We can achieve this through **Service Virtualisation** 

* First we will identifying the requirements
* We will create virtual service that can simulate behavior of CBA payment system. 
* We will integrate the virtual service into our testing environment
* We will test integration with virtual payment service 


