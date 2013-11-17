using System;
using System.Collections.Generic;
using System.Text;
using Ex02.ConsoleUtils;

namespace Ex02
{
     public enum eBoardSize { Four = 4, Five, Six, Seven, Eight}

     class GameBoard
     {
          private eBoardSize m_eNumOfRows; 
          private eBoardSize m_eNumOfCols;
          private Cell[,] m_BoardMatrix;
          private int[] m_NumOfFreeCellsInCol;
          
          public GameBoard()
          {
               m_eNumOfRows = UserInterface.GetNumOfRows();
               m_eNumOfCols = UserInterface.GetNumOfCols();
               UserInterface.SetChosenBoardSize(Utils.NumOfRows(m_eNumOfRows), Utils.NumOfCols(m_eNumOfCols));
               m_NumOfFreeCellsInCol = new int[(int)m_eNumOfCols];
               initBoard();
          }

          private void initBoard()
          {
               m_BoardMatrix = new Cell[(int)m_eNumOfRows, (int)m_eNumOfCols];

               for (int i = 0; i < (int)m_eNumOfRows; i++)
               {
                    for (int j = 0; j < (int)m_eNumOfCols; j++)
                    {
                         m_BoardMatrix[i, j] = new Cell();
                         m_BoardMatrix[i, j].Content = eGameSigns.Empty;
                    }
                }

               for (int j = 0; j < (int)m_eNumOfCols; j++)
               {
                    m_NumOfFreeCellsInCol[j] = (int)m_eNumOfRows-1;
               }
          }

          public void PrintBoard()
          {
               StringBuilder board = new StringBuilder();
               ConsoleUtils.Screen.Clear();
               for (int j = 0; j < (int)m_eNumOfCols; j++)
               {
                    board.Append("  "+ (j+1) + "  ");
               }
               board.Append(Environment.NewLine);
               for (int i = 0; i < (int)m_eNumOfRows; i++)
               {
                    for (int j = 0; j < (int)m_eNumOfCols; j++)
                    {
                         board.Append("| " + getBoardSymbol(i, j) + " |");
                    }
                    board.Append(Environment.NewLine);
                    for (int j = 0; j < (int)m_eNumOfCols; j++)
                    {
                         board.Append("=====");
                    }
                    board.Append(Environment.NewLine);
               }
               Console.WriteLine(board.ToString());
          }

          private string getBoardSymbol(int i_Row, int i_Col)
          {
               string symbol;
               eGameSigns sign = new eGameSigns();
               sign = m_BoardMatrix[i_Row, i_Col].Content;
               if (sign.Equals(eGameSigns.Empty))
               {
                    symbol = " ";
               }
               else
               {
                    symbol = sign.ToString();
               }
               return symbol;
          }

          public Cell[,] CellBoard
          {
               get
               {
                    return m_BoardMatrix;
               }
          }

          public int[] FreeCells
          {
               get
               {
                    return m_NumOfFreeCellsInCol;
               }
          }
     }
}