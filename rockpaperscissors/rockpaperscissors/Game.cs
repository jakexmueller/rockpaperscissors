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
        public List<int> gestureOptionNumbers = new List<int>() { };
        private readonly int count;




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
            int player1Choice = player1.PickGesture(gestureOptions);
            int player2Choice = player2.PickGesture(gestureOptions);


            int winnerFunction = (5 + player1Choice - player2Choice)%5;
                if(winnerFunction == 1 || winnerFunction == 3)
                {
                    Console.WriteLine("Player 1 wins");
                }
                else if(winnerFunction == 2 || winnerFunction == 4)
                {
                    Console.WriteLine("Player 2 wins");
                }
                else if (winnerFunction == 0)
                {
                    Console.WriteLine("It's a tie!");
                }

        }




    }
}
