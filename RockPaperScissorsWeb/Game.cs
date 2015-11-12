using System;

namespace rockpaperscissorsconsole
{
	public class Game
	{
		public string PlayTurn(string Player1, string Player2)
		{
			if (Player1 == Player2) {
				return "It's a tie";
			}
			else if (Player1 == "rock" && Player2 == "scissors") {
				return "Player 1 wins";
			}
			else if (Player1 == "paper" && Player2 == "rock") {
				return "Player 1 wins";
			}
			else if (Player1 == "scissors" && Player2 == "paper") {
				return "Player 1 wins";
			}
			else {
				return "Player 2 wins";
			}
		}
	}
}
