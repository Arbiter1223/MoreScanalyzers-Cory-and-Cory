using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Scanalyzers___Cory_and_Cory
{
    //PrintAnalyzer - Cory Press
    //Used in Scanlyzer classes to print out the gameboard 
    //and keep track of the players view of the board
    class PrintAnalyzer
    {
        private char[][] GameBoard;//board as viewed by player
        private int rows;//num rows in gameboard
        private int cols;//num columns in gameboard
        private char evidenceType;//char representing evidence type
                                  //IE fingerprint = '@'
        private int geusses;//geuses made by player

        public PrintAnalyzer(int r, int c, char type)
        {
            rows = r;
            cols = c;
            evidenceType = type;
            GameBoard = new char[cols][];
            for (int i = 0; i < cols; i++)
            {
                GameBoard[i] = new char[rows];
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    GameBoard[i][j] = '~';
            }
        }

        //Processes gameboard after a geuss is made
        public void changeBoard(int r, int c, int evidenceR, int evidenceC)
        {
            if (r == evidenceR && c == evidenceC)
            {
                GameBoard[r][c] = evidenceType;
                resetBoard();
            }
            else
            {
                bool pointHoriz = true;//if both row and col are wrong
                if (geusses % 2 == 1)  //will point in direction depending
                {                      //on number of geusses made 
                    pointHoriz = false;
                }

                if (r > evidenceR)
                {
                    if (c > evidenceC)
                    {
                        if (pointHoriz)
                            GameBoard[r][c] = '^';
                        else
                            GameBoard[r][c] = '<';
                    }
                    else if (c == evidenceC)
                    {
                        GameBoard[r][c] = '<';
                    }
                    else
                    {
                        if (pointHoriz)
                            GameBoard[r][c] = '^';
                        else
                            GameBoard[r][c] = '>';
                    }
                }
                else if (r == evidenceR)
                {
                    if (c > evidenceC)
                        GameBoard[r][c] = '<';
                    else
                        GameBoard[r][c] = '>';
                }
                else
                {
                    if (c > evidenceC)
                    {
                        if (pointHoriz)
                            GameBoard[r][c] = 'v';
                        else
                            GameBoard[r][c] = '<';
                    }
                    else if (c == evidenceC)
                    {
                        GameBoard[r][c] = '<';
                    }
                    else
                    {
                        if (pointHoriz)
                            GameBoard[r][c] = 'v';
                        else
                            GameBoard[r][c] = '>';
                    }
                }
                    
            }
        }

        public String GameBoardToString()
        {
            String board = "  ";
            if (cols > 9)
            {
                if (rows > 9)
                    board += " ";
                board += "         ";
                for (int i = 10; i <= cols; i++)
                {
                    board += i / 10;
                }
                board += "\n  ";
                if (rows > 9)
                    board += " ";

            }
            for (int i = 1; i <= cols; i++)
            {
                board += i % 10;
            }
            board += "\n";
            for (int r = 0; r < rows; r++)
            {
                board += r + 1 + " ";
                if (r < 9 && rows > 9)
                    board += " ";
                for (int c = 0; c < cols; c++)
                {
                    board += GameBoard[r][c];
                }
                board += "\n";
            }
            return board;
        }

        //resets Board
        private void resetBoard()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (GameBoard[r][c] != evidenceType)
                        GameBoard[r][c] = '~';
                }
                    
            }
        }
    }
}
