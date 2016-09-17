using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperRockScissorLizardSpockGame
{
    class Game
    {
        public string[] myListOfGameMoves;
        Player player1;
        Player player2;
        public Game()
        {
            myListOfGameMoves = new string[] { "rock", "paper", "scissors", "lizard", "spock" };
        }
        public void StartGame(){         
            int numberOfPlayers = Menu.GameMenu();
            CreatePlayers(numberOfPlayers);
            player1.SetMove(myListOfGameMoves);
            player2.SetMove(myListOfGameMoves);
            DisplayResult();
            ChooseToPlayAgain();
        }
        public void CreatePlayers(int numberOfPlayers) {
            player1 = new HumanPlayer("Player 1");

            if (numberOfPlayers == 1)
            {
                player2 = new ComputerPlayer("Player 2");
            }
            else
            {
                player2 = new HumanPlayer("Player 2");               
            }
        }
        public bool DetermineWinner(string player1, string player2){
            if (player1 == "rock" && (player2 == "lizard" || player2 == "scissors")) return true;
            else if (player1 == "paper" && (player2 == "rock" || player2 == "spock")) return true;
            else if (player1 == "scissors" && (player2 == "paper" || player2 == "lizard")) return true;
            else if (player1 == "spock" && (player2 == "scissors" || player2 == "rock")) return true;
            else if (player1 == "lizard" && (player2 == "paper" || player2 == "spock")) return true;
            else return false;
        }
        public void ChooseToPlayAgain(){
            Console.Write("Would you like to play again? y/n ");
            if (Console.ReadLine().ToLower() == "y"){
                Console.WriteLine("\n");
                this.StartGame();
            }
        }
        public void DisplayResult() {
            Console.WriteLine("{0} chooses {1} {2} chooses {3} ", player1.GetName(), player1.GetMove(), player2.GetName(), player2.GetMove());
            if (player1.GetMove() == player2.GetMove()) Console.WriteLine("It's a Tie");
            else if (DetermineWinner(player1.GetMove(), player2.GetMove())) Console.WriteLine("Player 1 Wins");
            else Console.WriteLine("Player 2 Wins");
        }
    }//End of Class
}
