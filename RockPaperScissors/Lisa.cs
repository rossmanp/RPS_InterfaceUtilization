using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Lisa : IPlayer
    {
        public string getName()
        {
            return "Lisa";
        }

        public Roshambo generateRoshambo()
        {
            

            int play = 0;
            Random rnd = new Random();
            play = rnd.Next(1, 4);
            switch (play)
            {
                case 1:
                    return Roshambo.Paper;                   
                case 2:
                    return Roshambo.Rock;                   
                case 3:
                    return Roshambo.Scissors;                   
                default:
                    Console.WriteLine("Error!");
                    break;
            }
            return Roshambo.Error;          
        }
    }
}
