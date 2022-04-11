Feature: ContactUs
As a user of ReteGiving.com
I want to contact retegiving
so that I can get information

Rule: Every Exyernal User should be able to Contact Us

@workitem162
Scenario: Valid Contact Us
	Given I navigate to Retegiving.com
	When I click on Contact Us button
	And I click Accept Cookies
	And I enter First Name "Tola" 
	And I enter Last Name "Ola"
	And I enter Email Address "Tola45@outlook.com"
	And I enter Contact Number "07768767469"
	And I enter Subject "Birthday"
	And I enter Your Message "I need my birthday party superb"
	And I click on Send button
	Then the message "our form ha been submitted successfully" is displayed on the page