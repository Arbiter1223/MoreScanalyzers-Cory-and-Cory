﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace More_Scanalyzers___Cory_and_Cory
{

    class Case : MoreScanalyzersForm
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

        public char makeGeuss(int r, int c)
        {
            //if the found all samples show congratulations box
            //and return
            if (scaner.processGeuss(r, c))
            {
                MessageBox.Show("Congratulation! You found all "
                    + samples + " " + scaner.getType() + "samples",
                    "", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

            if (outOfGeusses())
            {
                MessageBox.Show("You Lose! You found only "
                    + scaner.getFound() + " " + scaner.getType() + "samples "
                    + "out of " + samples,
                    "", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
                buttonSubmitGuess.Enabled = false;
            }

            return scaner.getBoardChar(r, c);
        }

        public string boardToString()
        {
            return scaner.boardToString();
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

        public string getScanerType()
        {
           return scaner.getType();
        }

        public int getGeusses()
        {
            return scaner.getGeusses();
        }

        private bool outOfGeusses()
        {
            return scaner.getGeusses() > 29;
        }

    }
}
