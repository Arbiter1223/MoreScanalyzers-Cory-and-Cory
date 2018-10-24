using System;

namespace More_Scanalyzers___Cory_and_Cory
{
	class InvalidFileTypeException : ApplicationException
	{
		// Constructors
		public InvalidFileTypeException() :
			base("Illegal file type accessed." +
				"\n\n" + MoreScanalyzersForm.YouRuinedIt())
		{

		}

		public InvalidFileTypeException(string message) :
			base(message + "\n\n" + MoreScanalyzersForm.YouRuinedIt())
		{
			
		}

		public InvalidFileTypeException(string message, Exception inner) :
			base(message, inner)
		{

		}
	}
}
