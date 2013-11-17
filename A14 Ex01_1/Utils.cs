using System;
using System.Collections.Generic;
using System.Text;

namespace A14_Ex01_1
{
     public class Utils
     {
          private const int k_EndOfInput = -1;
          private const int k_InvalidNumber = 0;
          private static int s_FirstNumber;
          private static bool s_FirstNumberEntered = false;

          public static void PrintResultsToScreen(int i_MaximalNumber, int i_MinimalNumber, int i_NumOfNumbers, float i_AvgOfNumbers, int i_NumOfDividedNums)
          {
               string msg = string.Format(
@"Hello!
The Maximal numbers is: {0}
The Minimal number is: {1}
You entered {2} numbers and their average was:{3}
{4} numbers are divided by the first number

",
                                            i_MaximalNumber,
                                            i_MinimalNumber,
                                            i_NumOfNumbers,
                                            i_AvgOfNumbers,
                                            i_NumOfDividedNums);
               Console.WriteLine(msg);
          }

          public static int GetNumberFromUser(ref int io_NumOfNumbers)
          {
               string input;
               int numberFromUser;
               input = Console.ReadLine(); // get input from user

               // check wether value is valid
               while (!int.TryParse(input, out numberFromUser) || numberFromUser < k_EndOfInput || numberFromUser == k_InvalidNumber) 
               {
                    Console.WriteLine("Please enter a valid positive integer");
                    input = Console.ReadLine();
               }
               
               // checks if an integer or just end of input
               if (numberFromUser != -1) 
               {
                    // checks if first number
                    if (!s_FirstNumberEntered)
                    {
                         s_FirstNumber = numberFromUser;
                                          }

                    io_NumOfNumbers++;
               }

               return numberFromUser;
          }

          public static void CheckMaxMinNumber(int i_CurrentNumber, ref int io_MaximalNumber, ref int io_MinimalNumber)
          {
               io_MaximalNumber = Math.Max(i_CurrentNumber, io_MaximalNumber);
               io_MinimalNumber = Math.Min(i_CurrentNumber, io_MinimalNumber);
          }

          public static float CalcAvg(float i_SumOfNumbers, int i_NumOfNumbers)
          {
               return i_SumOfNumbers / i_NumOfNumbers;
          }

          public static void CheckIfDividedByFirstNumber(int i_CurrentNumber, ref int io_NumOfDividedNumber)
          {
               if ((i_CurrentNumber % s_FirstNumber) == 0 && s_FirstNumberEntered)
               {
                    io_NumOfDividedNumber++;
               }

               s_FirstNumberEntered = true;
          }

          public static void PressEnterToExit()
          {
               Console.WriteLine("Please press 'enter' to quit...");
               Console.ReadKey();
          }
     }
}
