using System;
using System.Collections.Generic;
using System.Text;

namespace Generic2.Models
{
    class Excel:IPrintableFile
    {
        public int ColumnCount { get; set; }
        public int RowCount { get; set; }
        public string FileName { get; set; }

        public Excel(string fileName, int columnCount, int rowCount)
        {
            FileName = fileName;
            ColumnCount = columnCount;
            RowCount = rowCount;
        }

        public void Print()
        {
            Console.WriteLine($"{FileName} printed\nColum Count {ColumnCount}\nRow count {RowCount}");
        }
    }
}
