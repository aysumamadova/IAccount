using System;
using System.Collections.Generic;
using System.Text;

namespace Generic2.Models
{
    class PDF:IPrintableFile
    {
        public int PageCount { get; set; }
        public string FileName { get; set; }

        public PDF(string fileName, int pageCount)
        {
            FileName = fileName;
            PageCount = pageCount;
        }

        public void Print()
        {
            Console.WriteLine($"{FileName} printed\nPage count {PageCount}");
        }
    }
}
