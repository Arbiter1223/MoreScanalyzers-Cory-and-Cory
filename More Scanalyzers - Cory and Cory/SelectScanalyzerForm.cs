//*******************************************************************************
// Cory Michener and Cory Press
// October 22, 2018
// Program 5 - More Scanalyzers!
// SelectScanalyzerForm.cs
// Lets the user select which scanalyzer they want to use
//*******************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace More_Scanalyzers___Cory_and_Cory
{
	public partial class SelectScanalyzerForm : Form
	{
		// Public Variable (for returning to main form)
		public int scanner;

		// Constructor
		public SelectScanalyzerForm()
		{
			InitializeComponent();
		}

		// Event Handlers
		private void buttonConfirm_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void radioButtonFingerPrint_CheckedChanged
			(object sender, EventArgs e)
		{
			if (radioButtonFingerPrint.Checked)
				scanner = 0;
		}
		private void radioButtonBloodStain_CheckedChanged
			(object sender, EventArgs e)
		{
			if (radioButtonBloodStain.Checked)
				scanner = 1;
		}
		private void radioButtonHairFollicle_CheckedChanged
			(object sender, EventArgs e)
		{
			if (radioButtonHairFollicle.Checked)
				scanner = 2;
		}
	}
}
