using System;
using Generic2.Models;

namespace Generic2
{
    class Program
    {
        static void Main(string[] args)
        {
            PDF p1 = new PDF("PDF", 233);
            Word w1 = new Word("Word", 233);
            Excel e1 = new Excel("Excel", 23, 33);
            Console.WriteLine("---------------PDF-------------");
            new PrintFile(p1);
            Console.WriteLine("---------------Word-------------");
            new PrintFile(w1);
            Console.WriteLine("---------------Excel-------------");
            new PrintFile(e1);

            Console.WriteLine("-------------Generic-------------");
            Generic<IPrintableFile> generic = new Generic<IPrintableFile>();
            Console.WriteLine("---------------Word-------------");
            generic.Print(w1);
            Console.WriteLine("---------------Excel-------------");
            generic.Print(e1);
            Console.WriteLine("---------------PDF-------------");
            generic.Print(p1);
        }
    }
}
