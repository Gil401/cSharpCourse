using System;
using System.Collections.Generic;
using System.Text;

namespace A14_Ex01_2
{
     public class Program
     {
          private const int k_NumberOfRows = 5;

          public static void Main()
          {
               Utils.DrawDiamond(k_NumberOfRows);
               Utils.PressEnterToExit();
          }
     }
}

/*
  *
 ***
*****
 ***
  *

Please press 'ENTER' to exit
 */