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
        Player player;
        
        public List<string> gestureOptions = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        


        //constructor

        //member methods
        public void StartGame()
        {
            // create player 1
            player = new Player();

            // create player 2
           

            Console.WriteLine("Type one of the following options to choose!");

            foreach (string gesture in gestureOptions)
            {
                
                Console.WriteLine(gesture);
           
            }
            string playerChoice = player.PickGesture(gestureOptions);
           // string player2Choice = player.PickGesture(gestureOptions);
        }




    }
}
