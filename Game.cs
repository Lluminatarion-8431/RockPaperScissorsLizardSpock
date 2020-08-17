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
            gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
            actions = new List<string>() { "crushes", "cuts", "covers", "poisons", "smashes", "decapitates", "eats", "disproves", "vaporizes" };
        }

        //Member Methods (Can do)
        public void RunGame()
        {

        }
        public void DisplayRules()
        {

        }
        public void ChooseGameMode()
        {
            Console.WriteLine("Which type of game would you like play?");
            Console.WriteLine("1: Human vs. Human");
            Console.WriteLine("2: Human vs. Conputer");
            gameType = Console.ReadLine();
            return gameType;
        }
        public void ChooseTypeOfPlayerTwo()
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
                        playerTwo = new Computer;
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
    }
}
