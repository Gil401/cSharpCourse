using System;
using System.Collections.Generic;
using System.Text;

namespace Ex02
{
     class UserInterface
     {
          private const int k_MinGameModeVal = 1;
          private const int k_MaxGameModeVal = 3;
          private const int k_MinBoardSize = 4;
          private const int k_MaxBoardSize = 8;

          private static int s_currMaxRowSize;
          private static int s_currMaxColSize;

          public static void ShowWelcomeMessage()
          {
               String.Format(
@"Hello and welcome to 4 IN A ROW!

");
          }
          public static string EnterYourName()
          {
               string.Format(
@"

Please enter your name:
");
               return (Console.ReadLine());
          }

          public static void SetChosenBoardSize(int i_NumOfRows, int i_NumOfCols)
          {
               s_currMaxRowSize = i_NumOfRows;
               s_currMaxColSize = i_NumOfCols;
          }

          public static int GetInputFromUser(string i_CurrentPlayerName)
          {
               Console.WriteLine(i_CurrentPlayerName + " it's your turn to play");
               {
                    return (Utils.GetValidInput(1, s_currMaxColSize));
               }
          }

          public static Enum ChooseGameMode()
          {
               Console.WriteLine(String.Format(
@"Please choose a game mode:
1. Play against PC
2. Play against a human player
3. Exit Game"));
               return ((eGameMode)Utils.GetValidInput(k_MinGameModeVal, k_MaxGameModeVal));
          }

          public static eBoardSize GetNumOfRows()
          {
               Console.WriteLine("Please enter number of rows for your board (Between 4 to 8)");
               return (eBoardSize)Utils.GetValidInput(k_MinBoardSize, k_MaxBoardSize);
          }

          public static eBoardSize GetNumOfCols()
          {
               Console.WriteLine("Please enter number of columns for your board (Between 4 to 8)");
               return (eBoardSize)Utils.GetValidInput(k_MinBoardSize, k_MaxBoardSize);
          }

          public static string AssignPlayerName(short i_CurrPlayerNumber)
          {
               string pName;
               Console.WriteLine("Player " + i_CurrPlayerNumber+1.ToString() + ", Please enter your name");
               pName = Console.ReadLine();
               while (pName.Equals(""))
               {
                    pName = Console.ReadLine();
               }
               return pName;
          }

          public static void FullColumnMsg()
          {
               Console.WriteLine("Sorry, but this column is full");
          }
     }
}