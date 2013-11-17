using System;
using System.Collections.Generic;
using System.Text;

namespace Ex02
{
     public enum eGameMode { vsPc = 1, vsPlayer, exitGame }

     public class GameManager
     {
          private const int k_MaxNumOfPlayers = 2;
          private GameBoard m_GameBoard;
          private Player[] m_PlayersArray;
          private eGameMode m_GameMode;
          private bool k_IsHuman = true;
          private int m_CurrentPlayerNumber;
          private bool isEndOfGame;

          public GameManager()
          {
               isEndOfGame = false;
               UserInterface.ShowWelcomeMessage();
               m_CurrentPlayerNumber = 0;
               m_GameMode = (eGameMode)UserInterface.ChooseGameMode(); //the user picks the game mode
               initGameByMode();        //initialization according the chosen game mode
               startGame();
          }

          private void startGame()
          {
               int userChoice;
               while (true)
               {
                    m_GameBoard.PrintBoard();
                    userChoice = UserInterface.GetInputFromUser(m_PlayersArray[m_CurrentPlayerNumber].PlayerName) - 1;
                    while (!IsAvailable(userChoice))
                    {
                         UserInterface.FullColumnMsg();
                         userChoice = UserInterface.GetInputFromUser(m_PlayersArray[m_CurrentPlayerNumber].PlayerName) - 1;
                    }
                    insertCoinToBoard(userChoice);
                    updateCurrentPlayer();
                    ConsoleUtils.Screen.Clear();
               }

          }

          private void updateCurrentPlayer()
          {
               if (m_CurrentPlayerNumber == 0)
               {
                    m_CurrentPlayerNumber++;
               }
               else
               {
                    m_CurrentPlayerNumber--;
               }
          }
          private bool IsAvailable(int i_userChoice)
          {
               bool cellIsAvilable;
               
               if (m_GameBoard.FreeCells[i_userChoice] == -1)
               {
                    cellIsAvilable = false;
               }
               else
               {
                    cellIsAvilable = true;
               }
               return cellIsAvilable;
          }
          private void initGameByMode()
          {
               initPlayers();
               m_GameBoard = new GameBoard();
          }

          private void initPlayers()
          {
               m_PlayersArray = new Player[2];
               m_PlayersArray[0] = new Player(k_IsHuman);
               switch (m_GameMode)
               {
                    case eGameMode.vsPc:
                         m_PlayersArray[1] = new Player(false);
                         break;
                    case eGameMode.vsPlayer:
                         m_PlayersArray[1] = new Player(k_IsHuman);
                         break;
               }
          }

          public void insertCoinToBoard(int i_UserColumnChoice)
          {
               int placeInRow = m_GameBoard.FreeCells[i_UserColumnChoice];
               m_GameBoard.CellBoard[placeInRow, i_UserColumnChoice].Content = m_PlayersArray[m_CurrentPlayerNumber].PlayerSign;
               m_GameBoard.FreeCells[i_UserColumnChoice]--;
          }
     }
}

