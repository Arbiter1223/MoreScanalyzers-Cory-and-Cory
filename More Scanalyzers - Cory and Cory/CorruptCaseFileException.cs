using System;

namespace More_Scanalyzers___Cory_and_Cory
{
	class CorruptCaseFileException : ApplicationException
	{
		// Constructors
		public CorruptCaseFileException() :
			base("Data in file is corrupted." +
				"\n\n" + MoreScanalyzersForm.YouRuinedIt())
		{

		}

		public CorruptCaseFileException(string message) :
			base(message + "\n\n" + MoreScanalyzersForm.YouRuinedIt())
		{

		}

		public CorruptCaseFileException(string message, Exception inner) :
			base(message, inner)
		{

		}
	}
}
