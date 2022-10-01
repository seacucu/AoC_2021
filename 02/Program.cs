using System;
using static System.Console;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            File file02 = new File("02");
            Submarine submarine = new Submarine();
            file02.ReadFile(File.FileType.TEST);

            for (int i = 0; i < file02.Content.Length; i++)
            {
                int delta = file02.GetDirectionAndDelta(i, out string dir);
                submarine.UpdatePosition(dir, delta);
            }

            WriteLine($"Final Position: ({submarine.pos.Horizontal}, {submarine.pos.Depth})");
            WriteLine($"Multiple Product: {submarine.pos.Product}");
        }
    }
}