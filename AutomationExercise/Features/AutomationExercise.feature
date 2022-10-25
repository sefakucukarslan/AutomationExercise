Feature: AutomationExercise

Test about AutomationExercise web site

Background: 
* Launch browser
* Navigate to url 'http://automationexercise.com'
* Verify that home page is visible successfully

@tag1
Scenario: Register User
* Click on 'Signup / Login' button
* Verify 'New User Signup!' is visible
* Enter name and email address
* Click 'Signup' button
* Verify that 'Enter Account Information' is visible
* Fill details: Title, Name, Email, Password, Date of birth
* Select checkbox 'Sign up for our newsletter!'
* Select checkbox 'Receive special offers from our partners!'
* Fill details: First name, Last name, Company, Address, Address2, Country, State, City, Zipcode, Mobile Number
* Click 'Create Account button'
* Verify that 'Account Created!' is visible
* Click 'Continue' button
* Verify that Logged in as username is visible
* Click 'Delete Account' button
* Verify that 'Account Deleted!' is visible
* Click 'Continue' button

@tag2
Scenario: Login User with correct email and password
* Click on 'Signup / Login' button
* Verify 'Login to your account' is visible
* Enter correct email address and password
* Click 'login' button
* Verify that Logged in as username is visible
* Click 'Delete Account' button
* Verify that 'Account Deleted!' is visible

@tag3
Scenario: Login User with incorrect email and password
* Click on 'Signup / Login' button
* Verify 'Login to your account' is visible
* Enter incorrect email address and password
* Click 'login' button
* Verify error 'Your email or password is incorrect!' is visible