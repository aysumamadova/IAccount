using System;
using System.Collections.Generic;
using System.Text;

namespace Generic2.Models
{
    interface IPrintableFile
    {
        public string FileName { get; set; }
        public void Print();
    }
}
