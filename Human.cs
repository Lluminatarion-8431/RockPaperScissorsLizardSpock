using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Human : Player
    {
        //Member Variables

        //Constructor
        public Human()
        {

        }
        //Member Methods
        public override void SetName()
        {
            Console.WriteLine("Please enter in your name:");
            name = Console.ReadLine();
        }
       public override void ChooseGesture()
        {
            //Capture user input

            //Set value of gestureChosen member variable

            bool gestureChosen = false;

            while (gestureChosen == false)
            {
                Console.WriteLine("{0},Please Select One:", name);
                for (int i=0; i < gestureOptions.Count; i++)
                {
                    Console.WriteLine(i + ")" + gestureOptions[i].type);
                }
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        playerChoice = gestureOptions[0];
                        gestureChosen = true;
                        break;
                    case "1":
                        playerChoice = gestureOptions[1];
                        gestureChosen = true;
                        break;
                    case "2":
                        playerChoice = gestureOptions[2];
                        gestureChosen = true;
                        break;
                    case "3":
                        playerChoice = gestureOptions[3];
                        gestureChosen = true;
                        break;
                    case "4":
                        playerChoice = gestureOptions[4];
                        gestureChosen = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option, try again");
                        gestureChosen = false;
                        break;
                }
            }
        }
    }
}
