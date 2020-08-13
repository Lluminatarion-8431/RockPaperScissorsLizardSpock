using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class ChosenGesture
    {
        //Member Variables
        public List<string> losesTo;
        public string type;

        //Constructor
        public ChosenGesture(string type, List<string> losesTo)
        {
            this.type = type;
            this.losesTo = losesTo;
        }
        //Member Methods


    }
}
