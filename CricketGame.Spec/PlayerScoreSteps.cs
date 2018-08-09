using System;
using TechTalk.SpecFlow;

namespace CricketGame.Spec.............Documents.Projects.CricketGame
{
    [Binding]
    public class PlayerScoreSteps
    {
        [When(@"Player has started a game of a cricket")]
        public void WhenPlayerHasStartedAGameOfACricket()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the player score should be (.*)")]
        public void ThenThePlayerScoreShouldBe(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
