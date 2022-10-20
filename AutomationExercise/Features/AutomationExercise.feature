Feature: AutomationExercise

Test about AutomationExercise web site

Background: 
* Launch browser
* Navigate to url 'http://automationexercise.com'

@tag1
Scenario: Register User
* Verify that home page is visible successfully
* Click on 'Signup / Login' button
* Verify 'New User Signup!' is visible
* Enter name and email address
* Click 'Signup' button
* Verify that 'ENTER ACCOUNT INFORMATION' is visible
* Fill details: Title, Name, Email, Password, Date of birth
* Select checkbox 'Sign up for our newsletter!'
* Select checkbox 'Receive special offers from our partners!'
* Fill details: First name, Last name, Company, Address, Address2, Country, State, City, Zipcode, Mobile Number
* Click 'Create Account button'
* Verifyy that 'ACCOUNT CREATED!' is visible
* Click 'Continue' button
* Verify that Logged in as username is visible
* Click 'Delete Account' button
* Verify that 'ACCOUNT DELETED!' is visible and click 'Continue' button

@tag2
Scenario: Login User with correct email and password
* Verify that home page is visible successfully
* Click on 'Signup / Login' button
* Verifyy 'Login to your account' is visible
* Enter correct email address and password
* Click 'login' button
* Verify that Logged in as username is visible
* Click 'Delete Account' button
* Verifyyy that 'ACCOUNT DELETED!' is visible