using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //Member Variables (Has a)
        public int pointsNeededToWin;
        public List<string> gestures;
        public List<string> actions;
        public string gameType;
        public Player playerOne;
        public Player playerTwo;

        //Constructor (Spawner)
        public Game()
        {
            pointsNeededToWin = 3;
            playerOne = new Human();
            //An array of gestures and actions to reference back to within my DisplayRules method object
            gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
            actions = new List<string>() { "crushes", "cuts", "covers", "poisons", "smashes", "decapitates", "eats", "disproves", "vaporizes" };
        }

        //Member Methods (Can do)
        public void DisplayRules()
        {

        }
        public string ChooseGameMode()
        {
            Console.WriteLine("Which type of game would you like play?");
            Console.WriteLine("1: Human vs. Human");
            Console.WriteLine("2: Human vs. Conputer");
            gameType = Console.ReadLine();
            return gameType;
        }
        public void ChooseTypeOfPlayerTwo(string userInput)
        {
            //switch-case object
            //instantiates playerTwo as Human or Computer
            //with userInput
            bool gameSelected = false;
            
            while (gameSelected == false)
            {
                switch (userInput)
                {
                    case "1":
                        playerOne = new Human();
                        playerOne.SetName();
                        playerTwo = new Human();
                        playerTwo.SetName();
                        gameSelected = true;
                        break;

                    case "2":
                        playerOne = new Human();
                        playerOne.SetName();
                        playerTwo = new Computer();
                        playerTwo.SetName();
                        gameSelected = true;
                        break;

                    default:
                        Console.WriteLine("Invalid selection, please choose 1 or 2.");
                        userInput = Console.ReadLine();
                        break;

                }
            } 
        }

        public void PlayAgain()
        {
            Console.WriteLine("Would you like to go another round? yes or no");
            string playAgain = Console.ReadLine();

            if (playAgain == "yes")
            {
                RunGame();
            } 
            else
            {
                Console.WriteLine("That ends the game, thanks for playing.");
                Console.ReadLine();
            }
        }
        public void RunGame()
        {
            string select = ChooseGameMode();
            ChooseTypeOfPlayerTwo(select);
            while (playerOne.score < 3 && playerTwo.score < 3)
            {
                Battle();
            }

            if (playerOne.score > playerTwo.score)
            {
                Console.WriteLine("{0} KILLED IT!!!", playerOne.name);
                PlayAgain();
            }
            else
            {
                Console.WriteLine("{0} KILLED IT!!!", playerTwo.name);
                PlayAgain();
            }
        }
        public void Battle()
        {
            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();

            if (playerOne.playerChoice.type == playerTwo.playerChoice.type)
            {
                Console.WriteLine("{0}:{1}\t{2}:{3}", playerOne.name, playerOne.playerChoice.type, playerTwo.name, playerTwo.playerChoice.type);
                Console.WriteLine("TIE!");
                Battle();
            }
            else if (playerOne.playerChoice.losesTo.Contains(playerTwo.playerChoice.type))
            {
                Console.WriteLine("{0}:{1}\t{2}:{3}", playerOne.name, playerOne.playerChoice.type, playerTwo.name, playerTwo.playerChoice.type);
                Console.WriteLine("{0} Dominated this match\n", playerTwo.name);
                playerTwo.score++;
            }
            else
            {
                Console.WriteLine("{0}:{1}\t{2}:{3}", playerOne.name, playerTwo.playerChoice.type, playerTwo.name, playerTwo.playerChoice.type);
                Console.WriteLine("{0} Dominated this match\n", playerOne.name);
                playerOne.score++;
            }
        }
    }
}
