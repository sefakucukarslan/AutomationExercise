# AutomationExercise
AutomationExercise Test Cases
https://www.automationexercise.com/test_cases I made 26 Test Cases on the website.

<img width="344" alt="logo" src="https://user-images.githubusercontent.com/100466472/196940302-336c572d-6b41-4d7e-907a-ad4d91400879.png">


## Used technologies
***
- **C#**: The programming language in which the project is written

- **Nunit**: Test Authoring Tool used for writing Test Cases and controlling outputs.

- **Selenium**: Test Automation Tool used to test Website

- **Page Object Model**: It is the architectural structure used in the project.

- **SpecFlow**:(SpecFlow is a test automation approach supported by BDD (Behavior Driven Developmet))

- **Gherkin**: Gherkin is a plain-text language. Designed to be learned by non-programmers

## Case Aşamaları:
***
Test Case 1 :

Scenario: Register User
```
* Click on Signup Login button

* Verify New User Signup is visible

* Enter name and email address

* Click Signup button

* Verify that 'Enter Account Information' is visible

* Fill details: Title, Name, Email, Password, Date of birth

* Click Create Button

* Verify that "Account Created!" message

* Click Continue button

* Verify that "Logged in as" text

* Click Delete Account button

* Verify that "Account Deleted!" is visible and click Continue button
```
Test Case 2 :

Scenario: Login User with correct email and password
```
* Launch browser

* Navigate to url 'http://automationexercise.com'

* Verify that home page is visible successfully

* Click on 'Signup / Login' button

* Verify 'Login to your account' is visible

* Enter correct email address and password

* Click 'login' button

* Verify that 'Logged in as username' is visible

* Click 'Delete Account' button

* Verify that 'Account Deleted!' is visible
```
Test Case 3 :

Scenario: Login User with incorrect email and password
```
* Click on 'Signup / Login' button

* Verify 'Login to your account' is visible

* Enter incorrect email address and password

* Click 'login' button

* Verify error 'Your email or password is incorrect!' is visible
```
Test Case 4 :

Scenario: Contact Us Form
```
* Click on Contact Us button

* Verify 'Get In Touch' is visible

* Enter name, email, subject and message

* Upload file

* Click Submit button

* Click OK button

* Verify success message 'Success! Your details have been submitted successfully.' is visible

* Click Home button

* Verify that home page is visible successfully
```
Test Case 5 :

Scenario: Add Products in Cart
```
* Launch browser

* Navigate to url 'http://automationexercise.com'

* Verify that home page is visible successfully

* Click Products button

* Hover over first product and click Add to cart

* Click 'Continue Shopping' button

* Hover over second product and click Add to cart

* Click View Cart button

* Verify both products are added to Cart

* Verify their prices, quantity and total price
```
