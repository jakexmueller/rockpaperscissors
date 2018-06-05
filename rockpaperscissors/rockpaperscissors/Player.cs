using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    public class Player
    {

        //member vriables

        //constructor
        
        //member methods


        public virtual int PickGesture(List<string> gestureOptions)
        {
            Console.WriteLine("Pick a gesture");
            string userInput = Console.ReadLine();
            if (gestureOptions.IndexOf(userInput) == -1)
            {
                Console.WriteLine("Only use lowercase, and make sure your spelling is correct! Exit the program and re run everything.");
            }
            
                return gestureOptions.IndexOf(userInput);
            
            


        }
    }
    

}
