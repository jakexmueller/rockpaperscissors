using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    class Game
    {

        //member variables
        public List<string> gestureOptions = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        


        //constructor

        //member methods
        public void PrintOptions()
        {
            foreach(string gesture in gestureOptions)
            {
                Console.WriteLine(gesture);
           
            }
            Console.ReadLine();
        }




    }
}
