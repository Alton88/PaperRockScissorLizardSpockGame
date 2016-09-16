using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperRockScissorLizardSpockGame
{
    class ComputerPlayer : Player{
        Random randomizer = new Random();
        public ComputerPlayer(string name) : base(name) {
            this.name = name;    
        }
        public override void SetMove(string[] listOfMoves) {
            move = listOfMoves[randomizer.Next(0, 4)];
        }
        public override string GetMove() {
            return this.move;
        }
        public override string GetName() {
            return this.name;
        }
    }//End of class
}
