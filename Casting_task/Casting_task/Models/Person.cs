using System;
using System.Collections.Generic;
using System.Text;

namespace Casting_task.Models
{
  abstract class Person
    {
        private static int _id = 0;
        public int İD{ get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
       
        public Person()
        {
            ++_id;
            İD = _id;
        }

        public abstract string ShowInfo();
        
    }

   
}
