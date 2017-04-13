using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Bart : IPlayer
    {
        public string getName()
        {
            return "Bart";
        }

        public Roshambo generateRoshambo()
        {          
            return Roshambo.Rock;
        }
    }
}
