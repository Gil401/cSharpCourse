namespace A14_Ex01_2
{
     using System;
     using System.Collections.Generic;
     using System.Text;

     public class Utils
     {    
          public static StringBuilder m_Diamond = new StringBuilder();
          private const int k_NumOfAstrixToAdd = 2;

          public static void DrawDiamond(int i_DiamondHeight)
          {
               validateNumberOfRows(ref i_DiamondHeight);
               buildUpperTriangle(i_DiamondHeight);
               buildLowerTriangle(i_DiamondHeight);
               Console.WriteLine(m_Diamond.ToString());
        }

          public static void PressEnterToExit()
          {
               Console.WriteLine("Please press 'ENTER' to exit");
               Console.ReadKey();
          }
          
          private static void validateNumberOfRows(ref int io_NumOfRows)
          {
               if (io_NumOfRows % 2 == 0)
               {
                    io_NumOfRows--;
               }
          }

          /* Fix number of rows in case of an even number */

          private static void buildUpperTriangle(int i_TriangleHeight)
          {
               int numberOfSpaces = i_TriangleHeight / 2;
               int numberOfAstrixes = 1;

               while (numberOfAstrixes <= i_TriangleHeight)
               {
                    appendAstrixAndSpacesToDiamond(numberOfAstrixes, numberOfSpaces);
                    numberOfSpaces--;
                    numberOfAstrixes += k_NumOfAstrixToAdd;
               }
          }

          /* Build the upper triangle of the diamond, includes the middle row */
          private static void buildLowerTriangle(int i_TriangleHeight)
          {
               int numberOfSpaces = 1;
               int numberOfAstrixes = i_TriangleHeight - k_NumOfAstrixToAdd;

               for (int i = 0; i < i_TriangleHeight / 2; i++)
               {
                    appendAstrixAndSpacesToDiamond(numberOfAstrixes, numberOfSpaces);
                    numberOfSpaces++;
                    numberOfAstrixes -= k_NumOfAstrixToAdd;
               }
          }

          /* Build the lower triangle of the diamond, excludes the middle row */
          private static void appendAstrixAndSpacesToDiamond(int i_NumberOfAstrixes, int i_NumberOfSpaces)
          {
               for (int i = 0; i < i_NumberOfSpaces; i++)
               {
                    m_Diamond.Append(" ");
               }

               for (int i = 0; i < i_NumberOfAstrixes; i++)
               {
                    m_Diamond.Append("*");
               }
               
               m_Diamond.Append(Environment.NewLine);
          }

          private static void appendAstrixAndSpacesToDiamond(int i_NumberOfAstrixes)
          {
               appendAstrixAndSpacesToDiamond(i_NumberOfAstrixes, 0);
          }        
     }
}