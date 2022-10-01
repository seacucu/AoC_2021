using System;
using System.Collections;
using static System.Console;
using static AdventOfCode.File;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            BitFile file03 = new BitFile("03");
            BitDiagnostic diagnostic = new BitDiagnostic(12);            
            string[] content = (string[])file03.ReadFile(FileType.TEST, true);

            diagnostic.CountBinary(content);
            diagnostic.CalcEpsilon();

            WriteLine($"Gamma Rate: {diagnostic.GammaRate}");
            WriteLine($"Epsilon Rate: {diagnostic.EpsilonRate}");
            WriteLine($"Power Consumption: {diagnostic.PowerConsumption}");
        }        
    }
}