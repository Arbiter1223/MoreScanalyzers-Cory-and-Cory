namespace More_Scanalyzers___Cory_and_Cory
{
    class HairAnalyzer : Scanlyzer
    {
        private Board game;

        public HairAnalyzer(int r, int c, int numLocs, int[][] locs) :
			base(r, c, numLocs, locs)
        {
            game = new Board(r, c, 'S');
        }

        public HairAnalyzer(int r, int c, int numLocs, int[][] locs, char type) :
			base(r, c, numLocs, locs)
        {
            game = new Board(r, c, type);
        }

        public override bool processGuess(int r, int c)
        {
			if (game.changeBoard(r, c, EvidenceLocations[piecesFound][0],
				EvidenceLocations[piecesFound][1]))
				piecesFound++;
			if (allFound())
                return true;
            else
                return false;
        }

		public override int getGuesses()
		{
			return game.getGuesses();
		}

		public override string getType()
		{
			return "hair ";
		}

		public override char getBoardChar(int r, int c)
		{
			return game.getChar(r, c);
		}

		public override string boardToString()
        {
            return game.GameBoardToString();
        }
    }
}
