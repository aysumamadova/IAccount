using System;
using System.Collections.Generic;
using System.Text;

namespace Generic2.Models
{
    internal class Generic<T>

        where T : IPrintableFile
    {
        public void Print(T file)
        {
            if (file is Excel e1) e1.Print();
            else if (file is PDF p1) p1.Print();
            else if (file is Word w1) w1.Print();
        }

    }
}
