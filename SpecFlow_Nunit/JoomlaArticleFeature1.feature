Feature: JoomlaArticleFeature1
	User can create new article.
	User can edit/delete article.


Scenario: Create new Article
	Given I navigate to the page http://192.168.189.119/abyssal/administrator/index.php
	And I login in the page with username phuong.thi.tran and password 123456
	When I click New Article button
	And I add new article with title alias content Trashed Images
	Then Successful message Article successfully saved. should display.
	And The Article's title <title> should display in Article table.
