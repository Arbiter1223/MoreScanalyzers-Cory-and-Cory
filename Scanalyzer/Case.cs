using System;

namespace Scanalyzer
{
    public class Case
    {
        private int caseNum;
        private int samples;
        private int rows;
        private int cols;
        private Scanlyzer scanner;

        public Case(int cNum, int r, int c, int s, char type)
		{
            Random rand = new Random();
            caseNum = cNum;
            samples = s;

            int[][] S;
            S = new int[samples][];

            rows = r;
            cols = c;

            int tempR;
            int tempC;

            // Creates random sample locations
            for(int i = 0; i < samples; i++)
            {
                S[i] = new int[2];

                tempR = rand.Next(0, rows);
                tempC = rand.Next(0, cols);

                // Loops through until unique coordinates are generated
                for(int j = 0; j < i; j++)
                {
                    if (tempR == S[j][0] && tempC == S[j][1])
                    {
                        tempR = rand.Next(0, rows);
                        tempC = rand.Next(0, cols);
                        j = 0;
                    }
                }
                S[i][0] = tempR;
                S[i][1] = tempC;
            }

            // Creates new scanalyzer depending on type
            switch (type)
            {
                case '@':
                    scanner = new FingerprintAnalyzer(r, c, samples, S);
                    break;
                case 'S':
                    scanner = new HairAnalyzer(r, c, samples, S);
                    break;
                case '*':
                    scanner = new BloodAnalyzer(r, c, samples, S);
                    break;
            }
        }

        public char makeGuess(int r, int c)
        {
            // If the found all samples show congratulations box
            // and return
            if (scanner.processGuess(r, c))
                return '!';
            return scanner.getBoardChar(r, c);
        }

        public string boardToString()
        {
            return scanner.boardToString();
        }

        public int getCaseNum()
        {
            return caseNum;
        }

        public int getRows()
        {
            return rows;
        }

        public int getColumns()
        {
            return cols;
        }

        public int getSamples()
        {
            return samples;
        }

        public int getSamplesFound()
        {
            return scanner.getFound();
        }

        public string getScanerType()
        {
           return scanner.getType();
        }

        public int getGuesses()
        {
            return scanner.getGuesses();
        }

        public char getScanerBoardChar(int r, int c)
        {
            return scanner.getBoardChar(r, c);
        }

        public bool outOfGuesses()
        {
            return scanner.getGuesses() > 29;
        }
    }
}
