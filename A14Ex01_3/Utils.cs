 using System;
using System.Collections.Generic;
using System.Text;

namespace A14Ex01_3
{
    public class Utils
    {
         public static int GetNumberFromUser()
         {
              int chosenNumber;
              string input;
              Console.WriteLine("Hello, Please enter number of lines you would like");
              input = Console.ReadLine();

              // check if value is valid
              while (!int.TryParse(input, out chosenNumber) || chosenNumber < 0)
              {
                   Console.WriteLine("Please enter a valid number of lines");
                   input = Console.ReadLine();
              }

              return chosenNumber;
         }
    }
}
