namespace A14Ex01_4
{
     using System;
     using System.Collections.Generic;
     using System.Text;

     public class Program
     {
        public static void Main(string[] args)
        {
             int decimalNumber;
             string inputString = Utils.GetUserInputString();
             if (Utils.IsValidBinaryNumber(inputString))
             {
                decimalNumber = Utils.ConvertToDecimalInt(inputString);
                
                Console.WriteLine("It is a valid binary number");
                Console.WriteLine("The decimal number is: {0}", decimalNumber);
                if (Utils.IsPrime(decimalNumber))
                {
                    Console.WriteLine("The number {0} IS a prime number", decimalNumber);
                }
                else
                {
                    Console.WriteLine("The number {0} is NOT a prime number" + Environment.NewLine, decimalNumber);
                }
             }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

/*
Please enter a five digit binary number
11001
It is a valid binary number
The decimal number is: 25
The number 25 is NOT a prime number

Press any key to exit...

*/