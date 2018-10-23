//*******************************************************************************
// Cory Michener and Cory Press
// <DATE FINISHED HERE>
// Program 5 - More Scanalyzers!
// MoreScanalyzers.cs
// Holds Main function, starts program
//*******************************************************************************

//TODO CM - Work on form, input file, etc
//TODO CP - Work on classes, program structure

//++Objectives
//TODO Create library (dll) of classes
//x Instantiate objects of classes in an inheritance hierarchy
//x Use Polymorphism to output each object's attributes
//x TODO Use a label
//x TODO Use text boxes
//x TODO Use buttons
//x Use switch statement
//x Use exception handling
//x TODO (╯°□°）╯You ruined it!! You killed the magic!!

//x Three-level inheritance hierarchy
//x 5 classes of Scanalyzers
//x Use Analyzer as the abstract base class of the hierarchy
//x Have PrintAnalyzer to find as many fingerprints (‘@’) as it can in a grid representing some object
//x Second analyzer to collect DNA/hair/fiber/etc.samples in a grid representing a room.
//x Create third scanalyzer class that inherits from second scanalyzer
//	Must be different enough from the other two but has different member data or overridden methods from second scanalyzer
//x TODO Put the R/W files somewhere

//+Your program will do the following:
//x Have the user select the input data file
//x Allow the user to select what type of evidence to collect(via buttons)
//TODO Show the result of the evidence collection
//TODO	Returns a string to display the results of all fingerprints(‘@’) found in a label
//TODO	Returns a reference to a 2D array of picture boxes created dynamically at run time to displays an
//TODO	image of evidence collected(boundary lines could be visible or invisible?).  Find some.png files
//TODO Display a message indicating the success of the evidence collection
//TODO Display a message for the number of fingerprints or samples collected
//x Show a message box in some exception handler if there is some problem with the input file
//x (╯°□°）╯You ruined it!! You killed the magic!!

//x INPUT:
//x Sample INPUT values are attached.  User should be able to
//x	enter the name of the file
//x	enter the data from the file and store in object’s class variables

//+OUTPUT:
//x Output is all done on a form. The form should display
//x	The filename(case number/name)
//x	Type of evidence currently being examined
//TODO	Results of evidence collection: Success, number collected, “image”

//+TURN IN all materials in a 9x12 envelope:
//	Print out of documented Source code
//	Screen dump(s) of image(s) when running
//	Application on some storage media.The application is in a debug folder.
//	Partner log file
//	Peer evaluation form
//x	In an envelope 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace More_Scanalyzers___Cory_and_Cory
{
	static class MoreScanalyzers
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			MoreScanalyzersForm Scanalyzers = new MoreScanalyzersForm();

			Application.Run(Scanalyzers);

			MessageBox.Show("Program written by Cory and Cory.", "About program",
				MessageBoxButtons.OK, MessageBoxIcon.Information);

			Application.Exit();
		}
	}
}
