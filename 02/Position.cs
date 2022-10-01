using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
        /*-------- 常數 --------*/
        /*-------- 方法 --------*/

namespace AdventOfCode
{
    class Position
    {
        /*---- 屬性&支援欄位 ----*/
        public int Horizontal { get; set; }
        public int Depth { get; set; }
        public int Aim { get; set; }
        public int Product { get { return Horizontal * Depth; } }

        /*------- 建構式 -------*/
        public Position(int horizontal = 0, int depth = 0, int aim = 0)
        {
            Horizontal = horizontal;
            Depth = depth;
            Aim = aim;
        }
    }
}