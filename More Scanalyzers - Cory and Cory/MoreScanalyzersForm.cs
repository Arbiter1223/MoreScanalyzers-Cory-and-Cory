//*******************************************************************************
// Cory Michener and Cory Press
// October 22, 2018
// Program 5 - More Scanalyzers!
// MoreScanalyzersForm.cs
// Holds primary form where user can open or create case files
//	and play the game
//*******************************************************************************

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Scanalyzer;

//	Scanner: https://vignette4.wikia.nocookie.net/subnautica/images/7/78/Scanner
//		.png/revision/latest/scale-to-width-down/54?cb=20170502164029
//	Blood Stain: http://weknowyourdreams.com/images/stains/stains-11.jpg
//	DNA: https://cheshirelibraryscience.files.wordpress.com/2013/12/dna.jpg
//	Fingerprint: http://www.knowmuhammad.org/
//		files/029fe4745a2a7fc4c0b2e4511093b925.jpg
//	Hair Follicle: http://www.hairsite.com/hair-loss/img/uploaded/200_image8.jpg
//	Magnifying Glass: http://www.clker.com/clipart-2195.html
//	Case File: http://quabbinvalleyparanormal.com/casefile07-004.JPG

namespace More_Scanalyzers___Cory_and_Cory
{
	public partial class MoreScanalyzersForm : Form
	{
        private Case scene;
        private PictureBox[][] pics;

		// Form constructor
		public MoreScanalyzersForm()
		{
			InitializeComponent();
			DisplayStartScreen();
		}

		// Public methods
		// A comical method to let the user know they done goofed
		static public string YouRuinedIt()
		{
			return "(╯°□°）╯You ruined it!! You killed the magic!!";
		}
		// Open file dialog
		public string OpenCaseFile()
		{
			// Reset file path name variable
			string fileName = null;

			// Open the Open File Dialog
			using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
			{
				// Initial settings
				openFileDialog1.InitialDirectory = Directory
					.GetCurrentDirectory()
					.Replace("bin\\Debug", "assets\\input files");
				openFileDialog1.Filter =
					"Case files (*.case)|*.case|All files (*.*)|*.*";
				openFileDialog1.FilterIndex = 0;
				openFileDialog1.RestoreDirectory = true;

				// If OK is clicked, set selected file as file name
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
					fileName = openFileDialog1.FileName;
			}

			// Return the path of the file to check its validity
			return fileName;
		}
		// Check case file, throw exception if needed
		public void CheckCaseFile(string fileName)
		{
			// Only check file name if it exists
			if (fileName != null)
			{
				try
				{
					// If file isn't the right file type,
					// throw InvalidFileType exception
					if (fileName.Substring(fileName.LastIndexOf('.')) != ".case")
						throw new InvalidFileTypeException();

					// Read file into string array
					string[] text = File.ReadAllLines(fileName);

					// Get file size
					int size = text.Length;

					// If file isn't the correct length,
					// throw CorruptCaseFile exception
					if (size != 7)
						throw new CorruptCaseFileException();

					// Otherwise, get parameters
					string[] caseInfo =
					{
						text[3].Substring(text[3].IndexOf(':') + 2),
						text[4].Substring(text[4].IndexOf(':') + 2),
						text[5].Substring(text[5].IndexOf(':') + 2),
						text[6].Substring(text[6].IndexOf(':') + 2)
					};

					// If any parameters are invalid,
					// throw CorrupeCaseFile exception
					if (!CheckParameterValidity(caseInfo))
						throw new CorruptCaseFileException();

					// Otherwise, proceed with file data
					// Default choice
					int scanner = 0;

					// Let user choose scanalyzer
					SelectScanalyzerForm selectScanalyzerForm =
						new SelectScanalyzerForm();
					selectScanalyzerForm.ShowDialog();

					// Choice after form closes
					scanner = selectScanalyzerForm.scanner;

					// Instantiate the appropriate scanalyzer type
					char type;
					switch (scanner)
					{
						case 1:
							type = '*';
							break;
						case 2:
							type = 'S';
							break;
						case 0:
						default:
							type = '@';
							break;
					}

					// Convert case parameters to integers
					int caseName = Int32.Parse(caseInfo[0]);
					int rows = Int32.Parse(caseInfo[1]);
					int cols = Int32.Parse(caseInfo[2]);
					int samples = Int32.Parse(caseInfo[3]);

					// Create new case with file parameters
					scene = new Case(caseName, rows, cols,
						samples, type);

					// Set up initial game screen
					DisplayGameScreen(caseInfo);

					// Add any leading zeros to Case Number
					// to make it four digits
					string caseNum = scene.getCaseNum().ToString();
					switch (caseNum.Length)
					{
						case 1:
							caseNum = "000" + caseNum;
							break;
						case 2:
							caseNum = "00" + caseNum;
							break;
						case 3:
							caseNum = "0" + caseNum;
							break;
						default:
							break;
					}

					// Initializes gameboard labels
					this.labelGrid.Text = scene.boardToString();
                    this.labelCaseNumber.Text = "Case Number: " + caseNum;
                    this.labelGridSize.Text = "Grid Size: " + scene.getRows() +
						" X " + scene.getColumns();
                    this.labelSampleType.Text = "Sample Type: " +
						scene.getScanerType();
                    this.labelNumberOfSamples.Text = "Number of Samples: " +
						samples;
                    this.labelGuesses.Text = "Guesses: " + 0;
                    this.labelLastGuess.Text = "Last Guess: none";
                    this.labelGuessResponse.Text = "";
                    this.buttonSubmitGuess.Enabled = true;

                    this.labelGridRows.Text = "";
                    for (int i = 0; i < scene.getRows(); i++)
                        this.labelGridRows.Text += "" + i + '\n';
                    this.labelGridColumns.Text = "";
                    for (int i = 0; i < scene.getColumns(); i++)
                        this.labelGridColumns.Text += " " + i;
                }

				// If file is not a .case file, handle the exception
				catch (InvalidFileTypeException error)
				{
					MessageBox.Show(error.Message, "ERROR: Invalid file type.",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				// If .case file is in incorrect format, handle the exception
				catch (CorruptCaseFileException error)
				{
					MessageBox.Show(error.Message,
						"ERROR: Case file is corrupted.",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		// The first screen the user sees before he/she selects a case
		public void DisplayStartScreen()
		{
			// Hide case information
			labelCaseNumber.Hide();
			labelGridSize.Hide();
			labelSampleType.Hide();
			labelNumberOfSamples.Hide();

			// Hide grid
			labelGrid.Hide();
			labelGridRows.Hide();
			labelGridColumns.Hide();

			// Hide guesses
			labelGuesses.Hide();
			labelLastGuess.Hide();
			labelGuessResponse.Hide();
			buttonGiveUp.Hide();

			// Hide submit guess
			labelGuessRow.Hide();
			labelGuessColumn.Hide();
			textBoxGuessRow.Hide();
			textBoxGuessColumn.Hide();
			buttonSubmitGuess.Hide();

			// Resize and center form
			this.Size = new Size(456, 240);
			this.CenterToScreen();

			// Move title
			pictureBoxScanner1.Location = new Point(12, 12);
			pictureBox1.Location = new Point(375, 12);
			labelTitle.Location = new Point(72, 20);

			// Move instructions below the title
			labelInstructionsTitle.Location = new Point(174, 62);
			labelInstructions.Location = new Point(82, 88);
			labelInstructions.Text = "We have many unsolved cases that require" +
				" investigation.\n" + "    Click the left button to select a " +
				"case to investigate.\n" + "          Click the right button " +
				"to create a new case.";

			// Show and move case file buttons
			buttonOpenCaseFile.Show();
			buttonOpenCaseFile.Location = new Point(117, 136);
			buttonCreateCaseFile.Show();
			buttonCreateCaseFile.Location = new Point(223, 136);
		}
		// Display the game screen after loading a valid case file
		public void DisplayGameScreen(string[] caseInfo)
		{
			// Set form size and center
			this.Size = new Size(600, 500);
			this.CenterToScreen();

			// Shift title
			pictureBoxScanner1.Location = new Point(84, 12);
			pictureBox1.Location = new Point(447, 12);
			labelTitle.Location = new Point(144, 20);

			// Hide case file buttons
			buttonOpenCaseFile.Hide();
			buttonCreateCaseFile.Hide();

			// Move instructions to side
			labelInstructionsTitle.Location = new Point(46, 103);
			labelInstructions.Location = new Point(12, 127);

			// Update instructions
			labelInstructions.Text = "Enter the coordinates of a space\n" +
				"at the bottom of the form to reveal\n" +
				"that space. Must be within the\n" +
				"bounds of the grid.";

			// Update case information
			labelCaseNumber.Text = $"Case Number {caseInfo[0]}";
			labelGridSize.Text = $"Grid Size: {caseInfo[1]} x {caseInfo[2]}";
			labelNumberOfSamples.Text = $"Number of Samples: {caseInfo[3]}";

			// Show the guess GUI at the right of the screen
			labelGuesses.Show();
			buttonGiveUp.Show();

			// Show submit guess
			labelGuessRow.Show();
			labelGuessColumn.Show();
			textBoxGuessRow.Show();
			textBoxGuessColumn.Show();
			buttonSubmitGuess.Show();

			// Show case information
			labelCaseNumber.Show();
			labelGridSize.Show();
			labelSampleType.Show();
			labelNumberOfSamples.Show();
            labelGuessResponse.Show();
            labelLastGuess.Show();

			// Render grid
			labelGridRows.Show();
			labelGridColumns.Show();

            if(scene.getScanerType() == "blood ")
            {
                pics = new PictureBox[scene.getRows()][];
                for(int r = 0; r < scene.getRows(); r++)
                {
                    pics[r] = new PictureBox[scene.getColumns()];
                    for(int c = 0; c < scene.getColumns(); c++)
                    {
                        pics[r][c] = new PictureBox();
                        pics[r][c].Location = new Point
							(199 + (c * 20), 198 + (r * 18));
                        pics[r][c].Size = new Size(14, 14);
                        pics[r][c].BackgroundImage = Properties
							.Resources.questionmark;
                        pics[r][c].BackgroundImageLayout = ImageLayout.Stretch;
                        pics[r][c].Anchor = AnchorStyles.Left;
                        pics[r][c].Visible = true;
                        this.Controls.Add(pics[r][c]);
                    }
                }
            }
            else
                labelGrid.Show();
        }
		// Check validity of case file parameters
		public bool CheckParameterValidity(string[] caseInfo)
		{
			// Case Number must be an integer
			if (int.TryParse(caseInfo[0], out int w))
			{
				// Case number has to be in range of 0 - 9999
				if (!((w >= 0) & (w <= 9999)))
					return false;
			}
			else
				return false;

			// Row Number must be an integer
			if (int.TryParse(caseInfo[1], out int x))
			{
				// Number of rows has to be in range of 2 - 10
				if (!((x >= 2) & (x <= 10)))
					return false;
			}
			else
				return false;

			// Column Number must be an integer
			if (int.TryParse(caseInfo[2], out int y))
			{
				// Number of columns has to be in range of 2 - 10
				if (!((y >= 2) & (y <= 10)))
					return false;
			}
			else
				return false;

			// Sample Number must be an integer
			if (int.TryParse(caseInfo[3], out int z))
			{
				// Number of samples has to be in range of 1 - 8
				// Cannot be greater than grid size!
				if (!((z >= 1) & (z <= 8) & (z <= (x * y))))
					return false;
			}
			else
				return false;

			// If everything checks out, return true
			return true;
		}
		// Get user's choice for if they want to play another game
		public bool AnotherGame()
		{
			// Ask user if they would like to play again
			var choice = MessageBox.Show("Would you like to play again?",
				"Once more?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			// If yes, return true
			if (choice == DialogResult.Yes)
				return true;
			// If not, return false
			else
				return false;
		}
		// Display message box asking if user would like to play again
		public void PlayAgain()
		{
			// Ask if user wants to play again
			if (AnotherGame())
				DisplayStartScreen();	// If so, go back to start screen
			// Otherwise, close form, exit application
			else
				this.Close();
		}

        public void hidePics()
        {
			// Only hide images if using the blood scanalyzer
			if (scene.getScanerType() == "blood ")
			{
				for (int r = 0; r < scene.getRows(); r++)
				{
					for (int c = 0; c < scene.getColumns(); c++)
						pics[r][c].Visible = false;
				}
			}
        }

		// Event Handlers
		private void buttonOpenCaseFile_Click(object sender, EventArgs e)
		{
			// Choose a file to open
			string fileName = OpenCaseFile();
			
			// Check to make sure file is valid
			CheckCaseFile(fileName);
		}
		private void buttonCreateCaseFile_Click(object sender, EventArgs e)
		{
			CreateCaseFileForm NewCaseFileForm = new CreateCaseFileForm();
			NewCaseFileForm.ShowDialog();
		}

        private void buttonSubmitGuess_Click(object sender, EventArgs e)
        {
            int r, c;
            if (!Int32.TryParse(textBoxGuessRow.Text, out r) ||
            !Int32.TryParse(textBoxGuessColumn.Text, out c))
            {
                MessageBox.Show("You entered an Invalid Row or Column"
                    + " number", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                if (r < scene.getRows() && r >= 0 &&
                    c < scene.getColumns() && c >= 0)
                {
                    char ch = scene.makeGuess(r, c);
                    labelLastGuess.Text = "Last Guess: " + r + ", " + c;
                    labelGuesses.Text = "Guesses Left: " + scene.getGuesses()
                        + " / " + 30;

                    if (scene.getScanerType() == "blood ")
                    {
                        switch (ch)
                        {
                            case '^':
                                labelGuessResponse.Text = "Go Up...";
                                pics[r][c].BackgroundImage = Properties
									.Resources.up_arrow;
                                pics[r][c].Refresh();
                                break;
                            case 'v':
                                labelGuessResponse.Text = "Go Down...";
                                pics[r][c].BackgroundImage = Properties
									.Resources.down;
                                pics[r][c].Refresh();
                                break;
                            case '>':
                                labelGuessResponse.Text = "Go Right...";
                                pics[r][c].BackgroundImage = Properties
									.Resources.right_arrow;
                                pics[r][c].Refresh();
                                break;
                            case '<':
                                labelGuessResponse.Text = "Go Left...";
                                pics[r][c].BackgroundImage = Properties
									.Resources.left_arrow;
                                pics[r][c].Refresh();
                                break;
                            case '!':
                                pics[r][c].BackgroundImage = Properties
									.Resources.bloodStain1;
                                pics[r][c].Refresh();
                                for (r = 0; r < scene.getRows(); r++)
                                {
                                    for (c = 0; c < scene.getColumns(); c++)
                                    {
                                        if (!(scene.getScanerBoardChar
											(r, c) == '*'))
                                        {
                                            pics[r][c].BackgroundImage =
												Properties.Resources
												.questionmark;
                                            pics[r][c].Refresh();
                                        }
                                    }
                                }
                                MessageBox.Show("Congratulations! You found all "
                                    + scene.getSamples() + " " +
									scene.getScanerType() + "sample(s).",
                                    "", MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                                labelGuessResponse.Text = "";
                                hidePics();
                                PlayAgain();
                                break;
                            default:
                                pics[r][c].BackgroundImage = Properties
									.Resources.bloodStain1;
                                pics[r][c].Refresh();
                                for (r = 0; r < scene.getRows(); r++)
                                {
                                    for (c = 0; c < scene.getColumns(); c++)
                                    {
                                        if(!(scene.getScanerBoardChar
											(r, c) == '*'))
                                        {
                                            pics[r][c].BackgroundImage =
												Properties.Resources
												.questionmark;
                                            pics[r][c].Refresh();
                                            pics[r][c].Visible = true;
                                        }
                                    }
                                }
                                break;
                        }
                    }
                    else
                    {
                        string board = scene.boardToString();

                        labelGrid.Text = board;

                        switch (ch)
                        {
                            case '^':
                                labelGuessResponse.Text = "Go Up...";
                                break;
                            case 'v':
                                labelGuessResponse.Text = "Go Down...";
                                break;
                            case '>':
                                labelGuessResponse.Text = "Go Right...";
                                break;
                            case '<':
                                labelGuessResponse.Text = "Go Left...";
                                break;
                            case '!':
                                MessageBox.Show("Congratulation! You found all "
                                    + scene.getSamples() + " " +
									scene.getScanerType() + "samples",
                                    "", MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                                labelGuessResponse.Text = "";
								PlayAgain();
								break;
                            default:
                                break;
                        }
                    }

                    if (scene.outOfGuesses())
                    {
                        MessageBox.Show("You Lose! You found only "
                            + scene.getSamplesFound() + " " +
							scene.getScanerType() + "samples "
                            + "out of " + scene.getSamples(),
                            "", MessageBoxButtons.OK,
                            MessageBoxIcon.Hand);
                        buttonSubmitGuess.Enabled = false;
						PlayAgain();
                    }
                }

                else
                {
                    MessageBox.Show("You entered an Invalid Row or Column"
                    + " number", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }

			// Reset text boxes after evaluating guess
			textBoxGuessRow.Clear();
			textBoxGuessColumn.Clear();
        }

		private void buttonGiveUp_Click(object sender, EventArgs e)
		{
			// Ask user if they really want to quit
			var choice = MessageBox.Show("Are you sure you want to quit?",
				"Give up?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			// If yes, return to start menu
			if (choice == DialogResult.Yes)
            {
                DisplayStartScreen();
                hidePics();
            }
		}
	}
}
