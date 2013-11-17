using System;
using System.Collections.Generic;
using System.Text;

namespace Ex02
{
     class Player
     {
          private bool isHumanPlayer;
          private string m_PlayerName;
          private short points;
          private static short k_CurrentPlayerNumber = 1;
          private const int k_Zero = 0;
          private eGameSigns m_PlayerSign;

          public Player (bool i_IsHumanPlayer)
          {
               isHumanPlayer = i_IsHumanPlayer;
               points = k_Zero;
               m_PlayerSign = (eGameSigns)k_CurrentPlayerNumber;
               if (isHumanPlayer)
               {
                    m_PlayerName = UserInterface.AssignPlayerName(k_CurrentPlayerNumber);
               }
               else
               {
                    m_PlayerName = "The Mighty PC";
               }
               k_CurrentPlayerNumber++;
          }

          public bool PlayerType
          {
               get
               {
                    return isHumanPlayer;
               }
               set
               {
                    isHumanPlayer = value;
               }
          }
               
          public string PlayerName
          {
               get
               {
                    return m_PlayerName;
               }
               set
               {
                    m_PlayerName = value;
               }
          }

          public eGameSigns PlayerSign
          {
               get
               {
                    return m_PlayerSign;
               }
          }
     }

}