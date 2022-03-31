using System;
using System.Collections.Generic;
using System.Text;

namespace Generic2.Models
{
    class Word:IPrintableFile
    {
        public int WordCount { get; set; }
        public string FileName { get; set; }
        public Word(string fileName, int wordCount)
        {
            FileName = fileName;
            WordCount = wordCount;
        }

        public void Print()
        {
            Console.WriteLine($"{FileName} printed\nWord count {WordCount}");
        }
    }
}
