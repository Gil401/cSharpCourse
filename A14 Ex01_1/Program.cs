using System;
using System.Collections.Generic;
using System.Text;

namespace A14_Ex01_1
{
     public class Program
     {
          // constants
          private const int k_EndOfInput = -1;
          private const int k_NoNumbersEntered = 0;

          public static void Main()
          {
               float avgOfNumbers = 0;
               int minimalNumber = 0, maximalNumber = 0, currentNumber = 0,
                   numOfNumbers = 0, numOfDevidedNumbers = 0;
               
               Console.WriteLine("Please enter numbers. (to end input please enter -1...) ");
               maximalNumber = minimalNumber = currentNumber = Utils.GetNumberFromUser(ref numOfNumbers);
               while (currentNumber != k_EndOfInput)
               {
                    avgOfNumbers += currentNumber;
                    Utils.CheckMaxMinNumber(currentNumber, ref maximalNumber, ref minimalNumber);
                    Utils.CheckIfDividedByFirstNumber(currentNumber, ref numOfDevidedNumbers);
                    currentNumber = Utils.GetNumberFromUser(ref numOfNumbers);
               }

               if (numOfNumbers == k_NoNumbersEntered)
               {
                    Console.WriteLine("Have a great day");
               }
               else
               {
                    avgOfNumbers = Utils.CalcAvg(avgOfNumbers, numOfNumbers);
                    Utils.PrintResultsToScreen(maximalNumber, minimalNumber, numOfNumbers, avgOfNumbers, numOfDevidedNumbers);
               }

               Utils.PressEnterToExit();
          }
     }
}