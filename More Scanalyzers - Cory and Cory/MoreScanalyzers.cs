//*******************************************************************************
// Cory Michener and Cory Press
// <DATE FINISHED HERE>
// Program 5 - More Scanalyzers!
// MoreScanalyzers.cs
// Holds Main function, starts program
//*******************************************************************************
//TODO Possibly improve/ammend/change description

//++Objectives
//TODO Create library (dll) of classes
//TODO Instantiate objects of classes in an inheritance hierarchy
//TODO Use Polymorphism to output each object's attributes
//TODO Use a label
//TODO Use text boxes
//TODO Use buttons
//TODO Use switch statement
//TODO Use exception handling

//TODO Three-level inheritance hierarchy
//TODO 5 classes of Scanalyzers
//TODO Use Analyzer as the abstract base class of the hierarchy
//TODO Have PrintAnalyzer to find as many fingerprints (‘@’) as it can in a grid representing some object
//TODO Second analyzer to collect DNA/hair/fiber/etc.samples in a grid representing a room.

//You should come up with a third analyzer class that inherits from the second analyzer that is different enough from the other two, but has different member data / or overridden methods from the second analyzer.
//Input for the crime will come from a file this time
//Your instructor will give you code to read the data – you decide where you want to store it

//+Your program will do the following:
//Have the user select the input data file
//Allow the user to select what type of evidence to collect(via buttons)
//Show the result of the evidence collection
//	Returns a string to displays the results of all fingerprints(‘@’) found in a label
//	Returns a reference to a 2D array of picture boxes created dynamically at run time to displays an
//	image of evidence collected(boundary lines could be visible or invisible?).  Find some.png files
//Displays a message indicating the success of the evidence collection
//Displays a messages on the number of fingerprints or samples collected
//Show a message box in some exception handler if there is some problem with the input file

//+INPUT:
//Sample INPUT values are attached.  User should be able to
//	enter the name of the file
//	enter the data from the file and store in object’s class variables

//+OUTPUT:
//Output is all done on a form. The form should display
//	The filename(case number/name)
//	Type of evidence currently being examined
//	Results of evidence collection: Success, number collected, “image”

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
		}
	}
}
