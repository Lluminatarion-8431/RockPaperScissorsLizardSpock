using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        //Member Variables (Has a)
        public Random random;

        //Constructor (Spawner)
        public Computer()
        {
            random = new Random();
        }

        //Member Methods (Can do)
        public override void SetName()
        {
            name = "Computer";
        }
        public override void ChooseGesture()
        {
            int randomNumber = random.Next(0, gestureOptions.Count);
            playerChoice = gestureOptions[randomNumber];
        }
    }
}
