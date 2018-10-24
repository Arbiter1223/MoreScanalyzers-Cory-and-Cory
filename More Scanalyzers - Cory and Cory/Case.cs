using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace More_Scanalyzers___Cory_and_Cory
{
    //Case
    //Controls specific case and its scanlyzer
    class Case
    {
        private int caseNum;
        private int samples;
        private int rows;
        private int cols;
        private Scanlyzer scaner;

        public Case(int cNum, int r, int c, int s, char type){
            Random rand = new Random();
            caseNum = cNum;
            samples = s;

            int[][] S;
            S = new int[samples][];

            rows = r;
            cols = c;

            int tempR;
            int tempC;

            //creates random sample locations
            for(int i = 0; i < samples; i++)
            {
                S[i] = new int[2];

                tempR = rand.Next(0, rows);
                tempC = rand.Next(0, cols);

                //loops through until unique coordinates are
                //generated
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

            //creates new scanalyzer depending on type
            switch (type)
            {
                case '@':
                    scaner = new FingerprintAnalyzer(r, c, samples, S);
                    break;
                case 'S':
                    scaner = new HairAnalyzer(r, c, samples, S);
                    break;
                case '*':
                    scaner = new BloodAnalyzer(r, c, samples, S);
                    break;
            }
        }

        //processes guess made by user
        public char makeGeuss(int r, int c)
        {
            //if the found all samples show congratulations box
            //and return
            if (scaner.processGeuss(r, c))
            {
                return '!';
            }
            return scaner.getBoardChar(r, c);
        }

        //returns board as a string
        public string boardToString()
        {
            return scaner.boardToString();
        }

        //returns case number
        public int getCaseNum()
        {
            return caseNum;
        }

        //returns number of row of the board
        public int getRows()
        {
            return rows;
        }

        //returns number of columns of the board
        public int getColumns()
        {
            return cols;
        }

        //returns total samples in case
        public int getSamples()
        {
            return samples;
        }

        //returns samples found
        public int getSamplesFound()
        {
            return scaner.getFound();
        }

        //return what type of scaner the case is
        public string getScanerType()
        {
           return scaner.getType();
        }

        //returns geusses made on the case so far
        public int getGeusses()
        {
            return scaner.getGeusses();
        }

        //return specific char from board
        public char getScanerBoardChar(int r, int c)
        {
            return scaner.getBoardChar(r, c);
        }

        //retruns true if user is out of geusses
        public bool outOfGeusses()
        {
            return scaner.getGeusses() > 29;
        }

    }
}
