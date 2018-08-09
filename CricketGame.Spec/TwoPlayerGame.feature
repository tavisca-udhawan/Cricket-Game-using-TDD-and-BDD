Feature: NewPlayer
	In order to play a cricket game
	As a Player
	I want to score runs to win

@mytag
Scenario: player one score is zero when game starts
	Given Player one has started a game of cricket
	When Player one has started a game of cricket
   Then the player one score should be 0

   Scenario: Player one score runs
	Given Player one has started a game of cricket
	When Player one scores 4 runs
	Then the player one score should be 4

	Scenario: Player one score more runs
	Given Player one has started a game of cricket
	When Player one scores 6 runs
	Then the player one new score should be 6

	Scenario: Player one out
	Given Player one has started a game of cricket
	When Player one gets out
	Then the player one score should be 0


	Scenario: player two score is zero when game starts
	Given Player two has started a game of cricket
	When Player two has started a game of cricket
   Then the Player two score should be 0

   Scenario: Player two score runs
	Given Player two has started a game of cricket
	When Player two scores 4 runs
	Then the Player two score should be 4

	Scenario: Player two score more runs
	Given Player two has started a game of cricket
	When Player two scores 2 runs
	Then the Player two new score should be 2

	Scenario: Player two may score more runs
	Given Player two has started a game of cricket
	When Player two scores 4 runs 
	Then the Player two new score should be 4

	Scenario: Player two out
	Given Player two has started a game of cricket
	When Player two gets out
	Then the Player two score should be 0

	Scenario: Both Players get out
	Given Player one has started a game of cricket
	And Player one scores 6 runs
	And Player one gets out
	And Player two has started a game of cricket
	And Player two scores 4 runs
	And Player two gets out
	When Both are out
	Then Winner is Player one

	Scenario: Both Players have equal runs
	Given Player one has started a game of cricket
	And Player one scores 2 runs
	And Player one scores 3 runs
	And Player one scores 2 runs
	And Player one gets out
	And Player two has started a game of cricket
	And Player two scores 1 runs
	And Player two scores 6 runs
    And Player two gets out
	When Both are out
	Then There should be a tie between them