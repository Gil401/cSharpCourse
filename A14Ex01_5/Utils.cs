using System;
using System.Collections.Generic;
using System.Text;

namespace A14Ex01_5
{
     public class Utils
     {
          private static int s_NumOflittelLetter = 0;
          private static int s_NumOfBigLetter = 0;
          private static int s_NumOfNumbersInStr = 0;
          private static int s_NumOfwhiteSpaceInStr = 0;

          public static void CheckString(string i_InputString)
          {
               for (int i = 0; i < i_InputString.Length; i++)
               {
                    if (Char.IsUpper(i_InputString[i]))
                    {
                         s_NumOfBigLetter++;
                    }
                    else
                        if (Char.IsLower(i_InputString[i]))
                         {
                              s_NumOflittelLetter++;
                         }
                         else
                            if (Char.IsDigit(i_InputString[i]))
                              {
                                   s_NumOfNumbersInStr++;
                              }
                              else
                                   if (i_InputString[i] == ' ')
                                   {
                                        s_NumOfwhiteSpaceInStr++;
                                   }
               }
          }

          public static void PrintResults()
          {
               string m_str = string.Format(
@"
the number of small letters: {0}
the number of big letters: {1}
the number of digits: {2}
the number of spaces: {3}", 
               s_NumOflittelLetter.ToString(),
               s_NumOfBigLetter.ToString(),
               s_NumOfNumbersInStr.ToString(),
               s_NumOfwhiteSpaceInStr.ToString());
               Console.WriteLine(m_str + Environment.NewLine);
               Console.WriteLine("Press any key to exit...");
               Console.ReadKey();
          }
     }
}