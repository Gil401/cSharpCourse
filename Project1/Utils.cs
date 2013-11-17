using System;
using System.Collections.Generic;
using System.Text;

namespace Ex02
{
     class Utils
     {
          private const int k_QuitGame = 0;

          public static int GetValidInput(int i_MinValidVal, int i_MaxValidVal)
          {
               int usersChoice;
               string input = Console.ReadLine();
               while (!int.TryParse(input, out usersChoice) || usersChoice < i_MinValidVal || usersChoice > i_MaxValidVal)
               {
                    Console.WriteLine("Please enter your choice (from "+ i_MinValidVal +" to " + i_MaxValidVal + ")");
                    input = Console.ReadLine();
               }
               return usersChoice;
          } 
  
          public static int NumOfRows(eBoardSize i_eNumOfRows)
          {
               return (int)i_eNumOfRows;
          }

          public static int NumOfCols(eBoardSize i_eNumOfCols)
          {
               return (int)i_eNumOfCols;
          }

          public static int numOfBorderSigns(int i_NumOfCols)
          {
               return (i_NumOfCols += (i_NumOfCols / 2));
          }
     }
}
