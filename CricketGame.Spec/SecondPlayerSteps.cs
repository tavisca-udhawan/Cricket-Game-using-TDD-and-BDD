using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CricketGame.Spec
{
    [Binding]
    public class SecondPlayerSteps
    {
        private Cricket _player1;
        private Cricket _player2;
        
        [Given(@"Player one has started a game of cricket")]
        [When(@"Player one has started a game of cricket")]
        public void WhenPlayerOneHasStartedAGameOfCricket()
        {
            _player1 = new Cricket();
        }
        [Then(@"the player one score should be (.*)")]
        public void ThenThePlayerOneScoreShouldBe(int score)
        {
            _player1.PlayerScore.Should().Be(score);
        }
        [When(@"Player one scores (.*) runs")]
        [Given(@"Player one scores (.*) runs")]
        public void GivenPlayerOneScoresRuns(int score)
        {
            _player1.Score(score);
        }
        
        [Then(@"the player one new score should be (.*)")]
        public void ThenThePlayerOneNewScoreShouldBe(int score)
        {
            _player1.PlayerScore.Should().Be(score);
        }
        [Given(@"Player one gets out")]
        [When(@"Player one gets out")]
        public void WhenPlayerOneGetsOut()
        {
            _player1.active = false;
        }
        [Then(@"the player one score is (.*)")]
        public void ThenThePlayerOneScoreIs(int score)
        {
            _player1.Score(score);
        }
        [When(@"Player two has started a game of cricket")]
        [Given(@"Player two has started a game of cricket")]
        public void GivenPlayerTwoHasStartedAGameOfCricket()
        {
            _player2 = new Cricket();
        }
        [Then(@"the Player two score should be (.*)")]
        public void ThenThePlayerTwoScoreShouldBe(int score)
        {
            _player2.PlayerScore.Should().Be(score);
        }
        [Given(@"Player two scores (.*) runs")]
        [When(@"Player two scores (.*) runs")]
        public void WhenPlayerTwoScoresRuns(int score)
        {
            _player2.Score(score);
        }
        [Then(@"the Player two new score should be (.*)")]
        public void ThenThePlayerTwoNewScoreShouldBe(int score)
        {
            _player2.PlayerScore.Should().Be(score);
        }
        [Given(@"Player two gets out")]
        [When(@"Player two gets out")]
        public void WhenPlayerTwoGetsOut()
        {
            _player2.active = false;
        }
        [Then(@"the player two score should (.*)")]
        public void ThenThePlayerTwoScoreShould(int score)
        {
            _player2.Score(score);
        }
        [When(@"Both are out")]
        public void WhenBothAreOut()
        {
          _player1.active.Should().Be(false);
            _player2.active.Should().Be(false);
        }

        [Then(@"Winner is Player one")]
        public void ThenWinnerIsPlayerOne()
        {
            _player1.PlayerScore.Should().BeGreaterThan(_player2.PlayerScore);
        }

        [Then(@"There should be a tie between them")]
        public void ThenThereShouldBeATieBetweenThem()
        {
            _player1.PlayerScore.Should().Be(_player2.PlayerScore);
        }

    }
}
