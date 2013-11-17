namespace A14Ex01_4
{
     using System;
     using System.Collections.Generic;
     using System.Text;

     public class Utils
     {
          private static int s_DigitsCounter = 0;

          public static bool IsValidBinaryNumber(string i_BinaryStr)
          {
               bool isValid = true;
               foreach (char c in i_BinaryStr)
               {
                    if (c != '0' && c != '1')
                    {
                         isValid = false;
                         Console.WriteLine("Not a valid binary number!");
                         break;
                    }

                    s_DigitsCounter++;
               }

               if (s_DigitsCounter != 5 && isValid)
               {
                    isValid = false;
                    Console.WriteLine("Not a valid 5 digit number");
               }

               return isValid;
          }

          public static int ConvertToDecimalInt(string i_BinaryStr)
          {
              int decimalNumber = 0;
              for (int i = 0; i < i_BinaryStr.Length; i++)
              {
                  decimalNumber <<= 1;
                  if (i_BinaryStr[i] == '1')
                  {
                      decimalNumber++;
                  }
              }

              return decimalNumber;
          }

          public static bool IsPrime(int i_Number)
          {
              bool isPrime = true;
              for (int i = 2; i < i_Number; i++)
              {
                   if (i_Number % i == 0 && i != i_Number)
                   {
                        isPrime = false;
                        break;
                   }
              }

              return isPrime;
          }

          public static string GetUserInputString()
          {
               Console.WriteLine("Please enter a five digit binary number");
               return Console.ReadLine();
          }
     }
}