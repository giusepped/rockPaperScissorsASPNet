using System;

namespace RockPaperScissorsWeb
{
	public class Game
	{
		public string PlayTurn(string Player, string Computer)
		{
			if (Player == Computer) {
				return "It's a tie!";
			}
			else if (Player == "Rock" && Computer == "Scissors") {
				return "You win!";
			}
			else if (Player == "Paper" && Computer == "Rock") {
				return "You win!";
			}
			else if (Player == "Scissors" && Computer == "Paper") {
				return "You win!";
			}
			else {
				return "Computer wins! You lose!";
			}
		}
	}
}
