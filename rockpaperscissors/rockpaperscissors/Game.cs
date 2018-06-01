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
        Player1 player1;
        Player2 player2;
        public List<string> gestureOptions = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        


        //constructor

        //member methods
        public void StartGame()
        {
            // create player 1
            player1 = new Player1();

            // create player 2
            player2 = new Player2();

            Console.WriteLine("Type one of the following options to choose!");

            foreach (string gesture in gestureOptions)
            {
                
                Console.WriteLine(gesture);
           
            }
            string player1Choice = player1.PickGesture(gestureOptions);           
        }




    }
}
