using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    class Player1
    {

        //member variables
        public List<string> gesturePicks = new List<string>();

        //constructor

        //member methods
        //public void PickGesture()
        //{
        //    string userInput = Console.ReadLine();
        //}

        public string PickGesture(List<string> gestureOptions)
        {
            Console.WriteLine("Pick a gesture");
            return Console.ReadLine();
        }
    }
}
