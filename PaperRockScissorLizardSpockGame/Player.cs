using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperRockScissorLizardSpockGame
{
    class Player{
        protected string name;
        protected string move;
        public Player (string name){
            this.name = name;
        }
        public virtual string GetMove() {
            return move;
        }
        public virtual void SetMove(string[] listOfMoves) {
            Console.WriteLine("SetMove() in base class");
        }
        public virtual string GetName() {
            return "This is the GetName() in the base class";
        }
    }//End of class
}
