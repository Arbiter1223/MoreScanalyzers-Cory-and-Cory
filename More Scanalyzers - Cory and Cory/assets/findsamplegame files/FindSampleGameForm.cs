//*******************************************************************************
// Cory Michener
// October 1, 2018
// Program 4 - Find Sample Game
// FindSampleGameForm.cs
// Recieves input from user and maintains visual GUI of the game
//*******************************************************************************

// Magnifying glass clip art link: http://www.clker.com/clipart-2195.html



using System;
using System.Windows.Forms;

namespace More_Scanalyzers___Cory_and_Cory
{
	public partial class FindSampleGameForm : Form
	{
		// Default form constructor
		public FindSampleGameForm()
		{
			InitializeComponent();
		}

		// Validates if user entered a valid grid size
		public void CheckGridSizeValidity()
		{
			// Make sure the user entered an int for row size
			if (int.TryParse(textBoxGridSizeRows.Text, out int rows))
			{
				// Make sure rows are within accepted range
				rows = (rows > 1 && rows <= 10) ? rows : -1;
				if (rows != -1)
				{
					// Make sure the user entered an int for column size
					if (int.TryParse(textBoxGridSizeColumns.Text, out int cols))
					{
						// Make sure columns are within accepted range
						cols = (cols > 1 && cols <= 10) ? cols : -1;
						if (cols != -1)
						{
							// If both numbers check out, start the game
							StartGame(rows, cols);
						}

						// Otherwise, do not accept
						else
						{
							MessageBox.Show("Error: Value entered for Columns " +
								"is out of range!", "Error",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}

					// Otherwise, do not accept
					else
					{
						MessageBox.Show("Error: Value entered for Columns " +
							"is not an int!", "Error", MessageBoxButtons.OK,
							MessageBoxIcon.Error);
					}
				}

				// Otherwise, do not accept
				else
				{
					MessageBox.Show("Error: Value entered for Rows " +
						"is out of range!", "Error", MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				}
			}

			// Otherwise, do not accept
			else
			{
				MessageBox.Show("Error: Value entered for Rows is not an int!",
					"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Gets form ready to get grid size
		public void NewGame()
		{
			// Enable controls for entering grid size
			// Disable guess controls
			textBoxGridSizeRows.Enabled = true;
			textBoxGridSizeColumns.Enabled = true;
			textBoxGridSizeRows.Clear();
			textBoxGridSizeColumns.Clear();
			buttonStartGame.Enabled = true;
			labelGridColumns.Visible = false;
			labelGridRows.Visible = false;
			textBoxGuessRow.Enabled = false;
			labelGrid.Visible = false;
			textBoxGuessColumn.Enabled = false;
			buttonSubmitGuess.Enabled = false;
			labelGuesses.Visible = false;
			labelLastGuess.Visible = false;
			labelGuessResponse.Visible = false;

			// Update instructions
			labelInstructions.Text = "Enter the number of rows and\n" +
				"columns for the game grid.\n" +
				"Both range from 2 - 10.";
		}

		// Starts a new game with entered grid size
		public void StartGame(int rows, int cols)
		{
			// Enable controls for entering guesses
			// Disable grid size controls
			textBoxGridSizeRows.Enabled = false;
			textBoxGridSizeColumns.Enabled = false;
			buttonStartGame.Enabled = false;
			textBoxGuessRow.Enabled = true;
			textBoxGuessColumn.Enabled = true;
			buttonSubmitGuess.Enabled = true;

			// Set the grid size using the parameters entered by the user
			ScanAnalyzer.SetGridSize(rows, cols);

			// Generate the initial grid
			labelGrid.Text = "";
			labelGridColumns.Text = "";
			labelGridRows.Text = "";

			// Fill the column numbers
			for (int i = 0; i < cols; i++)
			{
				labelGridColumns.Text += $" {i}";
			}

			// Fill all spaces with tildes (~), even the spaces with the samples
			for (int i = 0; i < rows; i++)
			{
				// Fill in the row number
				labelGridRows.Text += $"{i}\n";

				// Fill the rest of the row with tildes
				for (int j = 0; j < cols; j++)
				{
					labelGrid.Text += "~ ";
				}
				labelGrid.Text += "\n";
			}

			// Render the row and column numbers
			labelGridColumns.Visible = true;
			labelGridRows.Visible = true;

			// Render the grid itself
			labelGrid.Visible = true;

			// Update instructions
			labelInstructions.Text = "Enter the coordinates of a space\n" +
				"at the bottom of the form to reveal\n" +
				"that space. Must be within the\n" +
				"bounds of the grid.";

			// Update Guesses counter
			ScanAnalyzer.SetGuesses(0);
			labelGuesses.Text = $"Guesses: {ScanAnalyzer.GetGuesses()}";
			labelGuesses.Visible = true;
		}

		// Validates if user entered a valid guess
		public void CheckGuessValidity()
		{
			// Make sure the user entered an int for row guess
			if (int.TryParse(textBoxGuessRow.Text, out int r))
			{
				// Make sure row is within accepted range
				r = (r < ScanAnalyzer.GetRows()) ? r : -1;
				if (r != -1)
				{
					// Make sure the user entered an int for column guess
					if (int.TryParse(textBoxGuessColumn.Text, out int c))
					{
						// Make sure column is within accepted range
						c = (c < ScanAnalyzer.GetCols()) ? c : -1;
						if (c != -1)
						{
							// If both numbers check out, accept the guess
							EvaluateGuess(r, c);
						}

						// Otherwise, do not accept
						else
						{
							MessageBox.Show("Error: Value entered for column " +
								"is out of range!", "Error",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}

					// Otherwise, do not accept
					else
					{
						MessageBox.Show("Error: Value entered for column " +
							"is not an int!", "Error", MessageBoxButtons.OK,
							MessageBoxIcon.Error);
					}
				}

				// Otherwise, do not accept
				else
				{
					MessageBox.Show("Error: Value entered for row " +
						"is out of range!", "Error", MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				}
			}

			// Otherwise, do not accept
			else
			{
				MessageBox.Show("Error: Value entered for row is not an int!",
					"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Sends guess to ScanAnalyzer, updates form
		public void EvaluateGuess(int row, int col)
		{
			// Sends guess to ScanAnalyzer for analysis
			bool found = ScanAnalyzer.EvaluateGuess(row, col);

			// Displays grid after done
			ScanAnalyzer.DisplayGrid();

			// Update the visible grid
			UpdateGrid();

			// Update guess response label
			// If sample found, say sample found
			if (found)
			{
				labelGuessResponse.Text = "Sample found!";
			}

			// Else, figure out which direction to say
			else
			{
				// Take the contents of the grid space,
				// say which way to go depending on the arrow used
				switch (ScanAnalyzer.GetGridPos(row, col))
				{
					// If ^, go up
					case '^':
						labelGuessResponse.Text = "Go up...";
						break;

					// If v, go down
					case 'v':
						labelGuessResponse.Text = "Go down...";
						break;

					// If <, go left
					case '<':
						labelGuessResponse.Text = "Go left...";
						break;

					// If >, go right
					case '>':
						labelGuessResponse.Text = "Go right...";
						break;
				}
			}

			// Show Last Guess and Guess Response labels
			ShowGuessFeedback();

			// Clear the guess text boxes
			ResetGuessTextBoxes();

			// Update Guesses label
			labelGuesses.Text = $"Guesses: {ScanAnalyzer.GetGuesses()}";
			labelLastGuess.Text = $"Last guess: {row}, {col}";

			// Check to see if user has won
			if (ScanAnalyzer.GetWin())
			{
				WinGame();
			}
		}

		// Updates the grid once the ScanAnalyzer has finished updating it
		public void UpdateGrid()
		{
			// Reset the grid
			labelGrid.Text = "";

			// Iterate through the grid rows
			for (int i = 0; i < ScanAnalyzer.GetRows(); i++)
			{
				// Iterate through the grid columns
				for (int j = 0; j < ScanAnalyzer.GetCols(); j++)
				{
					// Write the contents of the coordinates of matrix to grid
					labelGrid.Text += $"{ScanAnalyzer.GetGridPos(i, j)} ";
				}
				labelGrid.Text += "\n";
			}
		}

		// Makes the previous guess and guess response labels visible
		public void ShowGuessFeedback()
		{
			labelLastGuess.Visible = true;
			labelGuessResponse.Visible = true;
		}

		// Clears the guess row and column text boxes
		public void ResetGuessTextBoxes()
		{
			textBoxGuessRow.Clear();
			textBoxGuessColumn.Clear();
		}

		// Called when the user wins the game
		public void WinGame()
		{
			// Yay!
			MessageBox.Show("You win!\nYou found both samples in " +
				$"{ScanAnalyzer.GetGuesses()} guesses!", "SUCCESS!",
				MessageBoxButtons.OK, MessageBoxIcon.Information);

			// Ask user if they would like to play again
			var choice = MessageBox.Show("Would you like to play again?",
				"Play again?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			// If yes, reset the game
			if (choice == DialogResult.Yes)
			{
				NewGame();
			}

			// If not, exit the application
			else if (choice == DialogResult.No)
			{
				// Show the author before closing
				MessageBox.Show("Program written by Cory Michener.", "Author",
					MessageBoxButtons.OK, MessageBoxIcon.Information);

				// Exit application
				Application.Exit();
			}
		}

		// When Start Game button is clicked, checks the grid size for validity
		private void buttonStartGame_Click(object sender, EventArgs e)
		{
			CheckGridSizeValidity();
		}

		// When Submit Guess button is clicked, checks the guess for validity
		private void buttonSubmitGuess_Click(object sender, EventArgs e)
		{
			CheckGuessValidity();
		}
	}
}

