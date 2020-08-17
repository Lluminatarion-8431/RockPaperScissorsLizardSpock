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

        }
    }
}
