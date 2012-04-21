Feature: XMasTree
	Write a program that draw a christmas tree

# More about how to write scenario: https://github.com/cucumber/cucumber/wiki/multiline-step-arguments
# For Scenario alone
Scenario: Not Accepted Tree
	Given I have entered 2 into XMas Tree Software
	When I press Draw
	Then the result should be "The tree should have a size at least of 3"

Scenario: Tree of 3 lines
	Given I have entered 3 into XMas Tree Software
	When I press Draw
	Then the result on the screen should be :
	"""
	  *
	 * *
	* * *
	 |_|
	"""

Scenario: Tree of 4 lines
	Given I have entered 4 into XMas Tree Software
	When I press Draw
	Then the result on the screen should be :
	"""
	   *
	  * *
	 * * *
	* * * *
	  |_|
	"""
Scenario: Tree of 5 lines
	Given I have entered 5 into XMas Tree Software
	When I press Draw
	Then the result on the screen should be :
	"""
	   *
	  * *
	 * * *
	* * * *
	 * * *
	  |_|
	"""
Scenario: Tree of 6 lines
	Given I have entered 6 into XMas Tree Software
	When I press Draw
	Then the result on the screen should be :
	"""
	   *
	  * *
	 * * *
	* * * *
	 * * *
	* * * *
	  |_|
	"""
Scenario: Tree of 8 lines
	Given I have entered 8 into XMas Tree Software
	When I press Draw
	Then the result on the screen should be :
	"""
	     *
	    * *
	   * * *
	  * * * *
	   * * *
	  * * * *
	 * * * * *
	* * * * * *
	    |__|
	"""



