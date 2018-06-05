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
        public int player1Score=0;
        public int player2Score=0;

        //Computer computer; 
        public List<string> gestureOptions = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        public List<int> gestureOptionNumbers = new List<int>() { };

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
            else
            {
                Console.WriteLine("That was not a '1,' nor was it a '2.' Try again and do better.");
                GetPlayers();
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
                if(winnerFunction == 2 || winnerFunction == 3)
                {
                    Console.WriteLine("PLAYER 1 WINS!");
                    Console.WriteLine("Player 1 Score:" + ++player1Score );
                    Console.WriteLine("Player 2 Score:" + player2Score);                
                }
                else if(winnerFunction == 1 || winnerFunction == 4)
                {
                    Console.WriteLine("PLAYER 2 WINS!");
                    Console.WriteLine("Player 1 Score:" + player1Score);
                    Console.WriteLine("Player 2 Score:" + ++player2Score);                
                }
                else if (winnerFunction == 0)
                {
                    Console.WriteLine("IT'S A TIE!");
                    Console.WriteLine("Player 1 Score:" + player1Score);
                    Console.WriteLine("Player 2 Score:" + player2Score);               
                }

                
                if (player1Score <4 && player2Score <4)
                {                   
                    Console.WriteLine("NEXT ROUND!");
                    Battle();
                }
                else if (player1Score >= 4)
                {
                    Console.WriteLine("PLAYER 1 IS SUPERIOR!!!!");
                }
                else if (player2Score >= 4)
                {
                    Console.WriteLine("PLAYER 2 IS SUPERIOR!!!!");
                }
            
        }




    }
}
