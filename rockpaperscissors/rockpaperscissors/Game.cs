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
        public List<string> gestureOptions = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        public List<int> gestureOptionNumbers = new List<int>() { };

        //constructor
        

        //member methods
        public void GetPlayers()
        {
            //how many players?
            Console.WriteLine("The game is simple. It's Rock Paper Scissors; however we add Lizard and Spock.");
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Scissors cuts paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
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
            
            while (player1Choice == -1)
            {
                Console.WriteLine("Only use lowercase, and make sure your spelling is correct! Try Again.");
                player1Choice = player1.PickGesture(gestureOptions);
                // return;
            }

            int player2Choice = player2.PickGesture(gestureOptions);

            int winnerFunction = (5 + player1Choice - player2Choice)%5;
                if(winnerFunction == 2 || winnerFunction == 3)
                {
                    Console.WriteLine("PLAYER 1 WINS!");
                    Console.WriteLine("Player 1 Score:" + ++player1.score );
                    Console.WriteLine("Player 2 Score:" + player2.score);                
                }
                else if(winnerFunction == 1 || winnerFunction == 4)
                {
                    Console.WriteLine("PLAYER 2 WINS!");
                    Console.WriteLine("Player 1 Score:" + player1.score);
                    Console.WriteLine("Player 2 Score:" + ++player2.score);                
                }
                else if (winnerFunction == 0)
                {
                    Console.WriteLine("IT'S A TIE!");
                    Console.WriteLine("Player 1 Score:" + player1.score);
                    Console.WriteLine("Player 2 Score:" + player2.score);               
                }

                
                if (player1.score <4 && player2.score <4)
                {                   
                    Console.WriteLine("NEXT ROUND!");
                    Battle();
                }
                else if (player1.score >= 4)
                {
                    Console.WriteLine("PLAYER 1 IS SUPERIOR!!!!");
                }
                else if (player2.score >= 4)
                {
                    Console.WriteLine("PLAYER 2 IS SUPERIOR!!!!");
                }
            
        }




    }
}
