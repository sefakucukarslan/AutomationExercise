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
Scenario: Test Case 1_Register User
```
* Click on Signup Login button

* Verify New User Signup is visible

* Enter name and email address

* Click Signup button

* Verify that 'ENTER ACCOUNT INFORMATION' is visible

* Fill details: Title, Name, Email, Password, Date of birth

* Click Create Button

* Verify that "ACCOUNT CREATED!" message

* Click Continue button

* Verify that "Logged in as" text

* Click Delete Account button

* Verify that "ACCOUNT DELETED" is visible and click Continue button
```
Scenario: Test Case 2_Login User with correct email and password

