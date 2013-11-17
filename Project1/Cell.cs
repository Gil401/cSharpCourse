using System;
using System.Collections.Generic;
using System.Text;

namespace Ex02
{
     public enum eGameSigns
     {
          X=1,
          O,
          Empty
     }

     class Cell
     {
          private eGameSigns eCellContent;

          public Cell()
          {
               eCellContent = eGameSigns.Empty;
          }

          public eGameSigns Content
          {
               get
               {
                    return eCellContent;
               }
               set
               {
                    eCellContent = value;
               }
          }
     }
}
