using Generic_types.Models;
using System;
using System.Collections.Generic;

namespace Generic_types
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> mylist = new MyList<string>();
            mylist.Add("Aysu");
            mylist.Add("ghjjj"); 
            mylist.Add("task"); 
            mylist.Add("pdf"); 
            mylist.Insert(9,"747");
            //list.Clear();
            //- Exist()
            //- Remove()
            //- Reverse()
            //- IndexOf()
            
            foreach (var item in mylist) 
            {

                Console.WriteLine(item);


            }

            Console.WriteLine(mylist.Count);

        }
    }
}
