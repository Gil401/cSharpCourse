using System;
using System.Text;
using A14_Ex01_2;

namespace A14Ex01_3
{
   public class Program
    {
        public static void Main(string[] args)
        {
             int numberOfLines;
             numberOfLines = Utils.GetNumberFromUser();
             A14_Ex01_2.Utils.DrawDiamond(numberOfLines);
             A14_Ex01_2.Utils.PressEnterToExit();
        }
    }
}

/*
Hello, Please enter number of lines you would like
9
    *
   ***
  *****
 *******
*********
 *******
  *****
   ***
    *

Please press 'ENTER' to exit
*/