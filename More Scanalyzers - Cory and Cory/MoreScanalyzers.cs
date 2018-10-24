//*******************************************************************************
// Cory Michener and Cory Press
// October 23, 2018
// Program 5 - More Scanalyzers!
// MoreScanalyzers.cs
// Holds Main function, starts program
//*******************************************************************************

using System;
using System.Windows.Forms;
using Scanalyzer; 

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
