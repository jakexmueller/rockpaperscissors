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
        public int score;
        public int gesture;

        //constructor

        //member methods


        public virtual int PickGesture(List<string> gestureOptions)
        {
            Console.WriteLine("Pick a gesture");
            string userInput = Console.ReadLine();
            
            
            return gestureOptions.IndexOf(userInput);
            
            


        }
    }
    

}
