# AutomationExercise
AutomationExercise Test Cases
https://www.automationexercise.com/test_cases I made 26 Test Cases on the website.

<img width="344" alt="logo" src="https://user-images.githubusercontent.com/100466472/196940302-336c572d-6b41-4d7e-907a-ad4d91400879.png">


Used technologies
C#: The programming language in which the project is written

Nunit: Test Authoring Tool used for writing Test Cases and controlling outputs.

Selenium: Test Automation Tool used to test Website

Page Object Model: It is the architectural structure used in the project.

SpecFlow:(SpecFlow is a test automation approach supported by BDD (Behavior Driven Developmet))

Gherkin: Gherkin is a plain-text language. Designed to be learned by non-programmers

Case Aşamaları
Scenario: Test Case 1_Register User

And Click on Signup Login button
Then Verify New User Signup is visible
And Enter name and email address
And Click Signup button
Then Verify that 'ENTER ACCOUNT INFORMATION' is visible
And Fill details: Title, Name, Email, Password, Date of birth
And Click Create Button
Then Verify that "ACCOUNT CREATED!" message
And Click Continue button
Then Verify that "Logged in as" text
And Click Delete Account button
Then Verify that "ACCOUNT DELETED" is visible and click Continue button
Scenario: Test Case 2_Login User with correct email and password
