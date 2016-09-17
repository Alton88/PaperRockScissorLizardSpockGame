using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperRockScissorLizardSpockGame
{
    class HumanPlayer : Player{
        public HumanPlayer(string name) : base(name) {
            this.name = name;           
        }
        public override void SetMove(string[] listOfMoves) {
            this.move = GetWordFromPlayer(listOfMoves);
        }
        public override string GetMove() {
            return this.move;
        }
        public override string GetName() {
            return this.name;
        }
        public bool WordChecker(string[] listOfMoves, string playerInput)
        {
            foreach (string gameMove in listOfMoves)
                if (playerInput == gameMove)
                {
                    return true;
                }
            return false;
        }
        public string GetCorrectWord(string[] listOfMoves)
        {
            string gameMove;
            do
            {
                Console.Write("You have typed in an invalid entry, try again! ");
            } while (!WordChecker(listOfMoves, gameMove = Console.ReadLine().ToLower()));
            return gameMove;
        }
        public string GetWordFromPlayer(string[] listOfMoves)
        {
            Console.Write("{0} please enter Paper Rock Scissors Lizard or Spock ", this.name);
            string gameMove = Console.ReadLine().ToLower();

            if (!WordChecker(listOfMoves, gameMove))
            {
                return GetCorrectWord(listOfMoves);
            }
            else
            {
                return gameMove;
            }
        }
    }//End of class
}
