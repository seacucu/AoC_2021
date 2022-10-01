using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace AdventOfCode
{
    internal class BitFile : File
    {
        /*------- 建構式 -------*/
        /// <summary></summary>
        /// <param name="folderName">要讀取的檔案所在的資料夾名稱</param>
        public BitFile(string folderName) : base(folderName) { }

        /*-------- 方法 --------*/
        public override Array ReadFile(FileType fileType, bool showContent = false)
        {
            Content = System.IO.File.ReadAllLines((fileType == FileType.TEST) ?
                TestFilePath : ExampleFilePath);
            if (showContent) 
                DisplayContent(Content);
            return Content;
        }
    }
}