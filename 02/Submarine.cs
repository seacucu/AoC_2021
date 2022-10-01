using System;
using System.Collections.Generic;
using System.Text;
        /*-------- 常數 --------*/
        /*------- 建構式 -------*/

namespace AdventOfCode
{
    internal class Submarine
    {
        /*---- 屬性&支援欄位 ----*/
        public Position pos = new Position();

        /*-------- 方法 --------*/
        public void UpdatePosition(string direction, int delta)
        {
            switch (direction)
            {
                case "down":
                    pos.Aim += delta;  break;
                case "up":
                    pos.Aim -= delta;  break;
                case "forward":
                    pos.Horizontal += delta;
                    pos.Depth += pos.Aim * delta;
                    break;
                default:    break;
            }
        }
    }
}