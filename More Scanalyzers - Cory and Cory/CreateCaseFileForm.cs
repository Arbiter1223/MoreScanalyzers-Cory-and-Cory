//*******************************************************************************
// Cory Michener and Cory Press
// October 21, 2018
// Program 5 - More Scanalyzers!
// CreateCaseFileForm.cs
// Code for the form allowing the user to create case files
//*******************************************************************************

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

namespace More_Scanalyzers___Cory_and_Cory
{
	public partial class CreateCaseFileForm : Form
	{
		// Constructor
		public CreateCaseFileForm()
		{
			InitializeComponent();
		}

		// Public methods
		public void SaveCaseFile()
		{
			// Add any leading zeros to Case Number to make it four digits
			switch (textBoxCaseNumber.Text.Length)
			{
				case 1:
					textBoxCaseNumber.Text = "000" + textBoxCaseNumber.Text;
					break;
				case 2:
					textBoxCaseNumber.Text = "00" + textBoxCaseNumber.Text;
					break;
				case 3:
					textBoxCaseNumber.Text = "0" + textBoxCaseNumber.Text;
					break;
				default:
					break;
			}

			// Path to save file with file name
			string path = Directory.GetCurrentDirectory().Replace("bin\\Debug",
				"assets\\input files\\") + textBoxCaseNumber.Text + ".case";

			// Get formatted data from form
			string[] text = FormatCaseFile();

			// Write data to file
			File.WriteAllLines(path, text);

			// Display success message box
			MessageBox.Show("Case file successfully saved.");

			// Close the form
			this.Close();
		}
		public bool CheckCaseFile()
		{
			// If any parameters are invalid, return false
			if (textBoxCaseNumber.BackColor == Color.Red | 
				textBoxNumberOfRows.BackColor == Color.Red | 
				textBoxNumberOfColumns.BackColor == Color.Red | 
				textBoxNumberOfSamples.BackColor == Color.Red)
				return false;
			// If everything checks out, return true
			else
				return true;
		}
		// Format parameters from form into file format
		public string[] FormatCaseFile()
		{
			// Save formatted data into new string array
			string[] text =
			{
				"Scanalyzer Case File",
				$"Case Modified: {DateTime.Now.ToString()}",
				"--------------------------------------------------------------",
				$"Case Number: {textBoxCaseNumber.Text}",
				$"Rows: {textBoxNumberOfRows.Text}",
				$"Columns: {textBoxNumberOfColumns.Text}",
				$"Samples: {textBoxNumberOfSamples.Text}"
			 };

			return text;
		}
		// Case Number validity check
		public void CheckCaseNumber()
		{
			// Must be an integer
			if (int.TryParse(textBoxCaseNumber.Text, out int x))
			{
				// Case number has to be in range of 0 - 9999
				if (!((x >= 0) & (x <= 9999)))
					textBoxCaseNumber.BackColor = Color.Red;
				else
					textBoxCaseNumber.BackColor = Color.White;
			}
			else
				textBoxCaseNumber.BackColor = Color.Red;
		}
		// Row Number validity check
		public void CheckRowNumber()
		{
			// Must be an integer
			if (int.TryParse(textBoxNumberOfRows.Text, out int x))
			{
				// Number of rows has to be in range of 2 - 10
				if (!((x >= 2) & (x <= 10)))
					textBoxNumberOfRows.BackColor = Color.Red;
				else
					textBoxNumberOfRows.BackColor = Color.White;
			}
			else
				textBoxNumberOfRows.BackColor = Color.Red;
		}
		// Column Number validity check
		public void CheckColumnNumber()
		{
			// Must be an integer
			if (int.TryParse(textBoxNumberOfColumns.Text, out int x))
			{
				// Number of columns has to be in range of 2 - 10
				if (!((x >= 2) & (x <= 10)))
					textBoxNumberOfColumns.BackColor = Color.Red;
				else
					textBoxNumberOfColumns.BackColor = Color.White;
			}
			else
				textBoxNumberOfColumns.BackColor = Color.Red;
		}
		// Sample Number validity check
		public void CheckSampleNumber()
		{
			// Must be an integer
			if (int.TryParse(textBoxNumberOfSamples.Text, out int x))
			{
				// Get rows and columns
				int.TryParse(textBoxNumberOfRows.Text, out int rows);
				int.TryParse(textBoxNumberOfColumns.Text, out int cols);

				// Number of samples has to be in range of 1 - 8
				// Cannot be greater than grid size!
				if (!((x >= 1) & (x <= 8) & (x <= (rows * cols))))
					textBoxNumberOfSamples.BackColor = Color.Red;
				else
					textBoxNumberOfSamples.BackColor = Color.White;
			}
			else
				textBoxNumberOfSamples.BackColor = Color.Red;
		}

		// Event Handlers
		private void buttonSaveCaseFile_Click(object sender, EventArgs e)
		{
			// If everything in form is valid, save case file
			if (CheckCaseFile())
				SaveCaseFile();
			// Otherwise, display error message
			else
				MessageBox.Show("Error(s) detected in entered parameters. " +
					"Cannot save case file.", "ERROR", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
		}
		// Used for real-time validity checking
		private void textBoxCaseNumber_TextChanged(object sender, EventArgs e)
		{
			CheckCaseNumber();
		}
		private void textBoxNumberOfRows_TextChanged(object sender, EventArgs e)
		{
			CheckRowNumber();
			CheckSampleNumber();
		}
		private void textBoxNumberOfColumns_TextChanged
			(object sender, EventArgs e)
		{
			CheckColumnNumber();
			CheckSampleNumber();
		}
		private void textBoxNumberOfSamples_TextChanged
			(object sender, EventArgs e)
		{
			CheckSampleNumber();
		}
	}
}
