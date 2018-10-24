namespace Scanalyzer
{
	// PrintAnalyzer - Cory Press
	// Used in Scanlyzer classes to print out the gameboard and keep track
	// of the player's view of the board
    class Board
    {
        private char[][] GameBoard;	// Board as viewed by player
        private int rows;	// Num rows in gameboard
        private int cols;	// Num columns in gameboard
        private char evidenceType;	// Char representing evidence type
									// IE fingerprint = '@'
        private int guesses;	// Gueses made by player

        public Board(int r, int c, char type)
        {
            rows = r;
            cols = c;
            evidenceType = type;
            guesses = 0;
            GameBoard = new char[rows][];
            for (int i = 0; i < rows; i++)
                GameBoard[i] = new char[cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    GameBoard[i][j] = '~';
            }
        }

        // Processes gameboard after a guess is made
        public bool changeBoard(int r, int c, int evidenceR, int evidenceC)
        {
            if (r == evidenceR && c == evidenceC)
            {
                GameBoard[r][c] = evidenceType;
                resetBoard();
                return true;
            }
            else
            {
                bool pointHoriz = true;	// If both row and col are wrong,
                if (guesses++ % 2 == 1)	// will point in direction depending
                    pointHoriz = false;	// on number of guesses made

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
                        GameBoard[r][c] = '^';
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
                        GameBoard[r][c] = 'v';
                    else
                    {
                        if (pointHoriz)
                            GameBoard[r][c] = 'v';
                        else
                            GameBoard[r][c] = '>';
                    }
                }
            }
            return false;
        }

        public string GameBoardToString()
        {
            string board = "";
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                    board += "" + GameBoard[i][j] + ' ';
                board += '\n';
            }
            return board;
        }

		public int getGuesses()
		{
			return guesses;
		}

		public char getChar(int r, int c)
		{
			return GameBoard[r][c];
		}

		// Reset board
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
