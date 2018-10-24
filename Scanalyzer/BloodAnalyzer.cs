namespace Scanalyzer
{
    class BloodAnalyzer : Scanlyzer
    {
        private Board game;

        public BloodAnalyzer(int r, int c, int numLocs, int[][] locs) :
			base(r, c, numLocs, locs)
        {
            game = new Board(r, c, '*');
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
            return "blood ";
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
