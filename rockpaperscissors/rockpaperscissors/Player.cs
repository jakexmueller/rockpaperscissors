﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    class Player
    {

        //member vriables
        Human human1;
        Human human2;
        Computer computer;
        //constructor

        //member methods

        
            // create player 1
      

            // create player 2


        public virtual string PickGesture(List<string> gestureOptions)
        {
            Console.WriteLine("Pick a gesture");
            return Console.ReadLine();

        }
    }
    

}
