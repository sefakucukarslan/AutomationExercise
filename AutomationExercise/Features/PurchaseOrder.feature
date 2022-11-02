Feature: PurchaseOrder

Order Page Detail
@tag1
Scenario: Download Invoice after purchase order
* Launch browser
* Navigate to url 'http://automationexercise.com'
* Verify that home page is visible successfully
* Add products to cart
* Click ' Cart' button
* Verify that cart page is displayed
* Click Proceed To Checkout
* Click Register / Login button
* Fill all details in Signup and create account
* Verify that 'Account Created!' is visible
* Click 'Continue' button
* Verify that Logged in as username is visible
* Click ' Cart' button
* Click Proceed To Checkout
* Verify 'Address Details'
* Verify 'Review Your Order'
* Enter description in comment text area
* Click 'Place Order' button
* Enter payment details: Name on Card, Card Number, CVC, Expiration date
* Click 'Pay and Confirm Order' button
* Verify 'Your order has been placed successfully!'
* Click 'Download Invoice' button
* Verify 'invoice is downloaded successfully'
* Click 'Continue' button
* Click 'Delete Account' button
* Verify 'ACCOUNT DELETED!'
* Click 'Continue' button