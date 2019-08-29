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
        Random random = new Random();

        public GameDie()
        {
            numberOfSides = 6;
            this.value = this.RollGameDie();
        }

        public GameDie(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
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
