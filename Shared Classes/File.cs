using System;
using System.IO;
using static System.Console;
using System.Collections.Generic;

namespace AdventOfCode
{   
    public class File
    {
        /*---- 屬性&支援欄位 ----*/
        protected string TestFilePath { get; set; }
        protected string ExampleFilePath { get;  set; }
        public enum FileType { TEST, EXAMPLE }
        public string[] Content { get; protected set; }

        /*------- 建構式 -------*/
        /// <summary></summary>
        /// <param name="folderName">要讀取的檔案所在的資料夾名稱</param>
        public File(string folderName)
        {            
            TestFilePath = 
                $"C:\\Users\\Chloe\\OneDrive\\C#學習專案儲存庫\\" +
                $"Advent of Code\\AOC_2021\\{folderName}\\_test.txt";
            ExampleFilePath =
                $"C:\\Users\\Chloe\\OneDrive\\C#學習專案儲存庫\\" +
                $"Advent of Code\\AOC_2021\\{folderName}\\_example.txt";
        }

        /*-------- 方法 --------*/
        /// <summary>讀取檔案，參數選擇要範例或測試檔。</summary>
        /// <param name="fileType">讀取EXAMPLE範例或TEST測試。</param>
        /// <param name="showContent">是否印出檔案內容。</param>
        /// <returns>檔案內容陣列。</returns>
        public virtual Array ReadFile(FileType fileType, bool showContent = false)
        {
            Content = System.IO.File.ReadAllLines((fileType == FileType.TEST)?
                TestFilePath : ExampleFilePath);

            // 測試輸入是否為 int
            if (Int32.TryParse(Content[0], out int a))
            {
                int[] resultInt = new int[Content.Length];
                for (int i = 0; i < Content.Length; i++)
                {
                    // 將 string 陣列的每個元素轉為 int 並存入 int 陣列
                    resultInt[i] = Convert.ToInt32(Content[i]);
                }
                if (showContent) DisplayContent(resultInt);
                return resultInt;
            }
            // 輸入為 string
            else
            {
                if (showContent) DisplayContent(Content);
                return Content;
            }
        }
        static public void DisplayContent(Array content)
        {
            foreach (var line in content) WriteLine(line);
        }

        public int GetDirectionAndDelta(int index, out string direction)
        {
            string[] splitedLine = Content[index].Split(" ");
            direction = splitedLine[0];
            int delta = Convert.ToInt32(splitedLine[1]);
            return delta;
        }
    }
}