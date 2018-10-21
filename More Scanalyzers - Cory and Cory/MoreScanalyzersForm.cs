using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//TODO Add links to images
//	Case File: http://quabbinvalleyparanormal.com/casefile07-004.JPG

namespace More_Scanalyzers___Cory_and_Cory
{
	public partial class MoreScanalyzersForm : Form
	{
		// Form constructor
		public MoreScanalyzersForm()
		{
			InitializeComponent();
			DisplayStartScreen();
		}

		// Public methods
		// A comical method to let the user know they done goofed
		public void YouRuinedIt()
		{
			MessageBox.Show("(╯°□°）╯You ruined it!! You killed the magic!!");
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
				openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory()
					.Replace("bin\\Debug", "assets\\input files");
				openFileDialog1.Filter = "Case files (*.case)|*.case|All files (*.*)|*.*";
				openFileDialog1.FilterIndex = 0;
				openFileDialog1.RestoreDirectory = true;

				// If OK is clicked, set selected file as file name
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
					fileName = openFileDialog1.FileName;
			}

			// Return the path of the file to check its validity
			return fileName;
		}

		public void CheckCaseFile(string fileName)
		{
			// Only check file name if it exists
			if (fileName != null)
			{
				// If file isn't the right file type, throw InvalidFileType exception
				if (fileName.Substring(fileName.LastIndexOf('.')) != ".case")
				{
					//TODO Create InvalidFileType exception
					MessageBox.Show("BAD! D:");
				}
				// Otherwise, check the validity of the file contents
				else
				{
					// Read file into string array
					string[] text = File.ReadAllLines(fileName);

					// Get file size
					int size = text.Length;

					//TODO If file isn't the correct length, throw CorruptCaseFile exception
					if (size != 7)
					{

					}
					// Otherwise, get parameters
					string[] caseInfo =
					{
						text[3].Substring(text[3].IndexOf(':') + 2),
						text[4].Substring(text[4].IndexOf(':') + 2),
						text[5].Substring(text[5].IndexOf(':') + 2),
						text[6].Substring(text[6].IndexOf(':') + 2)
					};


					//TODO If any parameters are invalid, throw CorruptCaseFile exception

					//TODO Let user choose scanalyzer


					DisplayGameScreen(caseInfo);
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

			// Hide submit guess
			labelGuessRow.Hide();
			labelGuessColumn.Hide();
			textBoxGuessRow.Hide();
			textBoxGuessColumn.Hide();
			buttonSubmitGuess.Hide();

			// Resize form
			this.Size = new Size(456, 240);

			// Move title
			pictureBoxScanner1.Location = new Point(12, 12);
			pictureBox1.Location = new Point(375, 12);
			labelTitle.Location = new Point(72, 20);

			// Move instructions below the title
			labelInstructionsTitle.Location = new Point(174, 72);
			labelInstructions.Location = new Point(82, 100);
			labelInstructions.Text = "We have many unsolved cases that require" +
				" investigation.\n" + "    Click the button below to select a " +
				"case to investigate.";

			// Show and move case file buttons
			buttonOpenCaseFile.Show();
			buttonOpenCaseFile.Location = new Point(117, 136);
			buttonCreateCaseFile.Show();
			buttonCreateCaseFile.Location = new Point(223, 136);
		}
		// Display the game screen after loading a valid case file
		public void DisplayGameScreen(string[] caseInfo)
		{
			// Set form size
			this.Size = new Size(600, 500);

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
			//TODO labelSampleType.Text = $"Sample Type: {sampleType}";
			labelNumberOfSamples.Text = $"Number of Samples: {caseInfo[3]}";

			// Show the guess GUI at the right of the screen
			//TODO labelGuesses.Text = $"Guesses: {guesses}";
			labelGuesses.Show();

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

			// Render grid
			labelGrid.Show();
			labelGridRows.Show();
			labelGridColumns.Show();

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
	}
}
