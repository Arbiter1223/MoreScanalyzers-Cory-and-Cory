//*******************************************************************************
// Cory Michener
// October 1, 2018
// Program 4 - Find Sample Game
// ScanAnalyzer.cs
// Holds game grid and methods to alter the contents of said grid
//*******************************************************************************

using System;

namespace FindSampleGame___Cory_Michener
{
	static class ScanAnalyzer
	{
		// Static variables
		static Random random = new Random();
		static char[,] grid;
		static int sample1Row;
		static int sample1Col;
		static int sample2Row;
		static int sample2Col;
		static int rows;
		static int cols;
		static int guesses;
		static bool justFound;
		static bool found1;
		static bool found2;
		static bool win;

		// Constructor - Declares the grid and sets the guess counter to 0
		static ScanAnalyzer()
		{
			// Declare the grid
			char[,] grid;
			// Set the Guess counter to 0
			guesses = 0;
		}

		// Updates the grid in the matrix to be printed to the form
		static public void DisplayGrid()
		{
			// If a sample has just been found, see if both are found
			if (justFound)
			{
				// If a sample has been found, make every space
				// except that sample into tildes
				if (found1 | found2)
				{
					// Iterate through the grid rows
					for (int i = 0; i < ScanAnalyzer.GetRows(); i++)
					{
						// Iterate through the grid columns
						for (int j = 0; j < ScanAnalyzer.GetCols(); j++)
						{
							// If the space is not an 'X', make it into a tilde
							if (grid[i,j] != 'X')
							{
								grid[i, j] = '~';
							}
						}
					}
				}

				// If both samples have been found, the user wins the game!
				if (found1 & found2)
				{
					win = true;
				}
			}
		}

		// Takes the guess enterd by the user and determines if it's a sample
		// or where the guess is relative to the sample
		static public bool EvaluateGuess(int row, int col)
		{
			justFound = false;

			// Add one to guess
			SetGuesses(GetGuesses() + 1);

			// Check to see if the coordinates entered match the first sample
			// Do this only if first sample has not been found!
			if ((!found1) & ((row == sample1Row) & (col == sample1Col)))
			{
				found1 = true;

				// Set the coordinates of the sample in the grid
				grid[sample1Row, sample1Col] = 'X';
				justFound = true;
			}

			// If it doesn't match the first sample,
			// check to see if it matches the second sample
			// Do this only if the second sample has not been found!
			else if ((!found2) & ((row == sample2Row) & (col == sample2Col)))
			{
				found2 = true;

				// Set the coordinates of the sample in the grid
				grid[sample2Row, sample2Col] = 'X';
				justFound = true;
			}
			
			// Otherwise, point the user in the right direction
			else
			{
				// If searching for the first sample...
				if (!found1)
				{
					// Up or down every even guess
					// or if the space is in the correct column
					if (((GetGuesses() % 2 == 0) & (row != sample1Row)) | 
						col == sample1Col)
					{
						UpOrDown1(row, col);
					}

					// Left or right every odd guess
					// or if the space is in the correct row
					else if (((GetGuesses() % 2 == 1) & (col != sample1Col)) | 
						row == sample1Row)
					{
						LeftOrRight1(row, col);
					}
				}

				// If searching for the second sample...
				else if (!found2)
				{
					// Up or down every even guess
					// or if the space is in the correct column
					if (((GetGuesses() % 2 == 0) & (row != sample2Row)) | 
						col == sample2Col)
					{
						UpOrDown2(row, col);
					}

					// Left or right every odd guess
					// or if the space is in the correct row
					else if (((GetGuesses() % 2 == 1) & (col != sample2Col)) |
						row == sample2Row)
					{
						LeftOrRight2(row, col);
					}
				}
			}
			return justFound;
		}

		// Functions below are used to determine
		// where the sample is relative to the guess the user made
		// Determines if Sample 1 is in higher or lower row than guess
		static public void UpOrDown1(int row, int col)
		{
			// If the sample is in a higher row, point up
			if (row > sample1Row)
			{
				grid[row, col] = '^';
			}

			// Else, if the  sample is in lower row, point down
			else if (row < sample1Row)
			{
				grid[row, col] = 'v';
			}
		}

		// Determines if Sample 1 is in left-more or right-more column than guess
		static public void LeftOrRight1(int row, int col)
		{
			// If the sample is in a left-more column, point left
			if (col > sample1Col)
			{
				grid[row, col] = '<';
			}

			// Else, if the sample is in a right-more column, point right
			else if (col < sample1Col)
			{
				grid[row, col] = '>';
			}
		}

		// Determines if Sample 2 is in higher or lower row than guess
		static public void UpOrDown2(int row, int col)
		{
			// If the sample is in a higher row, point up
			if (row > sample2Row)
			{
				grid[row, col] = '^';
			}

			// Else, if the  sample is in lower row, point down
			else if (row < sample2Row)
			{
				grid[row, col] = 'v';
			}
		}

		// Determines if Sample 2 is in left-more or right-more column than guess
		static public void LeftOrRight2(int row, int col)
		{
			// If the sample is in a left-more column, point left
			if (col > sample2Col)
			{
				grid[row, col] = '<';
			}

			// Else, if the sample is in a right-more column, point right
			else if (col < sample2Col)
			{
				grid[row, col] = '>';
			}
		}

		// Sets Grid Size to user input and generates the two hidden samples
		static public void SetGridSize(int r, int c)
		{
			// Set class variables for rows and columns
			rows = r;
			cols = c;

			// Create the grid based on user specifications
			grid = new char[rows, cols];

			// Iterate through the grid rows
			for (int i = 0; i < rows; i++)
			{
				// Iterate through the grid columns
				for (int j = 0; j < cols; j++)
				{
					// Fill the grid with tildes (~)
					grid[i, j] = '~';
				}
			}

			// Generate the coordinates for the first hidden sample
			sample1Row = random.Next(0, rows);
			sample1Col = random.Next(0, cols);

			// If the second sample has the same coordinates as the first,
			// regenerate the second sample coordinates
			do
			{
				sample2Row = random.Next(0, rows);
				sample2Col = random.Next(0, cols);
			} while ((sample2Row == sample1Row) & (sample2Col == sample1Col));

			// Reset flags
			found1 = false;
			found2 = false;
			win = false;
		}

		// Getters and Setters
		// Get the number of rows for the grid
		static public int GetRows()
		{
			return rows;
		}

		// Set the number of rows for the grid
		static public void SetRows(int r)
		{
			rows = r;
		}

		// Get the number of columns for the grid
		static public int GetCols()
		{
			return cols;
		}

		// Set the number of columns for the grid
		static public void SetCols(int c)
		{
			cols = c;
		}

		// Returns the contents of the coordinates passed to function
		static public char GetGridPos(int r, int c)
		{
			return grid[r,c];
		}

		// Get the number of guesses the user has made
		static public int GetGuesses()
		{
			return guesses;
		}

		// Set the number of guesses the user has made (namely, reset to 0)
		static public void SetGuesses(int guess)
		{
			guesses = guess;
		}

		// Returns true if the user has won the game
		static public bool GetWin()
		{
			return win;
		}
	}
}
