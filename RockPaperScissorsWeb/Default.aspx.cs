using System;
using System.Web;
using System.Web.UI;

namespace RockPaperScissorsWeb
{

	public partial class Default : System.Web.UI.Page
	{
		public void play (object sender, EventArgs args)
		{
			Random rand = new Random ();
			int computer = rand.Next (0, 3);
			var playerChoice = "";
			var computerChoice = "";

			paragraph.Text = "Computer chose ";
			if (computer == 0) {
				computerChoice = "Rock";
			}
			if (computer == 1) {
				computerChoice = "Paper";
			}
			if (computer == 2) {
				computerChoice = "Scissors";
			}

			computerChoiceLabel.Text = computerChoice;


			if (rockButton.Checked == true) {
				playerChoice = "Rock";
			}
			else if (paperButton.Checked == true) {
				playerChoice = "Paper";
			}
			else if (scissorsButton.Checked == true) {
				playerChoice = "Scissors";
			}



			var game = new Game ();

			gameOutcome.Text = game.PlayTurn (playerChoice, computerChoice);
		}
	}
}