﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_boolean_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = 100 / 2;
           
            if (value == 50 )
            {
                Console.WriteLine(true);
            }


            double x = 101d / 2d;

            if (x == 50d)
            {
                Console.WriteLine(true);
            }


            Console.WriteLine("Can you guess what number I am thinking of? It is between 1-20");
            int guessNumber = Convert.ToInt16(Console.ReadLine());
            if (guessNumber <= 7 && guessNumber >= 1)
            {
                Console.WriteLine("You need to go much higher!");
            }
            else if (guessNumber <= 14 && guessNumber > 7) 
            {
                Console.WriteLine("Little bit higher!");
            }
            else if (guessNumber == 15)
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
            }
            else if (guessNumber >= 16 && guessNumber <= 20)
            {
                Console.WriteLine("Oops, little bit lower");
            }
            else
            {
                Console.WriteLine("Did you read the instructions?");
            }
            Console.ReadLine();


        }
    }
}
