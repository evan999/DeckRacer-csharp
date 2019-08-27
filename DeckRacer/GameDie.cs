using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeGame
{
    public class GameDie
    {
        // public string name;
        public int value;
        
        public GameDie()
        {
            numberOfSides = 6;
            random = new Random();
        }

        public GameDie(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
            random = new Random();
        }

        public int RollGameDie()
        {
            // Random randomizer = new Random();
            int maxValue = 8;
            int minValue = 1;
            int roll = random.Next(minValue, maxValue);
            // Console.WriteLine("Die: " + roll);
            return roll;
        }

    }
}
