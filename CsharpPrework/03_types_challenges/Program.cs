using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_types_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string lastname;// Not initialized
            string nationality = "Americain";
            Console.WriteLine(nationality);
            int birthmonth;// not initialized
            int children = 4;
            Console.WriteLine(children);
            bool isyoung; ;// Not initialized
            bool isold = true;
            Console.WriteLine(isold);
            decimal studentloan;
            decimal financial = 205.5M;
            Console.WriteLine(financial);
            float weight;
            float hight = 5.9f;
            Console.WriteLine("hight");
            double length;
          
            Console.WriteLine("speed");
                



            Console.ReadLine();

            string phonecall;
            string tomorrow = " will call you tomorrow";
            phonecall = "the call wAS made";
            Console.WriteLine(phonecall + " " + tomorrow);

            int bYear = Int32.Parse("1976");
            Console.WriteLine("I was born in {0}.", bYear);

        }
    }
}

