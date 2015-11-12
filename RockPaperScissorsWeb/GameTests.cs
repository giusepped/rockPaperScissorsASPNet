using NUnit.Framework;
using System;

namespace RockPaperScissorsWeb
{
	[TestFixture ()]
	public class GameTest
	{
		private Game testGame;

		[SetUp]
		public void Init ()
		{
			testGame = new Game (); 
		}

		[Test]
		public void PlayerWinsRockCrushesScissors ()
		{	
			var expected = "You win!";
			var actual = testGame.PlayTurn ("Rock", "Scissors");

			CollectionAssert.AreEqual (expected, actual);
		}

		[Test]
		public void PlayerWinsPaperCoversRock ()
		{
			var expected = "You win!";
			var actual = testGame.PlayTurn ("Paper", "Rock");

			CollectionAssert.AreEqual (expected, actual);
		}

		[Test]
		public void PlayerWinsScissorsCutPaper ()
		{
			var expected = "You win!";
			var actual = testGame.PlayTurn ("Scissors", "Paper");

			CollectionAssert.AreEqual (expected, actual);
		}

		[Test]
		public void RockTie ()
		{
			var expected = "It's a tie!";
			var actual = testGame.PlayTurn ("Rock", "Rock");

			CollectionAssert.AreEqual (expected, actual);
		}

		[Test]
		public void PaperTie ()
		{
			var expected = "It's a tie!";
			var actual = testGame.PlayTurn ("Paper", "Paper");

			CollectionAssert.AreEqual (expected, actual);
		}

		[Test]
		public void ScissorsTie ()
		{
			var expected = "It's a tie!";
			var actual = testGame.PlayTurn ("Scissors", "Scissors");

			CollectionAssert.AreEqual (expected, actual);
		}

		[Test]
		public void ComputerWinsRockCrushesScissors ()
		{	
			var expected = "Computer wins! You lose!";
			var actual = testGame.PlayTurn ("Scissors", "Rock");

			CollectionAssert.AreEqual (expected, actual);
		}

		[Test]
		public void ComputerWinsRockPaperCoversRock ()
		{	
			var expected = "Computer wins! You lose!";
			var actual = testGame.PlayTurn ("Rock", "Paper");

			CollectionAssert.AreEqual (expected, actual);
		}

		[Test]
		public void ComputerWinsScissorsCutPaper ()
		{	
			var expected = "Computer wins! You lose!";
			var actual = testGame.PlayTurn ("Paper", "Scissors");

			CollectionAssert.AreEqual (expected, actual);
		}

	}
}