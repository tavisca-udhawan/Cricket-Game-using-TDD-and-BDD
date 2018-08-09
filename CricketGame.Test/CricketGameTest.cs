using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CricketGame.Test
{
    [TestClass]
    public class CricketGameTest
    {
        [TestMethod]
        public void PlayerScore_NewGame_ShouldbeZero()
        {
            var game = new Cricket();
            Assert.IsTrue(game.PlayerScore==0);
        }
        [TestMethod]
        public void Score_ValidRuns_ShouldUpdatePlayerScore()
        {
            var game = new Cricket();
            game.Score(4);
            Assert.IsTrue(game.PlayerScore ==4);
        }
        [TestMethod]
        public void Score_InValidRuns_ShouldUpdatePlayerScore()
        {
            var game = new Cricket();
            game.Score(7);
            Assert.IsTrue(game.PlayerScore == 0);
        }
        [TestMethod]
        public void Both_Players_having_Tie_In_Match()
        {
            var player1 = new Cricket();
           var player2 = new Cricket();
            player1.Score(2);
            player1.Score(3);
            player1.Score(2);
            player2.Score(1);
            player2.Score(6);
            Assert.AreEqual(player1.PlayerScore,player2.PlayerScore);

        }
        [TestMethod]
        public void Player1_Is_Winner()
        {
            var player1 = new Cricket();
            var player2 = new Cricket();
            player1.Score(4);
            player1.Score(6);
           
            player2.Score(1);
            player2.Score(6);
            Assert.IsTrue(player1.PlayerScore>player2.PlayerScore);
        }
        [TestMethod]
        public void Player2_Is_Winner()
        {
            var player1 = new Cricket();
            var player2 = new Cricket();
            player1.Score(4);
           
             player2.Score(1);
            player2.Score(6);
            Assert.IsTrue(player1.PlayerScore < player2.PlayerScore);

        }
    }
}
