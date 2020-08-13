using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        //Member Variables
        public Random random;
        //Constructor
        public Computer()
        {
            random = new Random();
        }

        //Member Methods
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
