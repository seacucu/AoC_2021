using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace AdventOfCode
{
    class BitDiagnostic
    {
        /*---- 屬性&支援欄位 ----*/
        private int digits = 12;
        private string comparedResult;
        public int GammaRate { get; private set; }
        public int EpsilonRate { get; private set; }
        public int PowerConsumption {
            get { return GammaRate * EpsilonRate; } }

        /*--------建構式--------*/
        public BitDiagnostic(int digits) => this.digits = digits;

        /*-------- 方法 --------*/
        public void CountBinary(string[] content)
        {
            int[] bitCount0 = new int[digits];
            int[] bitCount1 = new int[digits];
            for (int i = 0; i < content.Length; i++)
            {
                for (int j = 0; j < digits; j++)
                {
                    if (content[i][j] == '0')
                        bitCount0[j]++;
                    else
                        bitCount1[j]++;
                }
            }
            CompareBinary(bitCount0, bitCount1);
        }

        public void CompareBinary(int[] count0, int[] count1)
        {
            int[] compareArray = new int[digits];
            for (int j = 0; j < digits; j++)
            {
                //WriteLine($"第 {j} 直欄有 {count0[j]} 個 0，{count1[j]} 個 1");
                if (count0[j] < count1[j])
                    compareArray[j] = 1;
            }
            comparedResult = string.Join("", compareArray);
            GammaRate = Convert.ToInt32(comparedResult, 2);            
        }

        public void CalcEpsilon()
        {
            int[] epsilon = new int[digits];
            for(int i = 0; i < digits; i++)
            {
                epsilon[i] = (comparedResult[i] == '1') ? 0 : 1;
            }
            string reversed = string.Join("", epsilon);
            EpsilonRate = Convert.ToInt32(reversed, 2);
        }

    }
}