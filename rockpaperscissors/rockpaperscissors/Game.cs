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
        Player player1;
        Player player2;
        Computer computer;
        
        public List<string> gestureOptions = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };



        //constructor

        //member methods
        public void PickPlayers()
        {

            // create player 1
            player1 = new Player();

            // create player 2


            Console.WriteLine("Are you playing against the computer or another person? Type your answer below");
            string userInput = Console.ReadLine();

            if (userInput == "person")
            {
                player2 = new Player();
            }
            else if (userInput == "computer")
            {
                computer = new Computer();
            }
        }   

        public void Battle()
        {
        
            Console.WriteLine("Type one of the following options to choose!");

            foreach (string gesture in gestureOptions)
            {
                
                Console.WriteLine(gesture);
           
            }
            string player1Choice = player1.PickGesture(gestureOptions);
            string player2Choice = computer.PickGesture(gestureOptions);
            // string player2Choice = player.PickGesture(gestureOptions);
        }




    }
}
