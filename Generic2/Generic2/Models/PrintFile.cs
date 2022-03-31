using System;
using System.Collections.Generic;
using System.Text;

namespace Generic2.Models
{
    class PrintFile
    {
        public PrintFile(IPrintableFile file)
        {
            file.Print();
        }

    }
}
