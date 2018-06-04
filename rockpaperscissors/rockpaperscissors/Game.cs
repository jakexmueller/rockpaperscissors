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
        //Computer computer;
        
        public List<string> gestureOptions = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };



        //constructor

        //member methods

        public void GetPlayers()
        {
            //how many players?
            Console.WriteLine("How many players are in this game? Type '1' or '2'");
            string userInput = Console.ReadLine();
            //if one player, then instantiate Human and Computer
            if (userInput == "1"){
                player1 = new Human();
                player2 = new Computer();
            }
            //if two players, then instantiate Human and Human
            else if (userInput == "2"){
                player1 = new Human();
                player2 = new Human();
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
            string player2Choice = player2.PickGesture(gestureOptions);
            // string player2Choice = player.PickGesture(gestureOptions);
        }




    }
}
