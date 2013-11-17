using System;
using System.Collections.Generic;
using System.Text;

namespace A14Ex01_5
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter some text");
            string inputString = Console.ReadLine();
            Console.WriteLine(inputString);
            Utils.CheckString(inputString);
            Utils.PrintResults();
        }
    }
}

/*
 mAor ohAnA 283

the number of small letter: 6
the number of small letter: 3
the number of small letter: 3
the number of small letter: 2
 */