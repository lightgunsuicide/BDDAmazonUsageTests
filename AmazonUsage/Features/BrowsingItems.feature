Feature: BrowsingItems

Scenario Outline: Search for a book by title
Given I open amazon in a browser 
When I search for "<book>"
Then I should see results for "<book>" including "<author>" and "<price>"

Examples: 
| book                         | author      | price  |
| Mastering Selenium WebDriver | Mark Collin | £28.99 |

Scenario: Search by department
Given I open amazon in a browser
When I select "Computers & Accessories" from the category drop down
Then I should see the landing page for this category


Scenario: Search for an authors page 
Given I open amazon in a browser
And I search for "William Gibson"
When I open the link to his page
Then some information about "William Gibson"


