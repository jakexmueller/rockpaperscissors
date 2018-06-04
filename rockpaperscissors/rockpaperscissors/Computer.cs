using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    class Computer : Player
    {

        //member variables

        //constructor

        //member methods
        public override int PickGesture(List<string> gestureOptions)
        {


            Random picker = new Random();
            int index = picker.Next(0, gestureOptions.Count);
            Console.WriteLine("The computer played... {0}",
                              gestureOptions[index]);
            
            return index;
        }
    }
}
