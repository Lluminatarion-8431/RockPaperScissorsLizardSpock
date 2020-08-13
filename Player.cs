using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        //Member Variables
        public string name;
        public int score;
        public ChosenGesture playerChoice;
        public List<ChosenGesture> gestureOptions;
        //Constructor
        public Player()
        {
            gestureOptions = new List<ChosenGesture>()
            {
                new ChosenGesture("Rock",new List<string>() { "Paper", "Scissors" }),
                new ChosenGesture("Paper",new List<string>() { "Scissors", "Lizard" } ),
                new ChosenGesture("Scissors",new List<string>() { "Rock", "Spock" } ),
                new ChosenGesture("Lizard",new List<string>() { "Rock", "Scissors" } ),
                new ChosenGesture("Spock", new List<string>(){"Paper","Lizard"})
            };
        }
        //Member Methods
        public abstract void ChooseGesture();
        public abstract void SetName();
    }
}
